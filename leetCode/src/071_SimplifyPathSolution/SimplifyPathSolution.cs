using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetCode._071_SimplifyPathSolution
{
    public class SimplifyPathSolution
    {
        public string SimplifyPath(string path)
        {
            var simplifiedPathList = new List<string>();

            path.Split('/').ToList().ForEach(s =>
            {
                if (string.IsNullOrEmpty(s) || s == ".") return;

                if (s == "..")
                {
                    if (simplifiedPathList.Count > 0) simplifiedPathList.RemoveAt(simplifiedPathList.Count - 1);
                }
                else
                {
                    simplifiedPathList.Add(s);
                }
            });

            var simplifiedPath = new StringBuilder();
            simplifiedPathList.ForEach(s => simplifiedPath.Append("/").Append(s));

            return simplifiedPath.Length == 0 ? "/" : simplifiedPath.ToString();
        }
    }
}