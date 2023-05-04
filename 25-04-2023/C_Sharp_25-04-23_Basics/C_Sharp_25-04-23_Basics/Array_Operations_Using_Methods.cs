using System;
using System.Linq;

namespace C_Sharp_25_04_23_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i ;
            Console.WriteLine("Enter Elements Into An Array:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter any number from 1 to 5");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j == 1)
            {
                //int sum = 0;
                //for (i = 0; i < arr.Length; i++)
                //{
                //    sum += arr[i];
                //}
                
                Console.WriteLine($"The Sum Of All THe Numbers In The Array Was :{arr.Sum()} ");
            }
            if(j == 2)
            {
                Console.WriteLine($"The Difference Between The Large Index Value and Small Index Value Was : { arr[i-1] - arr[0] } ");
            }
            if (j == 3)
            {
                Array.Sort(arr);
                Console.WriteLine("Ascending Order Of An Array Was :");
                foreach(int k in arr)
                {
                    Console.WriteLine(k);
                }
                Console.WriteLine("Descending Order Of An Array Was :");
                Array.Reverse(arr);
                foreach(int l in arr)
                {
                    Console.WriteLine(l);
                }
            }
            if (j == 4)
            {
                Console.WriteLine($"Average Of THe Array : {arr.Average()}");
            }
            if(j==5)
            {
                Console.WriteLine($"The Sum of Largest Number And Smallest Number in Array Was {arr.Max() + arr.Min()}");
                Console.WriteLine($"The Difference Between The Largest Number And Smallest Number in Array Was {arr.Max() - arr.Min()}");
            }
        }
    }
}
