using System.Collections.Generic;
using System.Linq;

namespace Skender.Stock.Indicators {

public static partial class Indicator
{
    // remove recommended periods
    /// <include file='../../_common/Results/info.xml' path='info/type[@name="Prune"]/*' />
    ///
    public static IEnumerable<StdDevResult> RemoveWarmupPeriods(
        this IEnumerable<StdDevResult> results)
    {
        int removePeriods = results
            .ToList()
            .FindIndex(x => x.StdDev != null);

        return results.Remove(removePeriods);
    }
}
}
