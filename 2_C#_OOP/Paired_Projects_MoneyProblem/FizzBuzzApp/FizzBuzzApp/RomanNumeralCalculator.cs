using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace FizzBuzzApp
{
    public class RomanNumeralCalculator
    {
        public static string NumToRomanNumConverter(int num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException(num == 0 ? "There is no Roman numeral for 0." :
                    "The Roman numeral system doesn't have a negative number system.");
            }

            Dictionary<char, int> romanNumeral = new() {
                { 'M', 1000 }, { 'D', 500 }, { 'C', 100 },
                { 'L', 50 }, { 'X', 10 }, {'V', 5}, {'I', 1} };
            Dictionary<string, string> romanNumeralCases = new() {
                {"IIII", "IV"}, {"VIV", "IX"}, {"XXXX", "XL"},
                {"LXL", "XC"}, {"CCCC", "CD"}, {"DCD", "CM"},};

            StringBuilder outputNumerals = new();

            foreach (KeyValuePair<char, int> numeral in romanNumeral)
            {
                int numeralsInNum = num / numeral.Value;
                if (numeralsInNum > 0)
                {
                    outputNumerals.Append(new string(numeral.Key, numeralsInNum));
                    num -= numeral.Value * numeralsInNum;
                }
            }

            foreach (KeyValuePair<string, string> rnc in romanNumeralCases)
                if (outputNumerals.ToString().Contains(rnc.Key))
                    outputNumerals.Replace(rnc.Key, rnc.Value);

            return outputNumerals.ToString();
        }

    }
}
