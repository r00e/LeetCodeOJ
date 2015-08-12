namespace leetCode._048_RotateImageSolution
{
    public class RotateImageSolution
    {
        public void Rotate(int[,] matrix)
        {
            var matrixDimensionIndexLimit = matrix.GetLength(0) - 1;
            for (var circleStartIndex = 0; circleStartIndex < matrix.GetLength(0)/2; circleStartIndex++, matrixDimensionIndexLimit--)
            {
                for (var i = circleStartIndex; i < matrixDimensionIndexLimit; i++)
                {
                    RotateFourNumber(ref matrix[circleStartIndex, i],
                        ref matrix[i, matrixDimensionIndexLimit],
                        ref matrix[matrixDimensionIndexLimit, matrixDimensionIndexLimit - (i - circleStartIndex)],
                        ref matrix[matrixDimensionIndexLimit - (i - circleStartIndex), circleStartIndex]);
                }
            }
        }

        private static void RotateFourNumber(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            var tmp = num1;
            num1 = num4;
            num4 = num3;
            num3 = num2;
            num2 = tmp;
        }
    }
}