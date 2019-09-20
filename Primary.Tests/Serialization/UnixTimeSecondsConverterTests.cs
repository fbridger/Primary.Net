using FluentAssertions;
using NUnit.Framework;
using Primary.Data.Serialization;
using System;

namespace Primary.Tests.Serialization
{
    internal class UnixTimeSecondsConverterTests
    {
        [Test]
        public void ShouldConvertFromUnixTimestamp()
        {
            var result = UnixTimeSecondsConverter.DateTimeFromUnixTimeSeconds(1568996805L);

            var localDate = new DateTimeOffset(2019, 9, 20, 13, 26, 45, TimeSpan.FromHours(-3)).LocalDateTime;
            result.Should().Be(localDate);
        }

        [Test]
        public void ShouldConvertToUnixTimestamp()
        {
            var localDate = new DateTimeOffset(2019, 9, 20, 13, 26, 45, TimeSpan.FromHours(-3)).LocalDateTime;

            var result = UnixTimeSecondsConverter.UnixTimeSecondsFromDateTime(localDate);

            result.Should().Be(1568996805L);
        }
    }
}
