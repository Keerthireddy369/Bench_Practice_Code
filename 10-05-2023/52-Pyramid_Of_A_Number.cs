using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _52_Pyramid_Of_A_Number
    {
        static void Main() {
            int  space, num;
            Console.WriteLine("Enter the number of layers of your number pyramid: ");
            int layer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Print pyramid of numbers:");
            for (int i = 1; i <= layer; i++) // Total number of layer for pramid
            {
                for (space = 1; space <= (layer - i); space++) // Loop For Space
                    Console.Write(" ");
                for (num = 1; num <= i; num++) //increase the value
                    Console.Write(num);
                for (num = (i - 1); num >= 1; num--) //decrease the value
                    Console.Write(num);
                Console.WriteLine();
            }
        }
    }

}
