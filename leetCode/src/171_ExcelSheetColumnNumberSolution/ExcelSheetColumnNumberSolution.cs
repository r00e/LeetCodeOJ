namespace leetCode._171_ExcelSheetColumnNumberSolution
{
    public class ExcelSheetColumnNumberSolution
    {
        public int TitleToNumber(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                result = result * 26 + (s[i] - 'A') + 1;
            }
            return result;
        }
    }
}