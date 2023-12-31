using System.Collections.Generic;
using System.Linq;

namespace Skender.Stock.Indicators {

public static partial class Indicator
{
    // remove recommended periods
    /// <include file='../../_common/Results/info.xml' path='info/type[@name="Prune"]/*' />
    ///
    public static IEnumerable<AroonResult> RemoveWarmupPeriods(
        this IEnumerable<AroonResult> results)
    {
        int removePeriods = results
            .ToList()
            .FindIndex(x => x.Oscillator != null);

        return results.Remove(removePeriods);
    }
}
}
