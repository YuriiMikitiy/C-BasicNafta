//Написати функцію, що забезпечує розв’язання квадратного
//рівняння. Параметрами функції повинні бути коефіцієнти і корені
//рівняння. Значення, які обраховує функція, мають передаватися в програму,
//яка викликається з інформацією про наявність коренів рівняння: 2 - два
//різних корені, 1 - корені однакові, рівняння не має розв’язків. Крім того,
//функція повинна перевіряти коректність вихідних даних. якщо вихідні дані
//невірні, то функція повинна повертати - 1.


using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = -3, c = 2;
            //double a = 1, b = -2, c = 1;
            //double a = 1, b = 2, c = 5;


            double root1, root2;

            int result = Foo(a, b, c, out root1, out root2);

            switch (result)
            {
                case 2:
                    Console.WriteLine($"Два різних корені: x1 = {root1}, x2 = {root2}");
                    break;
                case 1:
                    Console.WriteLine($"Корені однакові: x1 = x2 = {root1}");
                    break;
                case 0:
                    Console.WriteLine("Рівняння не має дійсних розв’язків.");
                    break;
                case -1:
                    Console.WriteLine("Некоректні вхідні дані.");
                    break;
            }
        }

        static int Foo(double a, double b, double c, out double root1, out double root2)
        {
            root1 = 0;
            root2 = 0;

            // Перевірка коректності вхідних даних
            if (a == 0)
            {
                return -1; // Якщо a = 0, це не квадратне рівняння
            }

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            // Якщо дискримінант менший за нуль, немає дійсних коренів
            if (discriminant < 0)
            {
                return 0;
            }

            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            // Якщо дискримінант дорівнює нулю, корені однакові
            if (discriminant == 0)
            {
                return 1;
            }

            // Два різних корені
            return 2;
        }
    }
}

