namespace leetCode._066_PlusOneSolution
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            var currentDigitIndex = digits.Length - 1;
            digits[currentDigitIndex] += 1;

            while (digits[currentDigitIndex] == 10 && currentDigitIndex > 0)
            {
                digits[currentDigitIndex] = 0;
                digits[currentDigitIndex - 1] += 1;
                currentDigitIndex--;
            }

            return digits[0] == 10 ? GenerateResult(digits) : digits;
        }

        private static int[] GenerateResult(int[] digits)
        {
            var result = new int[digits.Length + 1];
            result[0] = 1;

            for (var j = 1; j < digits.Length; j++)
            {
                result[j] = digits[j];
            }

            return result;
        }
    }
}