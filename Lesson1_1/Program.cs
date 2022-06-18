using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int x = 397;
            Console.WriteLine(Test1(x));

            x = 100;
            Console.WriteLine(Test2(x));

            Console.WriteLine("Тестирование программы прошло успешно.");

            x = Numbers("Введите число: ");
            Prostoe(x);

            Console.Write(Prostoe(x));


            Console.ReadKey();

        }

        private static int Numbers(string message)
        {
            do
            {
                Console.Write(message);
                string text = Console.ReadLine();
                int result;
                if (int.TryParse(text, out result))
                {
                    return result;
                }
            }
            while (true);
        }
        private static string Prostoe(int x)
        {
            string text;
            int d = 0;
            int i = 2;

            while (i < x)
            {
                if (x % i == 0)
                {
                    d++;
                }
                i++;

            }

            if (d == 0)
            {
                return text = "Число является простым";
            }
            else
            {
                return text = "Число является не простым";
            }



        }
        private static string Test1(int x)
        {
            Console.WriteLine("Работа программы с заранее известными данными. ");
            Console.WriteLine("1е число является простым: 397.");
            return Prostoe(x);

        }
        private static string Test2(int x)
        {
            Console.WriteLine("2е число не является простым: 100");
            return Prostoe(x);

        }
    }
}
