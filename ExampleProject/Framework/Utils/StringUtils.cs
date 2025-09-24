using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExampleProject.Framework.Utils
{
    internal class StringUtils
    {
        private const string CurrencyRegex = "[^\\d.]";

        public static double GetDoubleFromString(string value)
        {
            var cleaned = Regex.Replace(value, CurrencyRegex, "");
            return double.Parse(cleaned, CultureInfo.InvariantCulture);
        }
    }
}


