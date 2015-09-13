using leetCode.Common;
using leetCode._093_RestoreIPAddressesSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RestoreIPAddressesFacts
    {
        private readonly RestoreIPAddressesSolution solution = new RestoreIPAddressesSolution();
            
        [Fact]
        public void should_return_empty_for_empty()
        {
            var result = solution.RestoreIPAddresses(string.Empty);
            CommonMethod.VerifyListStringResult(result, "[]");
        }
            
        [Fact]
        public void should_return_empty_for_1()
        {
            var result = solution.RestoreIPAddresses("1");
            CommonMethod.VerifyListStringResult(result, "[]");
        }
            
        [Fact]
        public void should_return_result_for_0000()
        {
            var result = solution.RestoreIPAddresses("0000");
            CommonMethod.VerifyListStringResult(result, "['0.0.0.0']");
        }
            
        [Fact]
        public void should_return_result_for_0001()
        {
            var result = solution.RestoreIPAddresses("0001");
            CommonMethod.VerifyListStringResult(result, "['0.0.0.1']");
        }
            
        [Fact]
        public void should_return_result_for_00010()
        {
            var result = solution.RestoreIPAddresses("00010");
            CommonMethod.VerifyListStringResult(result, "['0.0.0.10']");
        }
            
        [Fact]
        public void should_return_result_for_00110()
        {
            var result = solution.RestoreIPAddresses("00110");
            CommonMethod.VerifyListStringResult(result, "['0.0.1.10', '0.0.11.0']");
        }
            
        [Fact]
        public void should_return_result_for_30000110()
        {
            var result = solution.RestoreIPAddresses("30000110");
            CommonMethod.VerifyListStringResult(result, "[]");
        }

        [Fact]
        public void should_return_result_for_25500110()
        {
            var result = solution.RestoreIPAddresses("25500110");
            CommonMethod.VerifyListStringResult(result, "['25.50.0.110', '255.0.0.110']");
        }

        [Fact]
        public void should_return_result_for_0279245587303()
        {
            var result = solution.RestoreIPAddresses("0279245587303");
            CommonMethod.VerifyListStringResult(result, "[]");
        }
    }
}