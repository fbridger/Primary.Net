using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    public class Argentina
    {
        public readonly static Argentina Data = new Argentina();
        private CancellationTokenSource _tokenSource;

        public Primary.Api Api;
        public IEnumerable<Instrument> AllInstruments;
        private MarketDataWebSocket marketDataSocket;
        public delegate void MarketDataEventHandler(Instrument instrument, Entries data);
        public event MarketDataEventHandler OnMarketData;
        public ConcurrentDictionary<string, Entries> LatestMarketData = new ConcurrentDictionary<string, Entries>();

        public Entries GetLatestOrNull(string symbol)
        {
            if (LatestMarketData.ContainsKey(symbol))
            {
                return LatestMarketData[symbol];
            }

            return null;
        }

        public Argentina()
        {
            Api = new Api(Api.ProductionEndpoint);
            _tokenSource = new CancellationTokenSource();
        }

        public async Task Init()
        {
            AllInstruments = await Api.GetAllInstruments();
        }

        public IEnumerable<Task> WatchWithRestApi(Instrument[] instruments)
        {
            foreach (var instrument in instruments)
            {
                var task = Task.Factory.StartNew(() => PullMarketData(Api, instrument), _tokenSource.Token,
                                                   TaskCreationOptions.LongRunning,
                                                   TaskScheduler.Default);

                yield return task.Unwrap();
            }
        }

        public Task WatchWithWebSocket(Instrument[] instruments)
        {
            // Subscribe to all entries
            marketDataSocket = Api.CreateMarketDataSocket(instruments, Constants.AllEntries, 1, 5);

            marketDataSocket.OnData = OnReceiveMarketData;
            return marketDataSocket.Start().Unwrap();
        }

        private void OnReceiveMarketData(Api api, MarketData marketData)
        {
            if (marketData.Instrument != null)
            {
                //Console.WriteLine(marketData.Instrument?.Symbol + ": " + marketData.Data?.Last?.Price);
                LatestMarketData.AddOrUpdate(marketData.Instrument.Symbol, marketData.Data, (key, data) => marketData.Data);

                OnMarketData?.Invoke(marketData.Instrument, marketData.Data);

            }
        }

        private async Task PullMarketData(Api api, Instrument instrument)
        {
            while (true)
            {
                try
                {
                    var marketDataRestApi = await api.GetMarketData(instrument);

                    LatestMarketData.AddOrUpdate(instrument.Symbol, marketDataRestApi.Data, (key, data) => marketDataRestApi.Data);

                    OnMarketData?.Invoke(instrument, marketDataRestApi.Data);

                    await Task.Delay(TimeSpan.FromSeconds(3), _tokenSource.Token);

                    if (_tokenSource.IsCancellationRequested)
                    {
                        return;
                    }
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex);
                    return;
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw ex;
                }
            }

        }

        public IEnumerable<Task> RefreshMarketData(Instrument[] instruments)
        {
            foreach (var instrument in instruments)
            {
                yield return RefreshMarketData(instrument);
            }
        }

        public async Task RefreshMarketData(Instrument instrument)
        {
            try
            {
                var marketDataRestApi = await Api.GetMarketData(instrument);

                LatestMarketData.AddOrUpdate(instrument.Symbol, marketDataRestApi.Data, (key, data) => marketDataRestApi.Data);

                OnMarketData?.Invoke(instrument, marketDataRestApi.Data);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
