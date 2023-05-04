 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Merge_Arrays
    {
        static void Main()
        {
            int n ,m ;
            Console.WriteLine("Enter the size of first array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] i = new int[n];
            Console.WriteLine("Enter the elements into first array:");
            for(int a = 0; a < i.Length; a++)
            {
                i[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the size of second array:");
            m = Convert.ToInt32(Console.ReadLine());
            int[] j = new int[m];
            Console.WriteLine("Enter the elements into second array:");
            for (int a = 0; a < j.Length; a++)
            {
                j[a] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] k = i.Concat(j).ToArray();
            Console.WriteLine($"Merged array was:{string.Join(",",k)}");
           
        }

    }
}
