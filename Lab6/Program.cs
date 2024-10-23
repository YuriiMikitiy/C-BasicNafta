using System;

namespace Lab6
{
    // Делегат для події
    public delegate void EventDelegate();

    internal class Program
    {
        // Оголошення події
        public static event EventDelegate MyEvent;

        // Метод 1, який підписується на подію
        static void Method1()
        {
            Console.WriteLine("Method1: Подія активована!");
        }

        // Метод 2, який підписується на подію
        static void Method2()
        {
            Console.WriteLine("Method2: Подія активована!");
        }

        // Метод 3, який підписується на подію
        static void Method3()
        {
            Console.WriteLine("Method3: Подія активована!");
        }

        static void Main(string[] args)
        {
            // Підписка методів на подію
            MyEvent += Method1;
            MyEvent += Method2;
            MyEvent += Method3;

            // Активація події
            Console.WriteLine("Активація події MyEvent:");
            MyEvent?.Invoke(); // Перевірка на null перед викликом події
        }
    }
//Створіть подію, на яку підпишіть кілька методів.Продемонструйте, як всі
//підписники реагують на активацію події.
}
