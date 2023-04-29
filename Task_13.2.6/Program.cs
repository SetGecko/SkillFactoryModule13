using System.Collections;
using System.Text;

namespace Task_13._2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList()
           {
               1,
               "Няка ",
               "Пука ",
               777,
           };

            int sum = 0;

            StringBuilder text = new StringBuilder();

            foreach (var element in arrayList)
            {
                if (element is int)
                {
                    sum += (int)element;
                }

                if (element is string s)
                {
                    text.Append(element);
                }
            }

            var result = new ArrayList() { sum, text.ToString() };

            foreach (var elem in result)
            {
                Console.WriteLine(elem);
            }
        }
    }
}