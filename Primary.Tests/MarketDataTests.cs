using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Primary.Data;

namespace Primary.Tests
{
    [TestFixture]
    internal class MarketDataTests
    {
        [OneTimeSetUp]
        public async Task Login()
        {
            _api = new Api(Api.DemoEndpoint);
            await _api.Login(Api.DemoUsername, Api.DemoPassword);
        }

        private Api _api;

        [Test]
        public async Task ShouldGetMarketDataForDollarFuture()
        {
            var instruments = await _api.GetAllInstruments();

            var dollarFuture = instruments.First(c => c.Symbol.StartsWith("DO"));

            var marketData = await _api.GetMarketDataAsync(dollarFuture.Market, dollarFuture.Symbol);

            marketData.Should().NotBeNull();
            marketData.Last.Should().NotBeNull();
            
        }
    }
}
