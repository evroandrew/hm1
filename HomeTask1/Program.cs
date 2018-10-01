using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace HomeTask1
{
    class Program
    {
        static double check_num(double num)
        {
            double num1 = Math.Round(num, 0);
            if (num1 < num)
                num1++;
            return num1;
        }
        static double check_nim(double num, ref int i)
        {
            double num1 = Math.Round(num, 0);
            if (num1 < num)
            {
                num1++;
                i--;
            }
            return num1;
        }
        static void m1(double a, double b, double c, double d, double l, double m)
        {
            double steps, st, length_a, length_b, num;
            int i = 0;
            steps = check_num(c / m);
            st = l / (steps * m);
            length_a = check_nim(a / d, ref i);
            length_b = check_nim(b / d, ref i);
            num = check_num((2.0 * (length_b + length_a) + i) / st);
            Console.Write("M1:");
            show_result(num);
        }
        static void m2(double a, double b, double c, double d, double l, double m)
        {
            double steps, st, length_a, length_b, num;
            steps = check_num(c / m);
            st = l / (steps * m);
            length_a = check_num(a / d);
            length_b = check_num(b / d);
            num = check_num((2.0 * (length_b + length_a)) / st);
            Console.Write("M2:");
            show_result(num);
        }
        static void m3(double a, double b, double c, double d, double l, double m)
        {
            double steps, st, length_a, length_b, num;
            steps = check_num(c / m);
            st = l / (steps * m);
            length_a = check_num(2.0 * a / d);
            length_b = check_num(2.0 * b / d);
            num = check_num(((length_b + length_a)) / st);
            Console.Write("M3:");
            show_result(num);
        }
        static void show_result(double num1)
        {
            if ((num1 == 1) || (num1 == 11))
                Console.WriteLine("Надо " + num1 + " рулон");
            else
                Console.WriteLine("Надо " + num1 + " рулонов");
        }
        static double check1(char a)
        {
            for (; ; )
            {
                Console.Write(a + " = __\b\b");
                string str = Console.ReadLine();
                double d1 = 0;
                if ((!Double.TryParse(str, out d1)) | (d1 < 0))
                {
                    Console.WriteLine("Try again...");
                }
                else
                    return d1;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a,b,c для комнаты:");
                double a = check1('a');
                double b = check1('b');
                double c = check1('c');
                Console.WriteLine("Введите d,l,m для обоев:");
                double d = check1('d');
                double l = check1('l');
                double m = check1('m');
                Console.WriteLine("mode (1.2.3): ");
                Thread.Sleep(2000);
                if (l < c)
                    Console.WriteLine("Длина обоев меньше высоты комнаты");
                else
                {
                    int mode = 0;
                    while (mode < 4)
                    {
                        switch (mode)
                        {
                            case 1:
                                m1(a, b, c, d, l, m);
                                break;
                            case 2:
                                m2(a, b, c, d, l, m);
                                break;
                            case 3:
                                m3(a, b, c, d, l, m);
                                break;
                            default:
                                break;
                        }
                        mode++;
                    }
                }
            }
            catch { Console.WriteLine("Error"); }
            Console.ReadKey();
        }
    }
}