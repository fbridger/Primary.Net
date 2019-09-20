using FluentAssertions;
using NUnit.Framework;
using Primary.Data.Serialization;
using System;

namespace Primary.Tests.Serialization
{
    internal class UnixTimeMillisecondsConverterTests
    {
        [Test]
        public void ShouldConvertFromUnixTimestamp()
        {
            var result = UnixTimeMillisecondsConverter.DateTimeFromUnixTimeMilliseconds(1568996805496L);

            var localDate = new DateTimeOffset(2019, 9, 20, 13, 26, 45, 496, TimeSpan.FromHours(-3)).LocalDateTime;
            result.Should().Be(localDate);
        }

        [Test]
        public void ShouldConvertToUnixTimestamp()
        {
            var localDate = new DateTimeOffset(2019, 9, 20, 13, 26, 45, 496, TimeSpan.FromHours(-3)).LocalDateTime;

            var result = UnixTimeMillisecondsConverter.UnixTimeMillisecondsFromDateTime(localDate);

            result.Should().Be(1568996805496L);
        }
    }
}
