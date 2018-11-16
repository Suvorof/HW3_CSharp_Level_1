using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    class Program
    {
        // 1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        // Константин Суворов. Санкт-Петербург.

        static void Main()
        {
            // Создаём переменную типа Complex с именем complex1.
            Complex complex1;
            // Задаём значения полям экземпляра complex1 типа Complex, обращаясь к ним через точку.
            complex1.re = 1;
            complex1.im = 1;
            // Создаём переменную типа Complex с именем complex2.
            Complex complex2;
            // Задаём значения полям экземпляра complex2 типа Complex, обращаясь к ним через точку.
            complex2.re = 2;
            complex2.im = 2;
            // Создаём переменные типа Complex с именами result, result1, result2 и присваиваем им результат в виде методов сложения, вычитания и умножения.
            Complex result, result1, result2;
            result = complex1.Plus(complex2);
            result1 = complex1.Minus(complex2);
            result2 = complex1.Multi(complex2);

            Console.WriteLine($"Заданы два комплексных числа: {complex1.im}+{complex1.re}i и {complex2.im}+{complex2.re}i:\n-Сумма двух комплексных чисел равна: {result.ToString()},\n-Разность двух коплесных чисел равна: {result1.ToString()},\n-Произведение двух комплексных чисел равно: {result2.ToString()}.");
            Console.ReadKey();
        }
    }

    struct Complex
    {
        public double im;
        public double re;

        // В C# в структурах могут храниться также действия над данными. Сумма двух комплексных чисел.
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        // Пример произведения двух комплексных чисел.
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        // Вычитание комплексных чисел.
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
