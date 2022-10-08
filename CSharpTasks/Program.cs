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

            // Ввод переменных от юзера

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            //конвертация 

            double adisc = Convert.ToDouble(a);
            double bdisc = Convert.ToDouble(b);
            double cdisc = Convert.ToDouble(c);

            double discriminant = Math.Pow(bdisc, 2) - 4 * (adisc) * (cdisc);

            if (discriminant == 0)
            {
                double xsqrt1 = (-bdisc + Math.Sqrt(discriminant)) / (2 * adisc);

                Console.WriteLine($"x={xsqrt1}");

            }
            else if (discriminant > 0)
            {
                double xsqrt1 = (-bdisc + Math.Sqrt(discriminant)) / (2 * adisc);
                double xsqrt2 = (-bdisc - Math.Sqrt(discriminant)) / (2 * adisc);

                Console.WriteLine($"Первый корень равен{xsqrt1}");
                Console.WriteLine($"Второй корень равен{xsqrt2}");
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("Корней нет");
            }
            Console.ReadKey(true);
        }
    }
}