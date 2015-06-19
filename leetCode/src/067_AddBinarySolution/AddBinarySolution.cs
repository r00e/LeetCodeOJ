using System.Text;

namespace leetCode._067_AddBinarySolution
{
    public class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            var carry = '0';
            var result = new StringBuilder();
            if (a.Length > b.Length)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
            var aIndex = a.Length - 1;
            var bIndex = b.Length - 1;

            while (bIndex >= 0)
            {
                if (aIndex >= 0)
                {
                    result.Insert(0, GetBitSum(GetBitSum(a[aIndex], carry), b[bIndex]));
                    carry = GetCarry(a[aIndex], b[bIndex], carry);
                }
                else
                {
                    result.Insert(0, GetBitSum(GetBitSum('0', carry), b[bIndex]));
                    carry = GetCarry('0', b[bIndex], carry);
                }
                
                aIndex--;
                bIndex--;
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