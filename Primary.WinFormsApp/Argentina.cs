using Primary.Data;
using Primary.WebSockets;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Primary.WinFormsApp
{
    public class Argentina
    {
        public readonly static Argentina Data = new Argentina();

        public Primary.Api Api;
        public IEnumerable<Instrument> AllInstruments;
        private MarketDataWebSocket marketDataSocket;
        public delegate void MarketDataEventHandler(MarketData marketData);
        public event MarketDataEventHandler OnMarketData;

        public Argentina()
        {
            Api = new Api(Api.ProductionEndpoint);
        }

        public async Task Init()
        {
            AllInstruments = await Api.GetAllInstruments();
        }

        public async Task WatchIntruments(Instrument[] instruments)
        {
            // Subscribe to all entries
            marketDataSocket = Api.CreateMarketDataSocket(instruments, Constants.AllEntries, 1, 5);

            marketDataSocket.OnData = OnReceiveMarketData;
            await marketDataSocket.Start();
        }

        private void OnReceiveMarketData(Api api, MarketData marketData)
        {
            if (marketData.Instrument != null)
            {
                Console.WriteLine(marketData.Instrument?.Symbol + ": " + marketData.Data?.Last?.Price);
                OnMarketData(marketData);
            }
        }
    }
}
