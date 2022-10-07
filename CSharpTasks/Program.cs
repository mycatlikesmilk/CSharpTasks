namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Реализуйте программу подбора языка по мему в картинке (смотри дискорд)
        */
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ВЫБОР ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ЯЗЫКА ПРОГРАММИРОВАНИЯ\n");
            Console.ResetColor();
            Console.Write("Хотите много зарабатывать? (y/n): ");
            var a = Console.ReadLine();

            if(a == "y")
            {
                Console.Write("Вы тупой? (y/n): ");
                var b = Console.ReadLine();

                if(b == "y")
                {
                    Console.Write("Очень? (y/n): ");
                    var c = Console.ReadLine();

                    if (c == "y")
                    {
                        Console.Write("У вас есть друзья? (y/n): ");
                        var g = Console.ReadLine();

                        if(g == "y")
                        {
                            Console.Write("Они тоже тупые? (y/n): ");
                            var h = Console.ReadLine();

                            if(h == "y")
                            {
                                Console.Write("JS");
                            }
                            else
                            {
                                Console.Write("Ruty");
                            }
                        }
                        else
                        {
                            Console.Write("PHP");
                        }
                    }
                    else
                    {
                        Console.Write("Вы насмотрелись ХАУДИ ХО? (y/n): ");
                        var d = Console.ReadLine();

                        if (d == "y")
                        {
                            Console.Write("Python");
                        }
                        else
                        {
                            Console.Write("Вам нравится Windows? (y/n): ");
                            var e = Console.ReadLine();

                            if (e == "y")
                            {
                                Console.Write("C#");
                            }
                            else
                            {
                                Console.Write("Вы пидор? (y/n): ");
                                var f = Console.ReadLine();

                                if (f == "y")
                                {
                                    Console.Write("Swift");
                                }
                                else
                                {
                                    Console.Write("Perf");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.Write("Вы инженер? (y/n): ");
                    var f = Console.ReadLine();

                    if(f == "y")
                    {
                        Console.Write("Вам больше 50? (y/n): ");
                        var c = Console.ReadLine();
                        
                        if(c == "y")
                        {
                            Console.Write("Fortran");
                        }
                        else
                        {
                            Console.Write("MatLab");
                        }
                    }
                    else
                    {
                        Console.Write("У вас есть ноги? (y/n): ");
                        var c = Console.ReadLine();

                        if( c == "y")
                        {
                            Console.Write("А они вам нужны? (y/n): ");
                            var d = Console.ReadLine();

                            if(d == "y")
                            {
                                Console.Write("Java");
                            }
                            else
                            {
                                Console.Write("C++");
                            }
                        }
                        else
                        {
                            Console.Write("C");
                        }
                    }
                }
            }
            else
            {
                Console.Write("Delphi");
            }

            Console.ReadLine();
        }
    }
}
