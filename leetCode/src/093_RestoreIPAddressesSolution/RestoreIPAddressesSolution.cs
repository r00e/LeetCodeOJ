using System.Collections.Generic;
using System.Text;

namespace leetCode._093_RestoreIPAddressesSolution
{
    public class RestoreIPAddressesSolution
    {
        public IList<string> RestoreIPAddresses(string s)
        {
            var ipAddresses = new List<string>();

            GenerateIPAddresses(s, new StringBuilder(), ipAddresses, 0, 0);

            return ipAddresses;
        }

        private static void GenerateIPAddresses(
            string str, 
            StringBuilder ipAddress, 
            List<string> ipAddresses, 
            int dotCount, int start)
        {
            var ipAddressCopy = new StringBuilder();
            ipAddressCopy.Append(ipAddress);
            if (dotCount == 3)
            {
                var lastPart = str.Substring(start);
                if (!IsValid(lastPart)) return;

                ipAddressCopy.Append(lastPart);
                ipAddresses.Add(ipAddressCopy.ToString());
                return;
            }

            for (var partLength = 1; partLength <= 3; partLength++)
            {
                if (start + partLength > str.Length) return;

                var part = str.Substring(start, partLength);
                if (!IsValid(part)) return;

                ipAddressCopy.AppendFormat("{0}{1}", part, '.');
                GenerateIPAddresses(str, ipAddressCopy, ipAddresses, dotCount + 1, start + partLength);
                ipAddressCopy.Remove(ipAddressCopy.Length - partLength - 1, partLength + 1);
            }
        }

        private static bool IsValid(string lastPart)
        {
            if (lastPart == string.Empty || 
                lastPart.Length > 3 || 
                (lastPart.Length > 1 && lastPart.StartsWith("0")) ||
                int.Parse(lastPart) > 255) return false;
            return true;
        }
    }
}