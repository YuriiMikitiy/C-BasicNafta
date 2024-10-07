using System;

class Program
{
    static void Main()
    {
        // Введення значень
        Console.Write("Введіть довжину катета: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину гіпотенузи: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Перевірка чи гіпотенуза більше катета
        if (c <= a)
        {
            Console.WriteLine("Помилка: гіпотенуза має бути більшою за катет.");
            return;
        }

        // Обчислення другого катета
        double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));

        // Обчислення площі трикутника
        double area = 0.5 * a * b;

        // Виведення результатів
        Console.WriteLine($"Довжина другого катета: {b:F2}");
        Console.WriteLine($"Площа трикутника: {area:F2}");
    }
}
