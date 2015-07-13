using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace leetCode._205_IsomorphicString
{
    public class IsomorphicStringsSolution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var charPositionForS = GenerateCharPositionForString(s);
            var charPositionForT = GenerateCharPositionForString(t);

            return IsCharPositionSame(charPositionForS, charPositionForT);
        }

        private static bool IsCharPositionSame(Dictionary<char, ICollection<int>> charPositionForS, Dictionary<char, ICollection<int>> charPositionForT)
        {
            if (charPositionForS.Count != charPositionForT.Count) return false;
            return !charPositionForS.Where(
                (t1, i) => 
                    !charPositionForS[charPositionForS.Keys.ToList()[i]].OrderBy(p => p).SequenceEqual(
                        charPositionForT[charPositionForT.Keys.ToList()[i]].OrderBy(p => p))
                ).Any();
        }

        private static Dictionary<char, ICollection<int>> GenerateCharPositionForString(string str)
        {
            var charPosition = new Dictionary<char, ICollection<int>>();
            for (var i = 0; i < str.Length; i++)
            {
                if (!charPosition.ContainsKey(str[i]))
                {
                    charPosition.Add(str[i], new Collection<int> { i });
                }
                else
                {
                    charPosition[str[i]].Add(i);
                }
            }

            return charPosition;
        }
    }
}