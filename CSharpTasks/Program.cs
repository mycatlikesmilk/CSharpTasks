namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Пользователь вводит вещественное число (с запятой). Необходимо вывести это число с точностью до 10 знаков после запятой
         *
         * Пример ввода:
         * <ввод>: 4,6
         *
         * Итоговый вывод:
         * 4,60000000000
        */

        static void Main(string[] args)
        {
            string enter = Console.ReadLine();
            double number = double.Parse(enter);
            string output = number.ToString("N10");
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}

