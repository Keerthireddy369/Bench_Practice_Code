using System;

namespace C_Sharp_Basics_24_04_23
{
    public class Program
    {
        public static void print(int i , int j)
        {
            Console.WriteLine("Enter Action to be done:");
            Console.WriteLine("For example : Enter 1 to to addition of two numbers ...............");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
            {
                Console.WriteLine($"Addition of 2 numbers = {i + j}");

            }
            else if (k == 2)
            {
                Console.WriteLine($"Substraction of 2 numbers = {i - j}");
            }
            else if (k == 3)
            {
                Console.WriteLine($"Multiplication of 2 numbers = {i * j}");
            }
            else if (k == 4)
            {
                Console.WriteLine($"Division of 2 numbers = {i / j}");
            }
           
            else
            {
                Console.WriteLine("Enter a valid value");
                
            }

           //print(i,j);

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any two numbers:");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            print(i,j);
            Console.ReadKey();
            
        }
    }
}
