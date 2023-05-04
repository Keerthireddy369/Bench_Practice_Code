using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _21_Non_Repeated_Digits_InArray
    {
        static void Main()
        {
            int i, j ,k;
            
            int[] arr = new int[5];
            Console.WriteLine("Enter any values:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (j = 0; j < arr.Length; j++)
            {
                for (k = 0; k < arr.Length; k++)
                {
                    if (arr[j] == arr[k] && (j != k))
                    {
                        break;
                    }
                }
                   if(k == arr.Length)
                    {
                        Console.WriteLine("Non-Repeated Digits are : {0}", arr[j]);
                    }
                

            }
                
            
          

        }
    }
}
