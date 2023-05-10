using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _29_Perfect_Number
    {
        static void Main()
        {
            int sum =0;
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int b = 1; b < a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine($"{b}");
                    sum = sum + b;

                }
            }
            if(sum == a)
            {
                Console.WriteLine($"{a} is a Perfect Number");
            }
            else
            {
                Console.WriteLine($"{a} is not a Perfect Number");
            }
        }
    }
}
