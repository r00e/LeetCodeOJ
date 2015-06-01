using System;
using System.Collections.Generic;
using System.Linq;

namespace leetCode._06_ZigZagConversion
{
    public class ZigZagConversionSolution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            var result = "";

            for (var currentLine = 0; currentLine < numRows; currentLine++)
            {
                var isFirstOrLastLine = currentLine == 0 || currentLine == numRows - 1 ? true : false;
                var index = currentLine;
                
                while (index < s.Length)
                {
                    if (isFirstOrLastLine)
                    {
                        result += s[index];
                        index += 2 * (numRows - 1);
                    }
                    else
                    {
                        result += s[index];
                        index += GetOffset(currentLine, numRows);
                        if (index >= s.Length) continue;
                        result += s[index];
                        index += 2 * currentLine;
                    }
                }
            }
            return result;
        }

        private int GetOffset(int currentLine, int numRows)
        {
            return 2*(numRows - currentLine - 1);
        }
    }
}