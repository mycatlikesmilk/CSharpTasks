namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Создать программу вычисления квадратных уравнений
         * Пользователь вводит <a>, <b> и <c> и получает в ответе корни уравнения
         * Для непомнящих: квадратное уравнение имеет вид: ax^2+bx+c=0
         * Сначала вычисляется дискриминант по формуле D = b^2-4ac
         * если дискриминант положительный, тогда есть два корня, если равен нулю, тогда один корень, если отрицательный, значит корней нет
         * корни вычисляются следующим образом x = (-b ± корень(D)) / (2 * a)
         *
         * Пример ввода:
         * <a>:     -4
         * <b>:     28
         * <c>:     -49
         *
         * Итоговый вывод:
         * x = 3.5
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a: ");
            var a = Console.ReadLine();

            Console.WriteLine("Введите значение b: ");
            var b = Console.ReadLine();

            Console.WriteLine("Введите значение с: ");
            var c = Console.ReadLine();

            double ad = Convert.ToDouble(a);
            double bd = Convert.ToDouble(b);
            double cd = Convert.ToDouble(c);

            double disc = Math.Pow(bd, 2) - 4 * (ad) * (cd);

            if (disc == 0)
            {
                double x1 = ((-bd) + (Math.Sqrt(disc))) / (2d * ad);
                Console.WriteLine($"Входные данные:\na = {a}\nb = {b}\nc = {c}");
                Console.WriteLine("Выходные данные: ");
                Console.WriteLine($"x = {x1}");
            }
            else if (disc > 0)
            {
                double x1 = ((-bd) + (Math.Sqrt(disc))) / (2d * ad);
                double x2 = ((-bd) - (Math.Sqrt(disc))) / (2d * ad);
                Console.WriteLine($"Входные данные:\na = {a}\nb = {b}\nc = {c}");
                Console.WriteLine("Выходные данные: ");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (disc < 0)
            {
                Console.WriteLine($"Входные данные:\na = {a}\nb = {b}\nc = {c}");
                Console.WriteLine("Выходные данные: ");
                Console.WriteLine("Корней нет");
            }

            Console.ReadLine();
        }
    }
}