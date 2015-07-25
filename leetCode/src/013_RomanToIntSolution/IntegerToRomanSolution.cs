using System.Collections.Generic;
using System.Text;

namespace leetCode._013_RomanToIntSolution
{
    public class IntegerToRomanSolution
    {
        public string IntToRoman(int num)
        {
            var romanAlphabet = new List<IList<string>>
            {
                new List<string>(){"I", "V"},
                new List<string>(){"X", "L"},
                new List<string>(){"C", "D"},
                new List<string>(){"M"}
            };

            if (num < 1 || num > 3999) return null;

            var digitPosition = 0;
            var tmpResultStack = new Stack<string>();

            while (num > 0)
            {
                var digit = num%10;
                switch (digit)
                {
                    case 1:
                    case 2:
                    case 3:
                    {
                        while (digit > 0)
                        {
                            tmpResultStack.Push(romanAlphabet[digitPosition][0]);
                            digit--;
                        }
                        break;
                    }
                    case 4:
                    {
                        var romanChar = new StringBuilder();
                        romanChar.Append(romanAlphabet[digitPosition][0]);
                        romanChar.Append(romanAlphabet[digitPosition][1]);
                    
                        tmpResultStack.Push(romanChar.ToString());
                        break;
                    }
                    case 5:
                    {
                        tmpResultStack.Push(romanAlphabet[digitPosition][1]);
                        break;
                    }
                    case 6:
                    case 7:
                    case 8:
                    {
                        var romanChar = new StringBuilder();
                        romanChar.Append(romanAlphabet[digitPosition][1]);
                        while (digit - 5 > 0)
                        {
                            romanChar.Append(romanAlphabet[digitPosition][0]);
                            digit--;
                        }

                        tmpResultStack.Push(romanChar.ToString());
                        break;
                    }
                    case 9:
                    {
                        var romanChar = new StringBuilder();
                        romanChar.Append(romanAlphabet[digitPosition][0]);
                        romanChar.Append(romanAlphabet[digitPosition + 1][0]);

                        tmpResultStack.Push(romanChar.ToString());
                        break;
                    }
                }

                digitPosition++;
                num = num/10;
            }

            var result = new StringBuilder();
            while (tmpResultStack.Count != 0)
            {
                result.Append(tmpResultStack.Pop());
            }
            return result.ToString();
        }
    }
}