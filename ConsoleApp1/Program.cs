using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fnum, snum, us, nf;
            double n;
            nf = 1;
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");
            Console.WriteLine("Введите 1-е число: ");
            fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число: ");
            snum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите операцию : ");
            us = Convert.ToInt32(Console.ReadLine()); 
                if (us == 1)
                {
                    Console.WriteLine(fnum + snum);
                }

                else if (us == 2)
                {
                    Console.WriteLine(snum - fnum);
                }

                else if (us == 3)
                {
                    Console.WriteLine(snum*fnum);
                }

                else if (us == 4)
                {
                    Console.WriteLine(snum/fnum);
                }

                else if (us == 5)
                {
                    Console.WriteLine("Введите число степени ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Math.Pow(fnum, n));
                }
            
                else if (us == 6)
                {
                    Console.WriteLine(Math.Sqrt(fnum));
                }

                else if (us == 7)
                {
                    Console.WriteLine(fnum/100);
                }

                else if (us == 8)
                {
                    for (int i = 1; i <= fnum; i++)
                    {
                        nf *= i;   
                        Console.WriteLine(nf);
                    }
                 }
                else if (us == 9)
                {
                    Console.WriteLine("Конец программы");
                }
                else
                {
                    Console.WriteLine("Выберите другую опцию");
                }
            Console.ReadLine();
        }
    }
}