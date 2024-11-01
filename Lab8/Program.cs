using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                string data = await LoadDataAsync("https://api.example.com/data");
                Console.WriteLine("Дані успішно завантажено: " + data);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Помилка при завантаженні даних: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася непередбачена помилка: " + ex.Message);
            }
        }

        static async Task<string> LoadDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Імітуємо можливу помилку завантаження даних
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Викидає виключення, якщо статус не успішний
                string data = await response.Content.ReadAsStringAsync();
                return data;
            }
        }
    }
}
