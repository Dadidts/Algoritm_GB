using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_2
{
    internal class Program
    {
        //Посчитать сложность функции

        public static int StrageSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) // O(N)

            {

                for (int j = 0; j < inputArray.Length; j++) // O(N)

                {

                    for (int k = 0; k < inputArray.Length; k++) // O(N)   // O(N) * O(N) * O(N) = O(N*N*N) = O(N^3) 

                    {
                        int y = 0;

                        if (j != 0)

                        {

                            y = k / j;

                        }

                        sum += inputArray[i] + i + k + j + y;

                    }

                }

            }

            return sum;
        }

    }
}
