using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetCode._049_GroupAnagramsSolution
{
    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if(strs.Length == 0) return new List<IList<string>>();

            var resultDict = new Dictionary<string, IList<string>>();
            strs.ToList().ForEach(str =>
            {
                var key = new StringBuilder();
                str.OrderBy(c => c).ToList().ForEach(c => key.Append(c));

                if (!resultDict.ContainsKey(key.ToString())) resultDict.Add(key.ToString(), new List<string> {str});
                else resultDict[key.ToString()].Add(str);
            });

            var result = new List<IList<string>>();
            resultDict.Values.ToList().ForEach(list => result.Add(list.OrderBy(s => s).ToList()));
            return result;
        }
    }
}