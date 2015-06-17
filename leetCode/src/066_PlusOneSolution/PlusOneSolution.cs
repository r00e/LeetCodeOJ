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

            // in the "digits"
            // if the highest digit is 10, it indicates that all the lower digit are 9, like below:
            // digits: 9 9 9, after it is processed by the code above, it looks like
            // processed digits:  10 0 0
            // initial result:     1 0 0 0
            // This is why we just have to initialize an new array with the 1st element is 1 and all the
            // others are 0,
            // we don't have to copy the digits anymore.

            return result;
        }
    }
}