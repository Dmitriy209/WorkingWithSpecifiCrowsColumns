using System;

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

            int column = 0;
            int line = 1;

            int multiplication = 1;
            int sum = 0;

            Console.WriteLine("Дан двумерный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(lowLimitRandom, highLimitRandom + 1);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[line, j];
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                multiplication *= array[i, column];
            }

            int lineWriteNumber = line + 1;
            int columnWriteNumber = column + 1;

            Console.WriteLine($"Сумма строки № {lineWriteNumber} = {sum}.\n" +
                $"Произведение столбца №{columnWriteNumber} = {multiplication}");
        }
    }
}
