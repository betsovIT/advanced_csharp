using System;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string tokens = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = tokens[j];
                }
            }
            int maxKnightCollisions = 0;
            int linchpinKnightRow = -1;
            int linchpinKnightColl = -1;

            int removedKnights = 0;

            while (true)
            {
                maxKnightCollisions = 0;
                linchpinKnightRow = -1;
                linchpinKnightColl = -1;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == 'K')
                        {
                            int knightCollisions = 0;
                            if (ValidCoordinates(i - 2, j - 1, board) && board[i - 2, j - 1] == 'K')
                            {
                                knightCollisions++;
                            }
                            if (ValidCoordinates(i - 2, j + 1, board) && board[i - 2, j + 1] == 'K')
                            {
                                knightCollisions++;
                            }
                            if (ValidCoordinates(i - 1, j - 2, board) && board[i - 1, j - 2] == 'K')
                            {
                                knightCollisions++;
                            }
                            if (ValidCoordinates(i - 1, j + 2, board) && board[i - 1, j + 2] == 'K')
                            {
                                knightCollisions++;
                            }
                            if (ValidCoordinates(i + 1, j - 2, board) && board[i + 1, j - 2] == 'K')
                            {
                                knightCollisions++;
                            }
                            if (ValidCoordinates(i + 1, j + 2, board) && board[i + 1, j + 2] == 'K')
                            {
                                knightCollisions++;
                            }
                            if (ValidCoordinates(i + 2, j - 1, board) && board[i + 2, j - 1] == 'K')
                            {
                                knightCollisions++;
                            }
                            if (ValidCoordinates(i + 2, j + 1, board) && board[i + 2, j + 1] == 'K')
                            {
                                knightCollisions++;
                            }

                            if (knightCollisions > maxKnightCollisions)
                            {
                                maxKnightCollisions = knightCollisions;
                                linchpinKnightRow = i;
                                linchpinKnightColl = j;
                            }
                        }
                    }
                }

                if (maxKnightCollisions == 0)
                {
                    break;
                }
                else
                {
                    board[linchpinKnightRow, linchpinKnightColl] = '0';
                    removedKnights++;
                }

            }

            Console.WriteLine(removedKnights);

            //Console.WriteLine(maxKnightCollisions);
            //Console.WriteLine(linchpinKnightRow);
            //Console.WriteLine(linchpinKnightColl);
            //Console.WriteLine();
            //Console.WriteLine();
            //PrintMatrix(board);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        static bool ValidCoordinates(int row, int coll, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && coll >= 0 && coll < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
