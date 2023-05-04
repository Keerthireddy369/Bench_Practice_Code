using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _23_Sorting_Without_Sort_and_Copying
    {
        static void Main()
        {
            
            Console.WriteLine("Enter the array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr1 = new int[n];

            int i,j,temp;
            Console.WriteLine("Enter elements into array:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Copied Array Was:");
            for (i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];

               
            }
            foreach (var ch in arr1)
            {
                Console.Write(ch);
            }

            for (i = 1; i < arr.Length; i++)
            {
                for (j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp; 
                    }
                }
            }
            Console.WriteLine("Ascending order of an array was:");
            foreach(var c in arr)
            {
                temp = c;
                Console.WriteLine(c);
            }
            
        }
    }
}
