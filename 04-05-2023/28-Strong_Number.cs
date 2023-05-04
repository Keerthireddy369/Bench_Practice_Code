using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _28_Strong_Number
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum =0, fact;
            for(int j = n; j>0; j = j / 10)
            {
                fact = 1;
                for(int i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
            }
            if(sum == n)
            {
                Console.WriteLine($"{n} is a Strong Number");
            }
            else
            {
                Console.WriteLine($"{n} is not a Strong Number");
            }
        }
    }
}
