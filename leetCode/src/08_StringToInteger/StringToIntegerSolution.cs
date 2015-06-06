namespace leetCode._08_StringToInteger
{
    public class StringToIntegerSolution
    {
        public int MyAtoi(string str)
        {
            long result = 0;
            var flag = 0;

            str = str.Trim();

            if (str.Length == 0) return 0;
            else if (str[0] == '+') { flag = 1; str = str.Substring(1); }
            else if (str[0] == '-') { flag = -1; str = str.Substring(1); }
            else if (str[0] >= '0' && str[0] <= '9') flag = 1;
            else return 0;

            foreach (char t in str)
            {
                if (t >= '0' && t <= '9')
                {
                    result = t - '0' + result * 10;
                    if (flag * result > int.MaxValue) return int.MaxValue;
                    else if (flag * result < int.MinValue) return int.MinValue;
                }
                else break;
            }

            return (int)result * flag;
        }
    }
}