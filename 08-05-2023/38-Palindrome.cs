using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _38_Palindrome
    {
        public static void Main()
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            char[] str1 = str.ToCharArray();
            Array.Reverse(str1);
            string str2 = new string(str1);
            Console.WriteLine("The reverse of given string is\n" + str2);
            if (str == str2)
            {
                Console.WriteLine("The given string is Palindrome");
            }
            else
                Console.WriteLine("The given string is not a palindrome");
        }
    }
}
