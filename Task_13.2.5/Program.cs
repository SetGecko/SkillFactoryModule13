using System.Collections;

namespace Task_13._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new[]
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
             1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
            };

            var combinedList = new ArrayList();
            foreach (var number in numbers)
            {
                combinedList.Add(months[number - 1]);
                combinedList.Add(number);
            }

            foreach (var value in combinedList)
                Console.WriteLine(value);
        }
    }
}