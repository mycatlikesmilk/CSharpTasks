namespace Tasks.Task4
{
    internal class Program
    {
        public static void Task4()
        {
            Console.WriteLine("Введите числовое значение с точностью до десятых");
            var a = Console.ReadLine();

            double b = Convert.ToDouble(a);

            Console.WriteLine(b.ToString("N10"));

            Console.ReadLine();
        }


    }
}
