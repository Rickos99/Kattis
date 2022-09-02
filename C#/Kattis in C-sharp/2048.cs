using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/2048
    class _2048
    {

        //public static void Main() => Solution();

        public static void Solution()
        {
            // Initialize
            var table = GetTable();
            var direction = GetDirection();

            // Execute
            table = MoveTable(table, direction);

            // Print result
            PrintTable(table);
        }

        static int[,] GetTable()
        {
            var table = new int[4, 4];
            for (int row = 0; row < 4; row++)
            {
                var rowInput = Console.ReadLine().Split(' ');
                for (int col = 0; col < 4; col++)
                {
                    table[row, col] = int.Parse(rowInput[col]);
                }
            }
            return table;
        }

        static int GetDirection()
        {
            string direction = Console.ReadLine();
            return int.Parse(direction);
        }

        static int[,] MoveTable(int[,] table, int direction)
        {
            switch (direction)
            {
                case 0:
                    return MoveTableLeft(table);
                case 1:
                    return MoveTableUp(table);
                case 2:
                    return MoveTableRight(table);
                case 3:
                    return MoveTableDown(table);
                default:
                    throw new NotSupportedException("Unsupported direction.");
            }
        }

        static int[,] MoveTableLeft(int[,] table)
        {
            for (int i = 0; i < 4; i++)
            {
                var location = -1;
                var counter = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (table[i, j] == 0)
                    {
                        counter++;
                        if (counter == 1) location = j;
                    }
                    else if (table[i, j] != 0 && location != -1)
                    {
                        table[i, location] = table[i, j];
                        table[i, j] = 0;
                        location = j;
                        counter = 0;
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    if (table[i, j] != 0 && table[i, j] == table[i, j + 1])
                    {
                        table[i, j] = table[i, j] * 2;
                        for (int k = j + 1; k < 3; k++)
                        {
                            table[i, k] = table[i, k + 1];
                        }
                        table[i, 3] = 0;
                    }
                }
            }
            return table;
        }

        static int[,] MoveTableUp(int[,] table)
        {
            for (int j = 0; j < 4; j++)
            {
                int location = -1, counter = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (table[i, j] == 0)
                    {
                        counter++;
                        if (counter == 1) location = i;
                    }
                    else if (table[i, j] != 0 && location != -1)
                    {
                        table[location, j] = table[i, j];
                        table[i, j] = 0;
                        location = i;
                        counter = 0;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    if (table[i, j] != 0 && table[i, j] == table[i + 1, j])
                    {
                        table[i, j] = table[i, j] * 2;
                        for (int k = i + 1; k < 3; k++)
                        {
                            table[k, j] = table[k + 1, j];
                        }
                        table[3, j] = 0;
                    }
                }

            }
            return table;
        }

        static int[,] MoveTableRight(int[,] table)
        {
            for (int i = 0; i < 4; i++)
            {
                int location = -1, counter = 0;
                for (int j = 3; j > -1; j--)
                {
                    if (table[i, j] == 0)
                    {
                        counter++;
                        if (counter == 1) location = j;
                    }
                    else if (table[i, j] != 0 && location != -1)
                    {
                        table[i, location] = table[i, j];
                        table[i, j] = 0;
                        location = j;
                        counter = 0;
                    }
                }

                for (int j = 3; j > 0; j--)
                {
                    if (table[i, j] != 0 && table[i, j] == table[i, j - 1])
                    {
                        table[i, j] = table[i, j] * 2;
                        for (int k = j - 1; k > 0; k--)
                        {
                            table[i, k] = table[i, k - 1];
                        }
                        table[i, 0] = 0;
                    }
                }

            }
            return table;
        }

        static int[,] MoveTableDown(int[,] table)
        {
            for (int j = 0; j < 4; j++)
            {
                int location = -1, counter = 0;
                for (int i = 3; i > -1; i--)
                {
                    if (table[i, j] == 0)
                    {
                        counter++;
                        if (counter == 1) location = i;
                    }
                    else if (table[i, j] != 0 && location != -1)
                    {
                        table[location, j] = table[i, j];
                        table[i, j] = 0;
                        location = i;
                        counter = 0;
                    }
                }

                for (int i = 3; i > 0; i--)
                {
                    if (table[i, j] != 0 && table[i, j] == table[i - 1, j])
                    {
                        table[i, j] = table[i, j] * 2;
                        for (int k = i - 1; k > 0; k--)
                        {
                            table[k, j] = table[k - 1, j];
                        }
                        table[0, j] = 0;
                    }
                }

            }
            return table;
        }

        static void PrintTable(int[,] table)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{table[i, 0]} {table[i, 1]} {table[i, 2]} {table[i, 3]}");
            }
        }
    }
}
