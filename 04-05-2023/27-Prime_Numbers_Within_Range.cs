using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _27_Prime_Numbers_Within_Range
    {
        static void Main()
        {
            int j , count;
            Console.WriteLine("Enter thes range:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The prime numbers b/w the given range was : ");

            for (int i = n;i <= m; i++)
            {
                count = 0;
                for (j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }


                if (count == 1)
                {
                    Console.WriteLine($"{i}");
                       
                }
            }
           
            
        }
    }
}
