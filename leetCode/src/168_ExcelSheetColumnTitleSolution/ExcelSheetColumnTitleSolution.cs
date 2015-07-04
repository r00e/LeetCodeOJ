using System.Collections.Generic;
using System.Text;

namespace leetCode._168_ExcelSheetColumnTitleSolution
{
    public class ExcelSheetColumnTitleSolution
    {
        private readonly List<string> columnTitle = new List<string>()
        {
            "A", "B", "C", "D", "E", "F", "G",
            "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q",      "R", "S", "T",
            "U", "V", "W",      "X", "Y", "Z"
        };

        public string ConvertToTitle(int n)
        {
            var result = new StringBuilder();

            while (n > 0)
            {
                result.Insert(0, columnTitle[(n - 1)%26]);
                n = (n - 1)/26;
            }

            return result.ToString();
        }
    }
}