//Напишіть програму, яка запитує у користувача номер місяця і
//потім виводить відповідну назву часуроку. У разі, якщо користувач введе
//неприпустиме число, програма повинна вивести повідомлення "Помилка
//введенняданих ". Нижче наведено рекомендований вигляд екрану під
//часроботи програми.
//Введіть номер місяця
//->11
//зима

using System;

class Program
{
    static void Main()
    {
        byte nam = 0;
        Console.WriteLine("Введіть номер місяця");
        try
        {
            Console.Write("->");
            nam = Convert.ToByte(Console.ReadLine());

            if (nam==12 || nam==1 || nam==2)
            {
                Console.WriteLine("Зима");
            }
            else if (nam >= 3 && nam <= 5)
            {
                Console.WriteLine("Весна");
            }
            else if (nam >= 6 && nam <= 8)
            {
                Console.WriteLine("Літо");
            }
            else if (nam >= 9 && nam <= 11)
            {
                Console.WriteLine("Осінь");
            }
            else
                Console.WriteLine("Помилка введення даних");
        }
        catch (FormatException)
        {
            Console.WriteLine("Невірний формат. Введіть число.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Число повинно бути між 0 і 255.");
        }
    }
}
