using System;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    field[i, j] = input[j];
                }
            }

            int firstPlayerRow = -1;
            int firstPlayerCol = -1;

            int secondPlayerRow = -1;
            int secondPlayerCol = -1;


            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 'f')
                    {
                        firstPlayerRow = i;
                        firstPlayerCol = j;
                    }

                    if (field[i, j] == 's')
                    {
                        secondPlayerRow = i;
                        secondPlayerCol = j;
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                string movementOfFirst = input.Split()[0];
                string movementOfSecond = input.Split()[1];

                //First player movement

                if (movementOfFirst == "left")
                {
                    if (IsValidCoordinate(firstPlayerRow , firstPlayerCol - 1, size))
                    {
                        firstPlayerCol -= 1;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        firstPlayerCol = size - 1;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }

                }
                else if (movementOfFirst == "right")
                {
                    if (IsValidCoordinate(firstPlayerRow, firstPlayerCol + 1, size))
                    {
                        firstPlayerCol += 1;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        firstPlayerCol = 0;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                }
                else if (movementOfFirst == "up")
                {
                    if (IsValidCoordinate(firstPlayerRow - 1, firstPlayerCol , size))
                    {
                        firstPlayerRow -= 1;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        firstPlayerRow = size - 1;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                }
                else if (movementOfFirst == "down")
                {
                    if (IsValidCoordinate(firstPlayerRow + 1, firstPlayerCol, size))
                    {
                        firstPlayerRow += 1;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        firstPlayerRow = 0;

                        if (IsFree(firstPlayerRow, firstPlayerCol, field))
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'f';
                        }
                        else
                        {
                            field[firstPlayerRow, firstPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                }

                //Second player movement
                if (movementOfSecond == "left")
                {
                    if (IsValidCoordinate(secondPlayerRow, secondPlayerCol - 1, size))
                    {
                        secondPlayerCol -= 1;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        secondPlayerCol = size - 1;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }

                }
                else if (movementOfSecond == "right")
                {
                    if (IsValidCoordinate(secondPlayerRow, secondPlayerCol + 1, size))
                    {
                        secondPlayerCol += 1;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        secondPlayerCol = 0;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                }
                else if (movementOfSecond == "up")
                {
                    if (IsValidCoordinate(secondPlayerRow - 1, secondPlayerCol, size))
                    {
                        secondPlayerRow -= 1;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        secondPlayerRow = size - 1;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                }
                else if (movementOfSecond == "down")
                {
                    if (IsValidCoordinate(secondPlayerRow + 1, secondPlayerCol, size))
                    {
                        secondPlayerRow += 1;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                    else
                    {
                        secondPlayerRow = 0;

                        if (IsFree(secondPlayerRow, secondPlayerCol, field))
                        {
                            field[secondPlayerRow, secondPlayerCol] = 's';
                        }
                        else
                        {
                            field[secondPlayerRow, secondPlayerCol] = 'x';
                            PrintField(field);
                            break;
                        }
                    }
                }

            }
        }

        public static bool IsValidCoordinate(int row, int col, int size)
        {
            if (row < 0 || row >= size)
            {
                return false;
            }

            if (col < 0 || col >= size)
            {
                return false;
            }

            return true;
        }

        public static bool IsFree(int row, int col, char[,] field)
        {
            if (field[row, col] != '*')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void PrintField(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
