using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAOCTA.Utility
{
    public static class StringManipulation
    {
        /// <summary>
        /// Formats stop name
        /// </summary>
        /// <param name="stopName">Raw stop name from OC API</param>
        /// <returns>More readable stop name</returns>
        public static string FormatStopName(string stopName)
        {
            var trimmed = stopName.Trim();
            var capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(trimmed.ToLower());
            var replacedSlashes = capitalized.Replace("/", "and");
            var removedQuotes = replacedSlashes.Replace("\"", "");
            return removedQuotes;
        }

        /// <summary>
        /// Extension method to remove accents from string
        /// Credit: https://stackoverflow.com/a/249126
        /// </summary>
        /// <param name="input">String to modify</param>
        /// <returns>String with no accents</returns>
        public static string RemoveDiacretics(this string input)
        {
            var normalizedString = input.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
