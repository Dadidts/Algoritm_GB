using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x = 0;
            x = NumFibo("Введите число, для расчета числа Фибоначчи: ");

            int fib = RecursFibo(x);
                        
            Console.WriteLine("{0} член последовательности Фибоначчи является: {1}. Через Рекурсию", x, fib);

            fib = CiklFibo(x);

            Console.WriteLine("{0} член последовательности Фибоначчи является: {1}. Через цикл", x, fib);
            
            Console.ReadKey();
            

        }
        private static int NumFibo(string message)
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
        private static int RecursFibo(int x)
        {
            
            if (x == 0 || x == 1) return x;
            
                return RecursFibo(x - 1) + RecursFibo(x - 2);
            

        }
        private static int CiklFibo(int x)
        {
            int resultat = 0;
            int n = 1;
            int temp;

            for(int i=0; i < x; i++)
            {
                temp = resultat;
                resultat = n;
                n += temp;
            }


            return resultat;
        }






    }
}
