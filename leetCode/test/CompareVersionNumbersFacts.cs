using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class CompareVersionNumbersFacts
    {
        private readonly CompareVersionNumbersSolution solution = new CompareVersionNumbersSolution();

        [Fact]
        public void should_return_1_when_compare_1_and_0()
        {
            solution.CompareVersion("1", "0").ShouldBe(1);
        }

        [Fact]
        public void should_return_minus_1_when_compare_0_and_1()
        {
            solution.CompareVersion("0", "1").ShouldBe(-1);
        }

        [Fact]
        public void should_return_0_when_compare_0_and_0()
        {
            solution.CompareVersion("0", "0").ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_compare_0p1_and_0()
        {
            solution.CompareVersion("0.1", "0").ShouldBe(1);
        }

        [Fact]
        public void should_return_minus_1_when_compare_0p1_and_1()
        {
            solution.CompareVersion("0.1", "1").ShouldBe(-1);
        }

        [Fact]
        public void should_return_0_when_compare_01_and_1()
        {
            solution.CompareVersion("01", "1").ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_compare_0p1p1_and_0p1()
        {
            solution.CompareVersion("0.1.1", "0.1").ShouldBe(1);
        }

        [Fact]
        public void should_return_minus_1_when_compare_0p1p1_and_0p13()
        {
            solution.CompareVersion("0.1.1", "0.13").ShouldBe(-1);
        }

        [Fact]
        public void should_return_0_when_compare_1p0_and_1()
        {
            solution.CompareVersion("1.0", "1").ShouldBe(0);
        }
    }

    internal class CompareVersionNumbersSolution
    {
        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');

            for (int i = 0, j = 0; i < v1.Length && j < v2.Length; i++, j++)
            {
                if (int.Parse(v1[i]) > int.Parse(v2[j])) return 1;
                if (int.Parse(v1[i]) < int.Parse(v2[j])) return -1;
                if (i + 1 == v1.Length && j + 1 == v2.Length) return 0;
                if (i + 1 == v1.Length)
                {
                    while (++j < v2.Length)
                    {
                        if (int.Parse(v2[j]) != 0) return -1;
                    }
                    return 0;
                }
                if (j + 1 == v2.Length)
                {
                    while (++i < v1.Length)
                    {
                        if (int.Parse(v1[i]) != 0) return 1;
                    }
                    return 0;
                }
            }

            return 0;
        }
    }
}