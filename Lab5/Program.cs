using System;
using System.Linq;

struct TRAIN
{
    public string NAZN; // Назва пункту призначення
    public int NUMR;    // Номер потяга
    public DateTime data; // Час відправлення
}

class Program
{
    static void Main(string[] args)
    {
        // Ініціалізація потягів
        TRAIN[] RASP = new TRAIN[6]
        {
            new TRAIN { NAZN = "Kyiv-Lviv", NUMR = 123, data = DateTime.Now.AddHours(1) },
            new TRAIN { NAZN = "Lviv-Kyiv", NUMR = 456, data = DateTime.Now.AddHours(2) },
            new TRAIN { NAZN = "Kyiv-Lviv", NUMR = 789, data = DateTime.Now.AddHours(3) },
            new TRAIN { NAZN = "Kharkiv-Lviv", NUMR = 101, data = DateTime.Now.AddHours(4) },
            new TRAIN { NAZN = "Dnipro-Kyiv", NUMR = 112, data = DateTime.Now.AddHours(5) },
            new TRAIN { NAZN = "Zaporizhzhia-Kyiv", NUMR = 131, data = DateTime.Now.AddHours(6) }
        };

        // Сортуємо потяга за часом відправлення
        RASP = RASP.OrderBy(train => train.data).ToArray();

        // Встановлюємо пошуковий запис
        Console.WriteLine("Insert Train Destination:");
        string trainword = Console.ReadLine();

        string trainString = string.Empty;
        bool trainFound = false;

        foreach (var train in RASP)
        {
            if (train.NAZN == trainword)
            {
                trainString += ($"Train: {train.NAZN}, Number: {train.NUMR}, Departure Time: {train.data:HH:mm:ss}\n");
                trainFound = true;
            }
        }

        if (trainFound)
        {
            Console.WriteLine(trainString);
        }
        else
        {
            Console.WriteLine("Train not found");
        }
    }
}

            //1.Описати структуру з ім'ям TRAIN, що містить наступні поля: 
            //• NAZN - назва пункту призначення; 
            //• NUMR - номер потяга; 
            //• TIME - час відправлення.
            //2.Написати програму, яка виконує наступні дії;  
            //• введення з клавіатури даних в масив RASP, що складається з шести елементів типу TRAIN; записи повинні бути впорядковані за часом відправлення потяга; 
            //• виведення на екран інформації про потяги, що прямують в пункт, назву якого введено з клавіатури; 
            //• якщо таких потягів немає, вивести відповідне повідомлення.
