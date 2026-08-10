using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharpLearning
{
    public static class ExtensionMethods
    {
        // string.ToTitleCase()
        public static string ToTitleCase(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(text.ToLower());
        }

        // List.IsNullOrEmpty()
        public static bool IsNullOrEmpty<T>(this List<T> list)
        {
            return list == null || list.Count == 0;
        }

        // int.ToWords() (0-999)
        public static string ToWords(this int number)
        {
            if (number < 0 || number > 999)
                return "Out of range";

            if (number == 0)
                return "Zero";

            string[] units =
            {
                "", "One", "Two", "Three", "Four", "Five",
                "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
                "Twelve", "Thirteen", "Fourteen", "Fifteen",
                "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            };

            string[] tens =
            {
                "", "", "Twenty", "Thirty", "Forty",
                "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
            };

            string words = "";

            if (number >= 100)
            {
                words += units[number / 100] + " Hundred ";
                number %= 100;
            }

            if (number >= 20)
            {
                words += tens[number / 10] + " ";
                number %= 10;
            }

            if (number > 0)
            {
                words += units[number];
            }

            return words.Trim();
        }
    }
}