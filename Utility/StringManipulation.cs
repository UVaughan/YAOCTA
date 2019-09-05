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
            var capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(stopName.ToLower());
            var replacedSlashes = capitalized.Replace("/", "and");
            return replacedSlashes;
        }
    }
}
