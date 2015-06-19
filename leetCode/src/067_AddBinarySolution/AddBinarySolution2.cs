using System.Text;

namespace leetCode._067_AddBinarySolution
{
    public class AddBinarySolution2
    {
        public string AddBinary(string a, string b)
        {
            var carry = '0';
            var result = new StringBuilder();
            var aStr = new StringBuilder(a);
            var bStr = new StringBuilder(b);

            if (aStr.Length < bStr.Length)
            {
                while (aStr.Length < bStr.Length) aStr.Insert(0, '0');
            }
            else
            {
                while (bStr.Length < aStr.Length) bStr.Insert(0, '0');
            }

            var index = aStr.Length - 1;

            while (index >= 0)
            {
                result.Insert(0, GetBitSum(GetBitSum(aStr[index], carry), bStr[index]));
                carry = GetCarry(aStr[index], bStr[index], carry);

                index--;
            }

            return carry == '1' ? result.Insert(0, '1').ToString() : result.ToString();
        }

        private char GetCarry(char c1, char c2, char c3)
        {
            if (c1 == '1' && c2 == '1') return '1';
            if (c1 == '1' && c3 == '1') return '1';
            if (c2 == '1' && c3 == '1') return '1';
            
            return '0';
        }

        private char GetBitSum(char aBit, char bBit)
        {
            return aBit == bBit ? '0' : '1';
        }
    }
}