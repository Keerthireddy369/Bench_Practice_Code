using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Second_Largest_Element_InArray
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the size of an array:");
            n = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] arr = new int[n]; 
            Console.WriteLine("Enter elements into an Array:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine($"The Second Largest Element In The Array Was : {arr[n-2]}");
        }
    }
}
