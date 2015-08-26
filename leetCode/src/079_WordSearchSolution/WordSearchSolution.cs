using System;

namespace leetCode._079_WordSearchSolution
{
    public class WordSearchSolution
    {
        private static char[,] Board { get; set; }

        private static string Word { get; set; }

        private bool Exist(int i, int j, int position)
        {
            if (position == Word.Length) return true;
            if (i < 0 || i >= Board.GetLength(0) || j >= Board.GetLength(1) || j < 0) return false;
            if (Word[position] != Board[i, j]) return false;

            var copy = Board[i, j];
            Board[i, j] = '&';
            var exist = Exist(i, j + 1, position + 1) ||
                        Exist(i, j - 1, position + 1) ||
                        Exist(i + 1, j, position + 1) ||
                        Exist(i - 1, j, position + 1);
            Board[i, j] = copy;
            return exist;
        }

        public bool Exist(char[,] board, string word)
        {
            if (board.Length == 0 || String.IsNullOrEmpty(word)) return false;

            Board = board;
            Word = word;

            for (var i = 0; i < board.GetLength(0); i++)
            {
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    if(Exist(i, j, 0)) return true;
                }
            }

            return false;
        }
    }
}