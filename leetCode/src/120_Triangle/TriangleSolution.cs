using System;
using System.Collections.Generic;
using System.Linq;

namespace leetCode._120_Triangle
{
    public class TriangleSolution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var results = new List<IList<int>>
            {
                new List<int>
                {
                    triangle.First().First()
                }
            };

            for (var triangleRow = 1; triangleRow < triangle.Count; triangleRow++)
            {
                var result = new List<int>();

                for (var triangleColumn = 0; triangleColumn <= triangleRow; triangleColumn++)
                {
                    if (triangleColumn == 0 || triangleColumn == triangleRow)
                    {
                        result.Add(results[triangleRow - 1][triangleColumn == 0 ? 0 : triangleColumn - 1]
                                   + triangle[triangleRow][triangleColumn]);
                    }
                    else
                    {
                        result.Add(
                            Math.Min(results[triangleRow - 1][triangleColumn - 1],
                                results[triangleRow - 1][triangleColumn]) + triangle[triangleRow][triangleColumn]);
                    }
                }

                results.Add(result);
            }

            return results.Last().Min();
        }
    }
}