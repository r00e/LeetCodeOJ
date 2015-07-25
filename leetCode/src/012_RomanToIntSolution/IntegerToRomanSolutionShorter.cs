using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetCode._012_RomanToIntSolution
{
    public class IntegerToRomanSolutionShorter
    {
        public string IntToRoman(int num)
        {
            var keyNumberToRomanMappint = new Dictionary<int, string>
            {
                {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
                {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
                {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"},
                {1, "I"}
            };

            if (num < 1 || num > 3999) return null;

            var result = new StringBuilder();

            while (num > 0)
            {
                var keyNumber = keyNumberToRomanMappint.Keys.First(key => num >= key);
                result.Append(keyNumberToRomanMappint[keyNumber]);
                num = num - keyNumber;
            }
            

            return result.ToString();
        }
    }
}