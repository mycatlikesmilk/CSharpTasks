namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Пользователь вводит строку. Программа выводит эту строку, выравнивая ее по центру консоли
         *
         * Пример ввода:
         * <ввод>:
         * ------------------------------------------------------------------------------------------------------
         * |Всем привет!                                                                                        |
         * ------------------------------------------------------------------------------------------------------
         *
         * Итоговый вывод:
         * ------------------------------------------------------------------------------------------------------
         * |                                             Всем привет!                                           |
         * ------------------------------------------------------------------------------------------------------
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            var text = Console.ReadLine();

            var height = Console.WindowHeight;
            var witdth = Console.WindowWidth;

            var textLength = text.Length;
            Console.WriteLine($"{textLength}");
            Console.WriteLine($"{witdth}");

            var center = (witdth / 2) + (textLength / 2);

            Console.WriteLine(text.PadLeft(center));

            Console.ReadLine();
        }
    }
}