using System.Collections.Generic;
using System.Runtime.InteropServices;
using leetCode._054_SpiralOrderSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SpiralMatrixFacts
    {
        private readonly SpiralMatrixSolution solution = new SpiralMatrixSolution();

        [Fact]
        public void should_return_empty_for_empty()
        {
            solution.SpiralOrder(new int[,]{}).ShouldBe(new List<int>());
        }

        [Fact]
        public void should_return_0_for_0()
        {
            solution.SpiralOrder(new int[,] {{0}}).ShouldBe(new List<int> {0});
        }

        [Fact]
        public void should_return_01_for_1x2_matrix_01()
        {
            solution.SpiralOrder(new int[1, 2] {{0, 1}}).ShouldBe(new List<int> {0, 1});
        }

        [Fact]
        public void should_return_012_for_3x1_matrix_012()
        {
            solution.SpiralOrder(new int[3, 1] {{0}, {1}, {2}}).ShouldBe(new List<int> {0, 1, 2});
        }

        [Fact]
        public void should_return_01_for_2x1_matrix_01()
        {
            solution.SpiralOrder(new int[2, 1] {{0}, {1}}).ShouldBe(new List<int> {0, 1});
        }

        [Fact]
        public void should_return_0132_for_2x2_matrix_0123()
        {
            solution.SpiralOrder(new int[2, 2] {{0, 1}, {2, 3}}).ShouldBe(new List<int> {0, 1, 3, 2});
        }

        [Fact]
        public void should_return_01357642_for_4x2_matrix_01234567()
        {
            solution.SpiralOrder(new int[4, 2]
            {
                {0, 1},
                {2, 3},
                {4, 5},
                {6, 7}
            })
            .ShouldBe(new List<int> {0, 1, 3, 5, 7, 6, 4, 2});
        }

        [Fact]
        public void should_return_result_for_4x3_matrix()
        {
            solution.SpiralOrder(new int[4, 3]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8},
                {9, 10, 11}
            })
            .ShouldBe(new List<int> {0, 1, 2, 5, 8, 11, 10, 9, 6, 3, 4, 7});
        }

        [Fact]
        public void should_return_result_for_4x4_matrix()
        {
            solution.SpiralOrder(new int[4, 4]
            {
                {0,  1,  2,  3},
                {4,  5,  6,  7},
                {8,  9,  10, 11},
                {12, 13, 14, 15}
            })
            .ShouldBe(new List<int> {0, 1, 2, 3, 7, 11, 15, 14, 13, 12, 8, 4, 5, 6, 10, 9});
        }
    }
}