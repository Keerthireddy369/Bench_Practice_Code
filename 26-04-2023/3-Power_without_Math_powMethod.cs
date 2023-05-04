using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Power_without_Math_powMethod
    {
        static void Main()
        {
            int Power = 1;
            Console.WriteLine("Enter a Base Number :");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Exponential Number:");
            int j = Convert.ToInt32(Console.ReadLine());    
            while(j != 0)
            {
                Power *= i;
                --j;
            }
            Console.WriteLine($"Result = {Power}"); 
        }
    }
}
