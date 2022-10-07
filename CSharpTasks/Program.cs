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
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            double aParse = double.Parse(a);
            double bParse = double.Parse(b);
            double cParse = double.Parse(c);

            double D = Math.Pow(bParse, 2) - 4 * aParse * cParse;

            if (D > 0)
            {
                Console.WriteLine((-bParse + Math.Sqrt(D)) / (2 * aParse));
                Console.WriteLine((-bParse - Math.Sqrt(D)) / (2 * aParse));
            }
            else if (D == 0)
            {
                Console.WriteLine(-bParse / (2 * aParse));
            }
            else if (D < 0)
            {
                Console.WriteLine("Дискриминант отрицательный, корней нет");
            }

            Console.ReadLine();
        }
    }
}
