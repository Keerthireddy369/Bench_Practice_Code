using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _20_Smallest_Largest_NumbersInArray
    {
        static void Main()
        {
            int i;
            int[] arr = new int[5];
            Console.WriteLine("Enter any values:");
            for( i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Largest Number in the array was {arr.Max()}");
            Console.WriteLine($"Smallest Number in the array was {arr.Min()}");
        }
    }
}
