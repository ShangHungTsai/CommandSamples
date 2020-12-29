using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001
{
    public class CheckResult
    {
        public string Source { get; set; }
        public bool Result { get; set; }


    }

    /// <summary>
    /// 在 command pattern 這就是 receiver
    /// </summary>
    public class FormatChecker : IFormatChecker
    {
        public CheckResult CheckLength(string source)
        {
            var result = (source.Length == 29);
            return new CheckResult() { Source = source, Result = result };
        }

        public CheckResult CheckHead(string source)
        {
            string head = source.Substring(0, 3);
            var result = (head == "965");
            return new CheckResult() { Source = source, Result = result };
        }

        public CheckResult CheckFirstDate(string source)
        {
            var dateString = source.Substring(13, 8);
            DateTime date;
            var result = DateTime.TryParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture,
                           System.Globalization.DateTimeStyles.None, out date);
            return new CheckResult() { Source = source, Result = result };
        }

        public CheckResult CheckSecondDate(string source)
        {
            var dateString = source.Substring(21, 8);
            DateTime date;
            var result = DateTime.TryParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture,
                           System.Globalization.DateTimeStyles.None, out date);
            return new CheckResult() { Source = source, Result = result };
        }
    }
}
