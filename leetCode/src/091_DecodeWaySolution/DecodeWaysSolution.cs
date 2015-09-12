using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace leetCode._091_DecodeWaySolution
{
    public class DecodeWaysSolution
    {
        public int NumDecodings(string s)
        {
            var dictKey = new Collection<string>
            {
                "1" , "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13",
                "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"
            };

            var decodeWays = new int[s.Length];

            for (var i = 0; i < s.Length; i++)
            {
                var tmp1 = 0;
                var tmp2 = 0;
                if (dictKey.Contains(s[i].ToString(CultureInfo.DefaultThreadCurrentCulture)))
                {
                    tmp1 = i == 0 ? 1 : decodeWays[i - 1];
                }
                if (i > 0 && dictKey.Contains(s.Substring(i - 1, 2)))
                {
                    tmp2 = i == 1 ? 1 : decodeWays[i - 2];
                }

                decodeWays[i] = tmp1 + tmp2;

                if (decodeWays[i] == 0) return 0;
            }

            return decodeWays.LastOrDefault();
        }
    }
}