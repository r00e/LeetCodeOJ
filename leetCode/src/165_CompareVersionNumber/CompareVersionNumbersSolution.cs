namespace leetCode._165_CompareVersionNumber
{
    public class CompareVersionNumbersSolution
    {
        public int CompareVersion(string version1, string version2)
        {
            var subVersions1 = version1.Split('.');
            var subVersions2 = version2.Split('.');

            for (var i = 0; i < subVersions1.Length || i < subVersions2.Length; i++)
            {
                var v1 = i < subVersions1.Length ? int.Parse(subVersions1[i]) : 0;
                var v2 = i < subVersions2.Length ? int.Parse(subVersions2[i]) : 0;

                if (v1 > v2) return 1;
                if (v1 < v2) return -1;
            }

            return 0;
        }
    }
}