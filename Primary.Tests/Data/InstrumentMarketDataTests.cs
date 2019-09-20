using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using Primary.Data;
using System;
using System.Net;

namespace Primary.Tests.Data
{
    internal class InstrumentMarketDataTests
    {

        [Test]
        public void InstrumentMarketDataValue_ShouldDeserializeJson()
        {
            var json = @"{
         ""price"":57.650,
         ""size"":1000,
         ""date"":1568996805496
      }";

            var result = JsonConvert.DeserializeObject<InstrumentMarketDataValue>(json);

            result.Should().NotBeNull();
            result.Price.Should().Be(57.65M);
            result.Size.Should().Be(1000M);
            result.Date.Should().Be(new DateTimeOffset(2019, 9, 20, 13, 26, 45, 496, TimeSpan.FromHours(-3)).LocalDateTime);
        }

        [Test]
        public void InstrumentMarketDataResponse_ShouldDeserializeJson()
        {
            var json = @"{
   ""status"":""OK"",
   ""marketData"":{
      ""OP"":57.715,
      ""LA"":{
         ""price"":57.650,
         ""size"":1000,
         ""date"":1568996805496
      },
      ""LO"":57.531,
      ""IV"":null,
      ""SE"":{
         ""price"":58.170,
         ""size"":null,
         ""date"":1568592000000
      },
      ""TV"":7000,
      ""NV"":8000,
      ""EV"":403329000.000,
      ""CL"":{
         ""price"":57.710,
         ""size"":null,
         ""date"":1568851200000
      },
      ""HI"":57.715,
      ""BI"":[
         {
            ""price"":57.760,
            ""size"":2000
         },
         {
            ""price"":57.400,
            ""size"":1000
         },
         {
            ""price"":57.280,
            ""size"":1000
         },
         {
            ""price"":57.190,
            ""size"":1000
         },
         {
            ""price"":57.160,
            ""size"":1000
         }
      ],
      ""OF"":[
         {
            ""price"":57.803,
            ""size"":1000
         },
         {
            ""price"":57.850,
            ""size"":1000
         },
         {
            ""price"":58.100,
            ""size"":2000
         },
         {
            ""price"":58.120,
            ""size"":1000
         },
         {
            ""price"":58.230,
            ""size"":1000
         }
      ],
      ""OI"":{
         ""price"":null,
         ""size"":692668,
         ""date"":1568592000000
      }
   },
   ""depth"":5,
   ""aggregated"":true
}";

            var result = JsonConvert.DeserializeObject<InstrumentMarketDataResponse>(json);

            result.Should().NotBeNull();
            result.Status.Should().Be("OK");
            result.Depth.Should().Be(5);
            result.Aggregated.Should().BeTrue();
            result.MarketData.Open.Should().Be(57.715M);

            result.MarketData.Last.Price.Should().Be(57.65M);
            result.MarketData.Last.Size.Should().Be(1000M);


            result.MarketData.Low.Should().Be(57.531M);
            result.MarketData.IndexValue.Should().Be(null);
            
            result.MarketData.Settlement.Price.Should().Be(58.17M);
            result.MarketData.Settlement.Size.Should().Be(null);

            result.MarketData.Volume.Should().Be(7000M);
            result.MarketData.NominalVolume.Should().Be(8000M);
            result.MarketData.EffectiveVolume.Should().Be(403329000M);

            result.MarketData.Close.Price.Should().Be(57.710M);
            result.MarketData.Close.Size.Should().Be(null);

            result.MarketData.High.Should().Be(57.715M);

            result.MarketData.Bids.Should().HaveCount(5);
            result.MarketData.Bids[0].Price.Should().Be(57.760M);
            result.MarketData.Bids[0].Size.Should().Be(2000M);

            result.MarketData.Offers.Should().HaveCount(5);
            result.MarketData.Offers[0].Price.Should().Be(57.803M);
            result.MarketData.Offers[0].Size.Should().Be(1000M);
        }
    }
}
