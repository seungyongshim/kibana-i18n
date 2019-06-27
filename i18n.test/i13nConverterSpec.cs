using Newtonsoft.Json;
using System;
using System.IO;
using Xunit;
using i18n.DTO;
using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;

namespace i18n.Tests
{
    public partial class i13nConverterSpec
    {
        [Fact]
        public void RemoveNoKibana()
        {
            // Arrange
            JToken expected = JToken.Parse(resultSample);

            // Act
            string output = i13nConverter.RemoveNoKibana(sample);

            // Assert
            JToken actual = JToken.Parse(output);
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void RemoveNoKibanaAndUpdate()
        {
            // Arrange
            JToken expected = JToken.Parse(resultRefSample);

            // Act
            string output = i13nConverter.RemoveNoKibanaAndUpdate(sample, refSample);

            // Assert
            JToken actual = JToken.Parse(output);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
