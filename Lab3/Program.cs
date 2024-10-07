//Написати програму, яка вводить по рядках з
//клавіатури двовимірний масив і
//обчислює середнє арифметичне його елементів.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість рядків:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть кількість стовпців:");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows,cols];
        int sum = 0;
        int totalElements = rows * cols;

        // Введення елементів масиву
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Введіть елементи {i + 1}-го рядка через пробіл:");
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < cols; j++)
            {
                array[i, j] = int.Parse(input[j]);
                sum += array[i, j];
            }
        }

        // Обчислення середнього арифметичного
        double average = (double)sum / totalElements;

        Console.WriteLine($"Середнє арифметичне масиву: {average}");
    }
}
