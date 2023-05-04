using System;

namespace C_Sharp_18_04_23_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM FOR REVERSE OF A STRING");
            Console.WriteLine("Enter any string:");
            string value = Console.ReadLine();
            char[] stringArray = value.ToCharArray();
            Array.Reverse(stringArray);
            string reversedArray = new string(stringArray);
            Console.WriteLine($"Reversed String:{reversedArray}");


        }
    }
}
