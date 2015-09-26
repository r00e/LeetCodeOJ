using System;
using System.Collections.Generic;
using System.Linq;

namespace leetCode._127_WordLadder
{
    public class WordLadderAnotherSolution
    {
        public int LadderLength(string beginWord, string endWord, ISet<string> wordList)
        {
            if (wordList.Count == 0) return 0;
            if (beginWord == endWord) return 0;

            var length = 1;
            var visited = new HashSet<string>();
            var layers = new Queue<string>();
            layers.Enqueue(beginWord);
            layers.Enqueue(null);

            while (layers.Count != 0)
            {
                var word = layers.Dequeue();
                if (word == null)
                {
                    length++;

                    if (layers.Count != 0)
                    {
                        layers.Enqueue(null);
                    }
                }
                else
                {
                    var charArray = word.ToArray();

                    for (var i = 0; i < charArray.Length; i++)
                    {
                        for (var alphabet = 'a'; alphabet >= 'a' && alphabet <= 'z'; alphabet++)
                        {
                            charArray[i] = alphabet;

                            var newWord = new String(charArray);

                            if (newWord == endWord)
                            {
                                if (length > 1 || (length == 1 && wordList.Contains(newWord)))
                                {
                                    return length + 1;
                                }
                            }
                            if (wordList.Contains(newWord) && !visited.Contains(newWord))
                            {
                                layers.Enqueue(newWord);
                                visited.Add(newWord);
                            }
                        }

                        charArray = word.ToArray();
                    }
                }
            }

            return 0;
        }
    }
}