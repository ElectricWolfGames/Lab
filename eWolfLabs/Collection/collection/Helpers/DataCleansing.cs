using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Collection.Helpers
{
    public static class DataCleansing
    {
        public static string RemoveAllStrings(string inbound, List<string> stringToRemove)
        {
            foreach (string str in stringToRemove)
            {
                inbound = inbound.Replace(str, "");
            }

            return inbound;
        }

        public static string RemoveDoubleSpaces(string str)
        {
            string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return string.Join(" ", words);
        }

        private static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
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