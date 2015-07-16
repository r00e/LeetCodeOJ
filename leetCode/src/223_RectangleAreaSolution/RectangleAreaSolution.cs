using System;

namespace leetCode._223_RectangleAreaSolution
{
    public class RectangleAreaSolution
    {
        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            var firstRectArea = (C - A)*(D - B);
            var secondRectArea = (G - E)*(H - F);

            var left = Math.Max(A, E);
            var right = Math.Max(Math.Min(C, G), left);
            var bottom = Math.Max(B, F);
            var top = Math.Max(Math.Min(D, H), bottom);

            var overlapArea = (right - left)*(top - bottom);


            return firstRectArea + secondRectArea - overlapArea;
        }
    }
}