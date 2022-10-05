namespace Tasks.Task2
{
    internal class Program
    {
        public static void Task2()
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
