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
            Console.WriteLine("Введите текст, в котором заменят выбранные переменные:");

            var text = Console.ReadLine();

            Console.WriteLine("Введите заменяемые символы:");

            var shablon = Console.ReadLine();

            Console.WriteLine("Введите на что будут заменяться указанные символы:");

            var zamena = Console.ReadLine();

            String yaKot = text;
            yaKot = yaKot.Replace(shablon, zamena);
            Console.WriteLine("Готовый вариант: '{0}'", yaKot);
            Console.ReadLine();
        }
    }
}