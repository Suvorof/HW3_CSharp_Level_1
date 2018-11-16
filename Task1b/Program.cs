using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    class Complex
    {
        // 1.�) �������� ����� Complexx, ������� ������ ��������� � ������������ �����. ��������� ������ ������.
        // ���������� �������. �����-���������.

        static void Main()
        {
            // ������� ������ �� ������.
            Complex complex1;
            // ������� ������ � ��������� ������ �� ���� � complex1.
            complex1 = new Complex(1, 1);
            // ������� ������ � ������� ���.
            Complex complex2 = new Complex(2, 2);
            // � ������� �������� Im �������� ���������� (���������) ���� im.
            complex2.Im = 3;
            // ������� ������ �� ������.
            Complex result, result1, result2;
            // ��� ��� � ������ Plus ��������� ����� ������,
            // � result ��������� ������ �� ����� ��������� ������.
            result = complex1.Plus(complex2);
            result1 = complex1.Minus(complex2);
            result2 = complex1.Minus(complex2);
            Console.WriteLine($"������ ��� ����������� �����: {complex1.im}+{complex1.re}i � {complex2.im}+{complex2.re}i:\n-����� ���� ����������� ����� �����: {result.ToString()},\n-�������� ���� ��������� ����� �����: {result1.ToString()},\n-������������ ���� ����������� ����� �����: {result2.ToString()}.");
            Console.ReadKey();
        }

        // ���� ���������.
        private double im;
        // �� ��������� �������� ���������, ������� private ����� �� ������.
        double re;

        // ����������� ��� ����������.
        public Complex()
        {
            im = 0;
            re = 0;
        }

        // �����������, � ������� ����� ����.
        // ���������� �������� �������� re, ����������� � ������ ���� � ������.
        public Complex(double _im, double re)
        {
            // ����� ����� �� ���������, � ���������� ����� ��������, ��� ��� ��������.
            im = _im;
            // ����� ��������, ��� � ���� ������ ������ ������������� ��������,
            // ������������ �������� ����� this
            // ���� ��������
            this.re = re;
        }

        // �������� ����������� �����
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        // ��������� ����������� �����
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        // ��������� ����������� �����
        public Complex Multiplication(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        // �������� - ��� �������� ������� � ������ ������.
        public double Im
        {
            get { return im; }
            set
            {
                // ��� ������� ����������� ������ �������������� �������.
                if (value >= 0) im = value;
            }
        }

        // ����������� �����, ������� ���������� ��������� ������������� ������.
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
