using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _26_PrimeFactor
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int b =2; b<=a; b++)
            {
                while(a%b == 0)
                {
                    a /= b;
                    Console.WriteLine($"{b} is a prime factor of given number.");
                   
                }
            }
        }
    }
}
