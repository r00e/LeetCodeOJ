using leetCode._130_SurroundedRegions;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SurroundedRegionsFacts
    {
//        private readonly SurroundedRegionsComplicatedSolution solution = new SurroundedRegionsComplicatedSolution();
        private readonly SurroundedRegionsSolution solution = new SurroundedRegionsSolution();

        [Fact]
        public void should_do_nothing_for_1x1_X_board()
        {
            var board = new[,] {{'X'}};
            solution.Solve(board);
            board.ShouldBe(new[,] {{'X'}});
        }

        [Fact]
        public void should_do_nothing_for_1x1_O_board()
        {
            var board = new[,] {{'O'}};
            solution.Solve(board);
            board.ShouldBe(new[,] {{'O'}});
        }

        [Fact]
        public void should_do_nothing_for_2x2_board()
        {
            // O X
            // X X
            var board = new[,] {{'O', 'X'}, {'X', 'X'}};
            solution.Solve(board);
            board.ShouldBe(new[,] { { 'O', 'X' }, { 'X', 'X' } });
        }

        [Fact]
        public void should_do_nothing_for_O_at_the_edge_on_3x3_board_OXX_XXX_XXX()
        {
            // O X X
            // X X X
            // X X X
            var board = new[,] {{'O', 'X', 'X'}, {'X', 'X', 'X'}, {'X', 'X', 'X'}};
            solution.Solve(board);
            board.ShouldBe(new[,] {{'O', 'X', 'X'}, {'X', 'X', 'X'}, {'X', 'X', 'X'}});
        }

        [Fact]
        public void should_fill_surrounded_O_region_by_X_for_3x3_board_OXX_XOX_XXX()
        {
            // O X X
            // X O X
            // X X X
            var board = new[,] {{'O', 'X', 'X'}, {'X', 'O', 'X'}, {'X', 'X', 'X'}};
            solution.Solve(board);
            board.ShouldBe(new[,] {{'O', 'X', 'X'}, {'X', 'X', 'X'}, {'X', 'X', 'X'}});
        }

        [Fact]
        public void should_NOT_fill_unsurrounded_O_region_by_X_for_3x3_board_OXX_XOO_XXX()
        {
            // O X X
            // X O O
            // X X X
            var board = new[,] {{'O', 'X', 'X'}, {'X', 'O', 'O'}, {'X', 'X', 'X'}};
            solution.Solve(board);
            board.ShouldBe(new[,] {{'O', 'X', 'X'}, {'X', 'O', 'O'}, {'X', 'X', 'X'}});
        }

        [Fact]
        public void should_fill_surrounded_O_region_by_X_for_4x4_board_OXXX_XOOX_XXOX_XXXX()
        {
            // O X X X
            // X O O X
            // X X O X
            // X X X X
            var board = new[,]
            {
                {'O', 'X', 'X', 'X'}, 
                {'X', 'O', 'O', 'X'}, 
                {'X', 'X', 'O', 'X'}, 
                {'X', 'X', 'X', 'X'}
            };
            solution.Solve(board);
            board.ShouldBe(new[,]
            {
                { 'O', 'X', 'X', 'X' }, 
                { 'X', 'X', 'X', 'X' }, 
                { 'X', 'X', 'X', 'X' }, 
                { 'X', 'X', 'X', 'X' }
            });
        }

        [Fact]
        public void should_fill_surrounded_O_region_by_X_for_4x4_board_OXOX_XXOX_XXXX_XXXX()
        {
            // O X O X
            // X O O X
            // X X O X
            // X X X X
            var board = new[,]
            {
                {'O', 'X', 'O', 'X'}, 
                {'X', 'O', 'O', 'X'}, 
                {'X', 'X', 'O', 'X'}, 
                {'X', 'X', 'X', 'X'}
            };
            solution.Solve(board);
            board.ShouldBe(new[,]
            {
                {'O', 'X', 'O', 'X'},
                {'X', 'O', 'O', 'X'},
                {'X', 'X', 'O', 'X'},
                {'X', 'X', 'X', 'X'}
            });
        }

        [Fact]
        public void should_fill_surrounded_O_region_by_X_for_3x5_board_XXXOX_XOOOX_XXXXX()
        {
            // X X X O X
            // X O O O X
            // X X X X X
            var board = new[,]
            {
                {'X', 'X', 'X', 'O', 'X'}, 
                {'X', 'O', 'O', 'O', 'X'}, 
                {'X', 'X', 'X', 'X', 'X'}
            };
            solution.Solve(board);
            board.ShouldBe(new[,]
            {
                {'X', 'X', 'X', 'O', 'X'},
                {'X', 'O', 'O', 'O', 'X'},
                {'X', 'X', 'X', 'X', 'X'}
            });
        }
    }
}