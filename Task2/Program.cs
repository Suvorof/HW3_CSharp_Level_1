using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        // 2) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        // Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
        // Константин Суворов. Санкт-Петербург.

        static void Main()
        {
            Console.Title = "Константин Суворов. Санкт-Петербург.";
            Console.WriteLine("Вас приветствует программа по подсчёту суммы нечётных чисел из тех, которые Вы будете вводить.\nСумма будет подсчитываться до тех пор пока Вы не введёте ноль.\n");
            int digit, sum = 0, result;
            do
            {
                Console.WriteLine("Введите любое целое число: от 0 до 4 294 967 295 включительно: ");
                result = Input();
                //digit = Convert.ToInt32(Console.ReadLine());
                if (result % 2 != 0 && result != 0)
                {
                    sum += result;
                    Console.WriteLine($"Сумма нечётных чисел равна {sum}.\n");
                }
                else if (result % 2 == 0 && result != 0)
                    Console.WriteLine("Чётные числа не суммируются, продолжайте вводить числа.\n");
                else if (result == 0)
                    Console.WriteLine("Вы ввели ноль, программа будет завершена, нажмите любую клавишу.\n");
            }
            while (result != 0);
            Console.ReadKey();
        }

        static int Input()
        {
            int x;
            bool flag;
            do
            {
                string s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                if (flag == true)
                    Console.WriteLine("Корректный ввод!");
                else
                    Console.WriteLine("Символы не могут быть чётными или нечётными.\nВведите число от 0 до 4 294 967 295 включительно:");
            }
            while (flag == false);
            return x;
        }
    }
}
