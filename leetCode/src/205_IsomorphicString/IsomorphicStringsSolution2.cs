namespace leetCode._205_IsomorphicString
{
    public class IsomorphicStringsSolution2
    {
        public bool IsIsomorphic(string s, string t)
        {
            var charPositionForS = new int[256];
            var charPositionForT = new int[256];

            for (var i = 0; i < s.Length; i++)
            {
                if(charPositionForS[s[i]] != charPositionForT[t[i]]) return false;
                charPositionForS[s[i]] = i + 1;
                charPositionForT[t[i]] = i + 1;
            }

            return true;
        }
    }
}