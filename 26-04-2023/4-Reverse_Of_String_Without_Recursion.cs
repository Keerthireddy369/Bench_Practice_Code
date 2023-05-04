using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Reverse_Of_String_Without_Recursion
    {
        public static void Main()
        {
            string rev = "";
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            int strlen = str.Length - 1;
            while (strlen >= 0)
            {
                rev = rev + str[strlen];
                strlen--;
            }
            Console.WriteLine("The reverse of the given string is " + rev);
        }
    }
}
