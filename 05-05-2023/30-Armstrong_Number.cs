using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _30_Armstrong_Number
    {
        static void Main()
        {
            int r,a1=0,sum=0;
            Console.WriteLine("Enter any Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            a = a1;
            while (a1 > 0)
            {
                r = a1 % 10;
                sum = sum + (r * r * r );
                a1 = a1 / 10;
            }
            if(sum == a)
            {
                Console.WriteLine($"{a} is an Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{a} is not an Armstrong number");
            }

            
        }
    }
}
