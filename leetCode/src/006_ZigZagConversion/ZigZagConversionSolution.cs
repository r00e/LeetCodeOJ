namespace leetCode._006_ZigZagConversion
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
                
//                PAYPALISHIRING                the offset between index
//                P.......A.......H.......N             4
//                ..A..P....L..S....I...I....G         2,2
//                ....Y.......I.......R                 4
//                so for the 1st and last line, the offset between 2 characters is 
//                (nRows - 1) + (nRows - 2) + 1 = 2*(nRows - 1)
//                for the other lines, 1st half is
//                2*(nRows - 1) -2*currentLine = 2*(nRows - currentLine - 1)
//                the last half is
//                2*currentLine

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
                        index += 2*(numRows - currentLine - 1);
                        if (index >= s.Length) continue;
                        result += s[index];
                        index += 2 * currentLine;
                    }
                }
            }
            return result;
        }
    }
}