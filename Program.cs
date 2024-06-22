using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSpecifiCrows_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array = new int[3, 3];

            int lowLimitRandom = 1;
            int highLimitRandom = 9;

            int firstColumn = 0;
            int secondLine = 1;

            int multiplication = 1;
            int sum = 0;

            Console.WriteLine("Дан двумерный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(lowLimitRandom, highLimitRandom + 1);
                    Console.Write(array[i, j] + " ");

                    if (i == secondLine)
                    {
                        sum += array[i, j];
                    }

                    if (j == firstColumn)
                    {
                        multiplication *= array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Сумма строки №" + (secondLine + 1) + $" = {sum}.\n" +
                $"Произведение столбца №" + (firstColumn + 1) + $" = {multiplication}");
        }
    }
}
