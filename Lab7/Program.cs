using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {

        // Створюємо спільний ресурс і об'єкт блокування
        private static List<int> sharedResource = new List<int>();
        private static ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();
        static void Main()
        {
            // Створюємо кілька завдань читачів та письменників
            var readerTasks = new Task[5];
            var writerTasks = new Task[2];

            // Ініціалізація задач читачів
            for (int i = 0; i < readerTasks.Length; i++)
            {
                readerTasks[i] = Task.Run(() => Reader(i));
            }

            // Ініціалізація задач письменників
            for (int i = 0; i < writerTasks.Length; i++)
            {
                writerTasks[i] = Task.Run(() => Writer(i));
            }

            // Чекаємо завершення всіх завдань
            Task.WaitAll(readerTasks);
            Task.WaitAll(writerTasks);
        }

        // Метод читача
        static void Reader(int readerId)
        {
            for (int i = 0; i < 3; i++)
            {
                rwLock.EnterReadLock();
                try
                {
                    Console.WriteLine($"Читач {readerId} читає ресурс: [{string.Join(", ", sharedResource)}]");
                }
                finally
                {
                    rwLock.ExitReadLock();
                }
                Thread.Sleep(500); // Імітуємо час читання
            }
        }

        // Метод письменника
        static void Writer(int writerId)
        {
            var random = new Random();
            for (int i = 0; i < 3; i++)
            {
                rwLock.EnterWriteLock();
                try
                {
                    int value = random.Next(100);
                    sharedResource.Add(value);
                    Console.WriteLine($"Письменник {writerId} додає значення: {value}");
                }
                finally
                {
                    rwLock.ExitWriteLock();
                }
                Thread.Sleep(1000); // Імітуємо час запису
            }
        }
    }
}

