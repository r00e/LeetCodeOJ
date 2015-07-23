using System;

namespace leetCode._011_ContainerWithMostWaterSolution
{
    public class ContainerWithMostWaterSolution
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            
            if(height.Length < 2) return maxArea;

            int leftLineIndex = 0, rightLineIndex = height.Length - 1;

            while (leftLineIndex < rightLineIndex)
            {
                maxArea = Math.Max(maxArea,
                    (rightLineIndex - leftLineIndex)*Math.Min(height[leftLineIndex], height[rightLineIndex]));

                if (height[leftLineIndex] < height[rightLineIndex]) leftLineIndex++;
                else rightLineIndex--;
            }

            return maxArea;
        }
    }
}