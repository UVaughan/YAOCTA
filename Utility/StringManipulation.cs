using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace YAOCTA.Utility
{
    public class StringManipulation
    {
        public static string FormatStopName(string stopName)
        {
            var trimmed = stopName.Trim();
            var capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(trimmed.ToLower());
            var replacedSlashes = capitalized.Replace("/", "and");
            var removedQuotes = replacedSlashes.Replace("\"", "");
            return removedQuotes;
        }
    }
}
