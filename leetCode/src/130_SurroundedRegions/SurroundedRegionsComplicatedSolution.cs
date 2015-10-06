using System;
using System.Collections.Generic;
using System.Linq;

namespace leetCode._130_SurroundedRegions
{
    public class SurroundedRegionsComplicatedSolution
    {
        private class Coordinate
        {
            internal int X { get; set; }
            internal int Y { get; set; }
            public Coordinate(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        public void Solve(char[,] board)
        {
            if (board.GetLength(0) == 1 || board.GetLength(1) == 1) return;

            var set = new List<HashSet<Coordinate>>();

            for (var i = 0; i < board.GetLength(0); i++)
            {
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i,j] != 'X' && board[i,j] != 'O') throw new Exception("invalid element in board.");
                    if (board[i, j] == 'O')
                    {
                        var currentElementCoordinate = new Coordinate(i, j);
                        var allAdjacentO = GetAllAdjacentO(board, currentElementCoordinate);
                        allAdjacentO.Add(currentElementCoordinate);

                        if (set.Count == 0)
                        {
                            set.Add(allAdjacentO);
                        }
                        else
                        {
                            var hasIntersectRegions = set.Where(s => HasIntersect(s, allAdjacentO)).ToList();
                            if (hasIntersectRegions.Any())
                            {
                                var mergedRegion = new HashSet<Coordinate>();
                                mergedRegion.UnionWith(allAdjacentO);
                                hasIntersectRegions.ForEach(r =>
                                {
                                    mergedRegion.UnionWith(r);
                                    set.Remove(r);
                                });
                                set.Add(mergedRegion);
                            }
                            else
                            {
                                set.Add(allAdjacentO);
                            }
                        }
                    }
                }
            }

            set.ForEach(s =>
            {
                if (s.All(e => !IsElementOnEdgeOfBoard(board, e)))
                {
                    foreach (var coordinate in s)
                    {
                        board[coordinate.X, coordinate.Y] = 'X';
                    }
                }
            });
        }

        private bool HasIntersect(IEnumerable<Coordinate> set1, IEnumerable<Coordinate> set2)
        {
            return set1.Any(coordinateInSet1 => 
                set2.Any(coordinateInSet2 => 
                    coordinateInSet1.X == coordinateInSet2.X && coordinateInSet1.Y == coordinateInSet2.Y)
                );
        }
        private HashSet<Coordinate> GetAllAdjacentO(char[,] board, Coordinate coordinate)
        {
            var hashSet = new HashSet<Coordinate>();

            if (coordinate.X - 1 >= 0 && board[coordinate.X - 1, coordinate.Y] == 'O')
            {
                hashSet.Add(new Coordinate(coordinate.X - 1, coordinate.Y));
            }
            if (coordinate.X + 1 < board.GetLength(0) && board[coordinate.X + 1, coordinate.Y] == 'O')
            {
                hashSet.Add(new Coordinate(coordinate.X + 1, coordinate.Y));
            }
            if (coordinate.Y - 1 >= 0 && board[coordinate.X, coordinate.Y - 1] == 'O')
            {
                hashSet.Add(new Coordinate(coordinate.X, coordinate.Y - 1));
            }
            if (coordinate.Y + 1 < board.GetLength(1) && board[coordinate.X, coordinate.Y + 1] == 'O')
            {
                hashSet.Add(new Coordinate(coordinate.X, coordinate.Y + 1));
            }

            return hashSet;
        }
        private static bool IsElementOnEdgeOfBoard(char[,] board, Coordinate element)
        {
            return element.X == 0 || element.X == board.GetLength(0) - 1 || element.Y == 0 ||
                   element.Y == board.GetLength(1) - 1;
        }
    }
}