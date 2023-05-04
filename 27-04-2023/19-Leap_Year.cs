using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _19_Leap_Year
    {
        static void Main()
        {
            Console.WriteLine("Enter any year:");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i%4 == 0 && (i%100 !=0 || i%400 ==0))
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }
        }
    }
}
