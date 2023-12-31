using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Skender.Stock.Indicators
{

  /// <summary>Technical indicators and overlays.  See
  /// <see href = "https://dotnet.stockindicators.dev/guide/">
  ///  the Guide</see> for more information.</summary>
  public static partial class Indicator
  {
    private static readonly CultureInfo EnglishCulture = new CultureInfo("en-US", false);
    private static readonly Calendar EnglishCalendar = EnglishCulture.Calendar;

    // Gets the DTFI properties required by GetWeekOfYear.
    private static readonly CalendarWeekRule EnglishCalendarWeekRule = EnglishCulture.DateTimeFormat.CalendarWeekRule;

    private static readonly DayOfWeek EnglishFirstDayOfWeek = EnglishCulture.DateTimeFormat.FirstDayOfWeek;
  }
}
