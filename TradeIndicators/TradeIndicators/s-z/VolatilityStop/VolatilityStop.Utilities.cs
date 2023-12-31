using System;
using System.Collections.Generic;
using System.Linq;

namespace Skender.Stock.Indicators {

public static partial class Indicator
{
    // remove recommended periods
    /// <include file='../../_common/Results/info.xml' path='info/type[@name="Prune"]/*' />
    ///
    public static IEnumerable<VolatilityStopResult> RemoveWarmupPeriods(
        this IEnumerable<VolatilityStopResult> results)
    {
        int removePeriods = results
            .ToList()
            .FindIndex(x => x.Sar != null);

        removePeriods = Math.Max(100, removePeriods);

        return results.Remove(removePeriods);
    }
}
}
