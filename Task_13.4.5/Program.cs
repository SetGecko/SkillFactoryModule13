using System.Diagnostics;

namespace Task_13._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();

            // Выполним вставку
            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

            // Выведем результат
            Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        }
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };
    }
}