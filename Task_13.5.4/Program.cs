namespace Task_13._5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();

                words.Push(input); // Изменить здесь


                Console.WriteLine();
                Console.WriteLine("В стеке:");
                switch (input)
                {
                    //   если  команда pop - пробуем достать элемент
                    case "pop":
                        words.TryPop(out string popResult);
                        break;
                    //   если  команда peek - пробуем  просмотреть элемент
                    case "peek":
                        words.TryPeek(out string peekResult);
                        break;
                    default:
                        // если ни одна из команд не распознана - простов стек добавляем то что введено
                        words.Push(input);
                        break;
                }
            }
        }
        public static Stack<string> words = new Stack<string>();
    }
}