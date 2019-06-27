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
            string sample = @"所有文档";
            sample.IsMatchKibanaWord().Should().BeFalse();
        }

        [Fact]
        public void StringHasKibana()
        {
            string sample = @"似乎 Kibana 较少地轮询 Elasticsearch";

            sample.IsMatchKibanaWord().Should().BeTrue();
        }

        [Fact]
        public void StringHaskibana()
        {
            string sample = @"似乎 kibana 较少地轮询 Elasticsearch";

            sample.IsMatchKibanaWord().Should().BeFalse();
        }


        [Fact]
        public void StringHasUnImportantkibana()
        {
            string sample = @"{allOfKibanaText}";

            sample.IsMatchKibanaWord().Should().BeFalse();
        }

        [Fact]
        public void StringHasBLUECATS()
        {
            string sample = @"BLUE CATS";

            sample.IsMatchKibanaWord().Should().BeTrue();
        }
    }
}
