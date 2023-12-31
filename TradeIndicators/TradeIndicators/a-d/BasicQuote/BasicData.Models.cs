using System;
using Skender.Stock.Indicators;

namespace Skender.Stock.Indicators
{

    public interface IBasicData
    {
        DateTime Date { get; }
        double Value { get; }
    }

    public class BasicData : ISeries, IBasicData, IReusableResult
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }

        double? IReusableResult.Value => Value;
    }
}
