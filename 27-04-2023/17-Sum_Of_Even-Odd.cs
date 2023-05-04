using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _17_Sum_Of_Even_Odd
    {
        static void Main()
        {

            int i,sum1=0,sum2=0;
            int[] j = new int[10];
            Console.WriteLine("Enter any numbers");
            for (i = 0; i < 10; i++)
            {
                j[i] = Convert.ToInt32(Console.ReadLine());

                if (j[i] % 2 == 0)
                {
                    sum1 += j[i];

                }
                else
                {
                    sum2 += j[i];
                }
            }
            Console.WriteLine($"Sum of even numbers : {sum1}");
            Console.WriteLine($"Sum of even numbers : {sum2}");
        }
    }
}
