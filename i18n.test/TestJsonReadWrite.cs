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
    public class TestJsonReadWrite
    {
        [Fact]
        public void Test()
        {
            // Arrange
            JToken expected = JToken.Parse(sample);

            // Act
            var model = JsonConvert.DeserializeObject<Model>(sample);
            string output = JsonConvert.SerializeObject(model);

            // Assert
            JToken actual = JToken.Parse(output);
            actual.Should().BeEquivalentTo(expected);
        }


        string sample =
        @"{ ""formats"": {
    ""number"": {
      ""currency"": {
        ""style"": ""currency""
      },
      ""percent"": {
        ""style"": ""percent""
      }
    },
    ""date"": {
      ""short"": {
        ""month"": ""numeric"",
        ""day"": ""numeric"",
        ""year"": ""2-digit""
      },
      ""medium"": {
        ""month"": ""short"",
        ""day"": ""numeric"",
        ""year"": ""numeric""
      },
      ""long"": {
        ""month"": ""long"",
        ""day"": ""numeric"",
        ""year"": ""numeric""
      },
      ""full"": {
        ""weekday"": ""long"",
        ""month"": ""long"",
        ""day"": ""numeric"",
        ""year"": ""numeric""
      }
    },
    ""time"": {
      ""short"": {
        ""hour"": ""numeric"",
        ""minute"": ""numeric""
      },
      ""medium"": {
        ""hour"": ""numeric"",
        ""minute"": ""numeric"",
        ""second"": ""numeric""
      },
      ""long"": {
        ""hour"": ""numeric"",
        ""minute"": ""numeric"",
        ""second"": ""numeric"",
        ""timeZoneName"": ""short""
      },
      ""full"": {
        ""hour"": ""numeric"",
        ""minute"": ""numeric"",
        ""second"": ""numeric"",
        ""timeZoneName"": ""short""
      }
    },
    ""relative"": {
      ""years"": {
        ""units"": ""year""
      },
      ""months"": {
        ""units"": ""month""
      },
      ""days"": {
        ""units"": ""day""
      },
      ""hours"": {
        ""units"": ""hour""
      },
      ""minutes"": {
        ""units"": ""minute""
      },
      ""seconds"": {
        ""units"": ""second""
      }
    }
  },
  ""messages"": {
    ""common.ui.aggResponse.allDocsTitle"": ""所有文档"",
    ""common.ui.aggResponse.fieldLabel"": ""字段"",
    ""common.ui.aggResponse.valueLabel"": ""值"",
    ""common.ui.aggTypes.aggregateWithLabel"": ""聚合对象"",
    ""common.ui.aggTypes.aggregateWithTooltip"": ""选择将多个命中或多值字段组合成单个指标的策略"",
    ""common.ui.aggTypes.buckets.dateHistogramLabel"": ""{fieldName}/{intervalDescription}"",
    ""common.ui.aggTypes.buckets.dateHistogramTitle"": ""日期直方图"",
    ""common.ui.aggTypes.buckets.dateRangeTitle"": ""日期范围"",
    ""common.ui.aggTypes.buckets.filtersTitle"": ""筛选"",
    ""common.ui.aggTypes.buckets.filterTitle"": ""筛选"",
    ""common.ui.aggTypes.buckets.geohashGridTitle"": ""Geohash"",
    ""common.ui.aggTypes.buckets.histogramTitle"": ""直方图"",
    ""common.ui.aggTypes.buckets.intervalOptions.autoDisplayName"": ""自动"",
    ""common.ui.aggTypes.buckets.intervalOptions.customDisplayName"": ""定制"",
    ""common.ui.aggTypes.buckets.intervalOptions.dailyDisplayName"": ""每日"",
    ""common.ui.aggTypes.buckets.intervalOptions.hourlyDisplayName"": ""每小时"",
    ""common.ui.aggTypes.buckets.intervalOptions.millisecondDisplayName"": ""毫秒"",
    ""common.ui.aggTypes.buckets.intervalOptions.minuteDisplayName"": ""分钟"",
    ""common.ui.aggTypes.buckets.intervalOptions.monthlyDisplayName"": ""每月"",
    ""common.ui.aggTypes.buckets.intervalOptions.secondDisplayName"": ""秒"",
    ""common.ui.aggTypes.buckets.intervalOptions.weeklyDisplayName"": ""每周"",
    ""common.ui.aggTypes.buckets.intervalOptions.yearlyDisplayName"": ""每年"",
    ""common.ui.aggTypes.buckets.ipRangeLabel"": ""{fieldName} IP 范围"",
    ""common.ui.aggTypes.buckets.ipRangeTitle"": ""IPv4 范围"",
    ""common.ui.aggTypes.buckets.ranges.rangesFormatMessage"": ""{from} 至 {to}"",
    ""common.ui.aggTypes.buckets.rangesLabel"": ""{fieldName} 范围"",
    ""common.ui.aggTypes.buckets.rangeTitle"": ""范围"",
    ""common.ui.aggTypes.buckets.significantTermsLabel"": ""{fieldName} 中排名前 {size} 的罕见词"",
    ""common.ui.aggTypes.buckets.significantTermsTitle"": ""重要词"",
    ""common.ui.aggTypes.buckets.terms.missingBucketLabel"": ""缺失"",
    ""common.ui.aggTypes.buckets.terms.orderAscendingTitle"": ""升序"",
    ""common.ui.aggTypes.buckets.terms.orderDescendingTitle"": ""降序"",
    ""common.ui.aggTypes.buckets.terms.otherBucketLabel"": ""其他"",
    ""common.ui.aggTypes.buckets.termsTitle"": ""词"",
    ""common.ui.aggTypes.changePrecisionLabel"": ""更改地图缩放的精确度"",
    ""common.ui.aggTypes.customMetricLabel"": ""定制指标"",
    ""common.ui.aggTypes.customTimeIntervalAriaLabel"": ""定制时间间隔"",
    ""common.ui.aggTypes.dateRanges.acceptedDateFormatsLinkText"": ""已接受日期格式"",
    ""common.ui.aggTypes.dateRanges.addRangeButtonLabel"": ""添加范围"",
    ""common.ui.aggTypes.dateRanges.fromColumnLabel"": ""从"",
    ""common.ui.aggTypes.dateRanges.noCompatibleFieldsDescription"": ""“{indexPatternTitle}” 索引模式不包含任何以下字段类型："",
    ""common.ui.aggTypes.dateRanges.noCompatibleFieldsLabel"": ""无兼容字段："",
    ""common.ui.aggTypes.dateRanges.removeRangeButtonAriaLabel"": ""移除此范围"",
    ""common.ui.aggTypes.dateRanges.requiredDateRangeDescription"": ""必须至少指定一个日期范围。"",
    ""common.ui.aggTypes.dateRanges.requiredDateRangeLabel"": ""必需："",
    ""common.ui.aggTypes.dateRanges.toColumnLabel"": ""到"",
    ""common.ui.aggTypes.definiteMetricLabel"": ""指标：{safeMakeLabel}"",
    ""common.ui.aggTypes.dropPartialBucketsLabel"": ""丢弃部分存储桶"",
    ""common.ui.aggTypes.dropPartialBucketsTooltip"": ""移除超出时间范围的存储桶，以便直方图不以不完整的存储桶开始和结束。"",
    ""common.ui.aggTypes.extendedBounds.maxLabel"": ""最大值"",
    ""common.ui.aggTypes.extendedBounds.maxLabel.optionalText"": ""（可选）"",
    ""common.ui.aggTypes.extendedBounds.minLabel"": ""最小值"",
    ""common.ui.aggTypes.extendedBounds.minLabel.optionalText"": ""（可选）"",
    ""common.ui.aggTypes.extendedBoundsLabel"": ""扩展的边界"",
    ""common.ui.aggTypes.extendedBoundsTooltip"": ""“最小值”和“最大值”不会筛选结果，而会扩展结果集的边界"",
    ""common.ui.aggTypes.field.aggregationFieldTitle"": ""聚合字段"",
    ""common.ui.aggTypes.field.fieldLabel"": ""字段"",
    ""common.ui.aggTypes.field.selectFieldPlaceholder"": ""选择字段"",
    ""common.ui.aggTypes.filters.addFilterButtonLabel"": ""添加筛选"",
    ""common.ui.aggTypes.filters.definiteFilterLabel"": ""筛选 {index} 标签"",
    ""common.ui.aggTypes.filters.filterLabel"": ""筛选 {index}"",
    ""common.ui.aggTypes.filters.labelPlaceholder"": ""标签"",
    ""common.ui.aggTypes.filters.removeFilterButtonAriaLabel"": ""移除此筛选"",
    ""common.ui.aggTypes.filters.requiredFilterDescription"": ""必须指定至少一个筛选。"",
    ""common.ui.aggTypes.filters.requiredFilterLabel"": ""必需："",
    ""common.ui.aggTypes.filters.toggleFilterButtonAriaLabel"": ""切换筛选标签"",
    ""common.ui.aggTypes.histogram.missingMaxMinValuesWarning"": ""无法检索最大值和最小值以自动缩放直方图存储桶。这可能会导致可视化性能低下。"",
    ""common.ui.aggTypes.intervalCreatesTooLargeBucketsTooltip"": ""此时间间隔将创建过大而无法在选定时间范围内显示的存储桶，因此其已缩放至 {bucketDescription}"",
    ""common.ui.aggTypes.intervalCreatesTooManyBucketsTooltip"": ""此时间间隔将创建过多的存储桶，而无法在选定时间范围内全部显示，因此其已缩放至 {bucketDescription}"",
    ""common.ui.aggTypes.ipRanges.cidrMask.addRangeButtonLabel"": ""添加范围"",
    ""common.ui.aggTypes.ipRanges.cidrMask.requiredIpRangeDescription"": ""必须指定至少一个 IP 范围。"",
    ""common.ui.aggTypes.ipRanges.cidrMask.requiredIpRangeLabel"": ""必需："",
    ""common.ui.aggTypes.ipRanges.cidrMaskLabel"": ""CIDR 掩码""
    }
}";

    }
}
