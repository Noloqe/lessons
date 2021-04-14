using System;

namespace Lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array =
            {
                {'X','O','O','X','O','O','O','O','X','X' },
                {'X','O','O','X','O','O','O','O','O','O' },
                {'X','O','O','X','O','X','X','X','O','O' },
                {'O','O','O','X','O','O','O','O','O','O' },
                {'O','O','O','O','O','O','O','O','X','X' },
                {'X','O','X','X','O','O','O','O','O','O' },
                {'O','O','O','O','O','O','O','O','O','O' },
                {'O','O','X','O','O','O','O','X','O','O' },
                {'O','O','O','O','O','O','O','O','O','O' },
                {'O','X','O','O','O','O','O','O','O','O' },
            };
            Console.WriteLine("Морской бой: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
