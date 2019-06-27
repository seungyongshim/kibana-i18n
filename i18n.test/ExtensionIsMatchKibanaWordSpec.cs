using FluentAssertions;
using i18n.Extension;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace i18n.Tests
{
    public class ExtensionIsMatchKibanaWordSpec
    {
        [Fact]
        public void StringHasNotKibana()
        {
            var sample = @"所有文档";
            sample.IsMatchKibanaWord().Should().BeFalse();
        }

        [Fact]
        public void StringHasKibana()
        {
            var sample = @"似乎 Kibana 较少地轮询 Elasticsearch。";

            sample.IsMatchKibanaWord().Should().BeTrue();
        }

        [Fact]
        public void StringHaskibana()
        {
            var sample = @"似乎 kibana 较少地轮询 Elasticsearch。";

            sample.IsMatchKibanaWord().Should().BeFalse();
        }
    }
}
