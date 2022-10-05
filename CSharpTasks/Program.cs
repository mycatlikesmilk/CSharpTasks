namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Пользователь вводит три переменных: <текст>, <шаблон> и <замена>
         * Необходимо, чтобы программа заменяла в <текст> все <шаблон> на <замена>
         *
         * Пример ввода:
         * <текст>:     Всем привет, сегодня я покушал и поиграл в игры. А еще я сходил в магазин и купил продукты
         * <шаблон>:    я
         * <замена>:    ты
         *
         * Итоговый вывод:
         * Всем привет, сегоднты ты покушал и поиграл в игры. А еще ты сходил в магазин и купил продукты
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходный текст: \n");
            var a = Console.ReadLine();
            Console.WriteLine($"Исходный текст: \n{a}\n");

            Console.WriteLine("\nВведите заменяемый текст: ");
            var c = Console.ReadLine();
            Console.WriteLine("\nВведите шаблон заметы: ");
            var b = Console.ReadLine();


            a = a.Replace(c, b);

            Console.WriteLine("\nТекст с заменой:");
            Console.WriteLine($"{a}");

            Console.ReadLine();
        }
    }
}