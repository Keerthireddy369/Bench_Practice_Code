using System;
using System.Linq;

namespace Task_C_Sharp_26_04_23
{
    class Strings_Reverse_Comparing
    {
        static void Main(string[] args)
        {
            string string1, string2;
            Console.WriteLine("Enter any String:");
            string1 = Console.ReadLine();
            Console.WriteLine("Enter a String to Compare:");
            string2 = Console.ReadLine();
          
            string reverseString = new string(string1.Reverse().ToArray());
            if(reverseString == string2)
            {
                Console.WriteLine("Given strings are reverse of each other");
            }
            else
            {
                Console.WriteLine("Given strings are not reverse of each other ");
            }



        }
    }
}
