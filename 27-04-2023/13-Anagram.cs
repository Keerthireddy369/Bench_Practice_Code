using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Anagram
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string1");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a string2");
            string str1 = Console.ReadLine();
            char[] ch = str.ToCharArray();
            char[] ch1 = str1.ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch1);
            string val1 = new string(ch);
            string val2 = new string(ch1);
            if (val1 == val2)
            {
                Console.WriteLine("The given strings are anagram");
            }
            else
                Console.WriteLine("The given strings are not anagram");



        }
    }
}
