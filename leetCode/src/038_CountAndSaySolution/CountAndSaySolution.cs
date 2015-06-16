using System.Linq;
using System.Text;

namespace leetCode._038_CountAndSaySolution
{
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            var result = "1";

            for (var i = 1; i < n; i++)
            {
                result = Helper(result);
            }

            return result;
        }

        private static string Helper(string str)
        {
            var result = new StringBuilder();
                
            var say = str.First();
            var count = 0;

            foreach (char c in str)
            {
                if (c == say)
                {
                    count++;
                }
                else
                {
                    result.Append(count);
                    result.Append(say);
                    say = c;
                    count = 1;
                }
            }

            result.Append(count);
            result.Append(say);
            return result.ToString();
        }
    }
}