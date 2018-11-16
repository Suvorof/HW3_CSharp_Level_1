using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    class Complex
    {
        // 1.б) Дописать класс Complexx, добавив методы вычитания и произведения чисел. Проверить работу класса.
        // Константин Суворов. Санкт-Петербург.

        static void Main()
        {
            // Описали ссылку на объект.
            Complex complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new Complex(1, 1);
            // Описали объект и создали его.
            Complex complex2 = new Complex(2, 2);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            complex2.Im = 3;
            // Создали ссылку на объект.
            Complex result, result1, result2;
            // Так как в методе Plus создается новый объект,
            // в result сохраняем ссылку на вновь созданный объект.
            result = complex1.Plus(complex2);
            result1 = complex1.Minus(complex2);
            result2 = complex1.Minus(complex2);
            Console.WriteLine($"Заданы два комплексных числа: {complex1.im}+{complex1.re}i и {complex2.im}+{complex2.re}i:\n-Сумма двух комплексных чисел равна: {result.ToString()},\n-Разность двух коплесных чисел равна: {result1.ToString()},\n-Произведение двух комплексных чисел равно: {result2.ToString()}.");
            Console.ReadKey();
        }

        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;

        // Конструктор без параметров.
        public Complex()
        {
            im = 0;
            re = 0;
        }

        // Конструктор, в котором задаём поля.
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public Complex(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }

        // сложение комплексных чисел
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        // вычитание комплексных чисел
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        // умножение комплексных чисел
        public Complex Multiplication(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }

        // Специальный метод, который возвращает строковое представление данных.
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
