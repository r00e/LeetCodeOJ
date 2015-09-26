using System.Collections.Generic;
using System.Linq;

namespace leetCode._127_WordLadder
{
    // Time Exceeds Limit
    public class WordLadderSolution
    {
        public int LadderLength(string beginWord, string endWord, ISet<string> wordList)
        {
            if (wordList.Count == 0) return 0;
            if (beginWord == endWord) return 0;

            var list = wordList.ToList();
            var length = 1;
            var layer = new List<string> {beginWord};
            
            while(layer.Count != 0)
            {
                var nextLayer = new List<string>();

                foreach (var str in layer)
                {

                    for (var i = list.Count - 1; i >= 0; i--)
                    {
                        if (!IsOnlyOneCharDiff(list[i], str)) continue;
                        if (list[i] == endWord) return length + 1;
                        if (IsOnlyOneCharDiff(endWord, list[i])) return length + 2;
                        nextLayer.Add(list[i]);
                        list.RemoveAt(i);
                    }
                }

                length++;
                layer = nextLayer;
            }

            return 0;
        }

        private bool IsOnlyOneCharDiff(string str1, string str2)
        {
            return str1.Where((c, i) => c != str2[i]).Count() == 1;
        }
    }
}