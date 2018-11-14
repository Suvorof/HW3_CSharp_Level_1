using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    class Program
    {
        // 1.�) �������� ��������� Complex, ������� ����� ��������� ����������� �����. ������������������ ������ ���������.
        // ���������� �������. �����-���������.

        static void Main()
        {
            // ������ ���������� ���� Complex � ������ complex1.
            Complex complex1;
            // ����� �������� ����� ���������� complex1 ���� Complex, ��������� � ��� ����� �����.
            complex1.re = 1;
            complex1.im = 1;
            // ������ ���������� ���� Complex � ������ complex2.
            Complex complex2;
            // ����� �������� ����� ���������� complex2 ���� Complex, ��������� � ��� ����� �����.
            complex2.re = 2;
            complex2.im = 2;
            // ������ ���������� ���� Complex � ������� result, result1, result2 � ����������� �� ��������� � ���� ������� ��������, ��������� � ���������.
            Complex result, result1, result2;
            result = complex1.Plus(complex2);
            result1 = complex1.Minus(complex2);
            result2 = complex1.Multi(complex2);

            Console.WriteLine($"������ ��� ����������� �����: {complex1.im}+{complex1.re}i � {complex2.im}+{complex2.re}i:\n-����� ���� ����������� ����� �����: {result.ToString()},\n-�������� ���� ��������� ����� �����: {result1.ToString()},\n-������������ ���� ����������� ����� �����: {result2.ToString()}.");
            Console.ReadKey();
        }
    }

    struct Complex
    {
        public double im;
        public double re;

        // � C# � ���������� ����� ��������� ����� �������� ��� �������. ����� ���� ����������� �����.
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        // ������ ������������ ���� ����������� �����.
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        // ��������� ����������� �����.
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
