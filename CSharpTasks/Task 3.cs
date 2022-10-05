namespace Tasks.Task3
{
    internal class Program
    {
        public static void Task3()
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
