﻿namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Пользователь вводит вещественное число (с запятой). Необходимо вывести это число с точностью до 10 знаков после запятой
         *
         * Пример ввода:
         * <ввод>: 4,6
         *
         * Итоговый вывод:
         * 4,60000000000
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовое значение с точностью до десятых");
            var a = Console.ReadLine();

            double b = Convert.ToDouble(a);

            Console.WriteLine(b.ToString("N10"));

            Console.ReadLine();
        }
    }
}

