using System.Collections;

namespace Practice_13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList() { 2, "Lol" };

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("------------");

            var months = new[]
            {
                "Янв", "Фев", "Мрт", "Апр", "Май", "Июн", "Июл", "Авг", "Снт", "Окт", "Нбр", "Дкб"
            };

            var numbers = new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            Console.WriteLine("------------");


            var arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add("gggg");

            arrayList.Add(months);
            arrayList.Add(numbers);


            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("------------");

            arrayList.AddRange(months);
            arrayList.AddRange(numbers);

            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("------------");

            // arrayList.Clear();

            var cont = arrayList.Contains(2);
            Console.WriteLine(cont);

            Console.WriteLine("------------");

            var listt = new ArrayList()
            {
                "Няка",
                "Пука",
                2,
                4
            };

            foreach (object o in listt)
            {
                Console.WriteLine(o);
            }

            var creatures = listt.GetRange(0, 2);
            Console.WriteLine("0000000000000000000000000000");
            foreach (object o in creatures)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("------------");
        }

    } 
    
}