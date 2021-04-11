using System;

namespace Lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            string emptyStr = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    emptyStr += " ";
                    Console.WriteLine($"{emptyStr}{array[i, j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
