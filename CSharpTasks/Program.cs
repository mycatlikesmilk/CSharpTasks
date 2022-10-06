namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Создать калькулятор для сложения чисел. На вход поступает два числа через пробел, на выход программа возвращает сумму этих чисел
         *
         * Пример ввода:
         * <первое число>: 62
         * <второе число>: 78
         *
         * Итоговый вывод:
         * 140
        */

        static void Main(string[] args)
        {
            string vhod = Console.ReadLine();

            char razdelitel = ' ';

            string[] chisla = vhod.Split(razdelitel);

            int[] zaparsili = new int[chisla.Length];

            for (int i = 0; i < chisla.Length; i++)
            {
                zaparsili[i] = int.Parse(chisla[i]);
            }

            int vihod = zaparsili[0] + zaparsili[1];

            Console.WriteLine(vihod);

            Console.ReadLine();
        }
    }
}