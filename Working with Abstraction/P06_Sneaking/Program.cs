using System;

namespace P06_Sneaking
{
    class Sneaking
    {
        static char[][] room;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            room = new char[n][];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine()
                    .ToCharArray();
                room[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];
                }
            }

            var moves = Console.ReadLine()
                .ToCharArray();

            int samRow = -1;
            int samCol = -1;

            FindSam(ref samRow, ref samCol);

            for (int i = 0; i < moves.Length; i++)
            {
                MoveEnemies();

                int enemyRow = 0;
                int enemyCol = 0;
                DesignateEnemyPosition(samRow, ref enemyRow, ref enemyCol);

                if (enemyRow == samRow)
                {
                    if (samCol < enemyCol && room[enemyRow][enemyCol] == 'd')
                    {
                        room[samRow][samCol] = 'X';
                        Console.WriteLine($"Sam died at {samRow}, {samCol}");
                        PrintRoom();
                        Environment.Exit(0);
                    }
                    else if (samCol > enemyCol && room[enemyRow][enemyCol] == 'b')
                    {
                        room[samRow][samCol] = 'X';
                        Console.WriteLine($"Sam died at {samRow}, {samCol}");
                        PrintRoom();
                        Environment.Exit(0);
                    }
                }

                char command = moves[i];
                MoveSam(ref samRow, ref samCol, command);
                DesignateEnemyPosition(samRow, ref enemyRow, ref enemyCol);

                if (room[enemyRow][enemyCol] == 'N' && samRow == enemyRow)
                {
                    room[enemyRow][enemyCol] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    PrintRoom();
                    Environment.Exit(0);
                }
            }
        }

        private static void MoveEnemies()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (col + 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (col - 1 >= 0)
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
        }

        private static void FindSam(ref int samRow, ref int samCol)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        samRow = row;
                        samCol = col;
                    }
                }
            }
        }

        private static void DesignateEnemyPosition(int samRow, ref int enemyRow, ref int enemyCol)
        {
            for (int j = 0; j < room[samRow].Length; j++)
            {
                if (room[samRow][j] != '.' && room[samRow][j] != 'S')
                {
                    enemyRow = samRow;
                    enemyCol = j;
                }
            }
        }

        private static void MoveSam(ref int samRow, ref int samCol, char command)
        {
            room[samRow][samCol] = '.';
            switch (command)
            {
                case 'U':
                    samRow--;
                    break;
                case 'D':
                    samRow++;
                    break;
                case 'L':
                    samCol--;
                    break;
                case 'R':
                    samCol++;
                    break;
                default:
                    break;
            }
            room[samRow][samCol] = 'S';
        }

        private static void PrintRoom()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
