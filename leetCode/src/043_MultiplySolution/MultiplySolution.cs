using System.Linq;
using System.Text;

namespace leetCode._043_MultiplySolution
{
    public class MultiplySolution
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            var result = new int[num1.Length + num2.Length];
            for (var i = num2.Length - 1; i >= 0; i--)
            {
                for (var j = num1.Length - 1; j >= 0; j--)
                {
                    result[i + j + 1] += (num1[j] - '0') * (num2[i] - '0');
                }
            }

            for (var i = result.Length - 1; i > 0; i--)
            {
                result[i - 1] = result[i - 1] + result[i]/10;
                result[i] =  result[i]%10;
            }

            var resultString = new StringBuilder();
            result.ToList().ForEach(n => resultString.Append(n));
            if (resultString[0] == '0') resultString.Remove(0, 1);
            return resultString.ToString();
        }
    }
}