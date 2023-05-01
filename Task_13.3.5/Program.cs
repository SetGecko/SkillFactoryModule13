using System.Collections;

namespace Task_13._3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May"
            };
            var missing = new ArrayList()
            {
               1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

        }
        private static void GetMissing(List<string> months, ArrayList missing)
        {
            // инициализируем массив для 7 нужных нам недостающих элементов
            var missedArray = new string[7];

            // извлекаем эти элементы из ArrayList, и копируем в массив
            missing.GetRange(4, 7).CopyTo(missedArray);

            // Добавляем наш массив в конец списка
            months.AddRange(missedArray);

            // смотрим, что получилось
            foreach (var month in months)
                Console.WriteLine(month);
        }
    }
}