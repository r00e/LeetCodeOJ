using System.Collections.Generic;
using System.Linq;

namespace leetCode._017_letterCombinationSolution
{
    public class LetterCombinationSolution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if(digits.Length == 0) return new List<string>();

            var digitAlphbetMapping = new Dictionary<string, IList<string>>()
            {
                {"2", new List<string>() {"a", "b", "c"}},
                {"3", new List<string>() {"d", "e", "f"}},
                {"4", new List<string>() {"g", "h", "i"}},
                {"5", new List<string>() {"j", "k", "l"}},
                {"6", new List<string>() {"m", "n", "o"}},
                {"7", new List<string>() {"p", "q", "r", "s"}},
                {"8", new List<string>() {"t", "u", "v"}},
                {"9", new List<string>() {"w", "x", "y", "z"}}
            };

            var allCombinations = new List<string>(){""};

            for (var i = 0; i < digits.Length; i++)
            {
                while (allCombinations.First().Length == i)
                {
                    var currentCombination = allCombinations.First();
                    allCombinations.RemoveAt(0);
                    allCombinations.AddRange(digitAlphbetMapping[digits[i].ToString()].Select(alphbet => currentCombination + alphbet));
                }
            }

            return allCombinations;
        }
    }
}