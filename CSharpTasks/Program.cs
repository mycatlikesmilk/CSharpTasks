namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Создать калькулятор для сложения чисел. На вход поступает два числа через пробел, на выход программа возвращает сумму этих чисел
         *
         * Пример ввода:
         * <первое число>: 62
         * <второе число>: 78
         *
         * Итоговый вывод:
         * 140
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Запишите два числа через пробел: ");
            string a = Console.ReadLine();


            string[] counts = a.Split(' ');

            int number = Int32.Parse(counts[0]);
            int number2 = Int32.Parse(counts[1]);
            int sum = number + number2;

            Console.WriteLine("Сумма введённых чисел ");
            Console.WriteLine($"{sum}");

            Console.ReadLine();
        }
    }
}