using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        // 2) � ���������� �������� �����, ���� �� ����� ����� 0 (������ ����� � ����� ������).
        // ��������� ���������� ����� ���� �������� ������������� �����. ���� ����� � ����� ������� �� �����, ��������� tryParse.
        // ���������� �������. �����-���������.

        static void Main()
        {
            Console.Title = "���������� �������. �����-���������.";
            Console.WriteLine("��� ������������ ��������� �� �������� ����� �������� ����� �� ���, ������� �� ������ �������.\n����� ����� �������������� �� ��� ��� ���� �� �� ������ ����.\n");
            int digit, sum = 0, result;
            do
            {
                Console.WriteLine("������� ����� ����� �����: �� 0 �� 4 294 967 295 ������������: ");
                result = Input();
                //digit = Convert.ToInt32(Console.ReadLine());
                if (result % 2 != 0 && result != 0)
                {
                    sum += result;
                    Console.WriteLine($"����� �������� ����� ����� {sum}.\n");
                }
                else if (result % 2 == 0 && result != 0)
                    Console.WriteLine("׸���� ����� �� �����������, ����������� ������� �����.\n");
                else if (result == 0)
                    Console.WriteLine("�� ����� ����, ��������� ����� ���������, ������� ����� �������.\n");
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
                    Console.WriteLine("���������� ����!");
                else
                    Console.WriteLine("������� �� ����� ���� ������� ��� ���������.\n������� ����� �� 0 �� 4 294 967 295 ������������:");
            }
            while (flag == false);
            return x;
        }
    }
}
