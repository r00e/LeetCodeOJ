using System;

namespace leetCode._198_HouseRobberSolution
{
    public class HouseRobberSolution2
    {
        public int Rob(int[] nums)
        {
            var notRobPreHouse = 0;
            var robPreHouse = 0;

            foreach (int n in nums)
            {
                var tmp = notRobPreHouse;
                notRobPreHouse = Math.Max(robPreHouse, notRobPreHouse);
                robPreHouse = tmp + n;
            }

            return Math.Max(robPreHouse, notRobPreHouse);
        }
    }
}