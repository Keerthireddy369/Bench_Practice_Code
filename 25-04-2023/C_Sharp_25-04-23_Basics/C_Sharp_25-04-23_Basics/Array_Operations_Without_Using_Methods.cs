using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_25_04_23_Basics
{
    class Array_Operations_Without_Using_Methods
    {
        static void Main()
        {
            int[] arr = new int[5];
            int i , ch , sum =0 ;
            Console.WriteLine("Enter Elements Into An Array:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter any number from 1 to 4");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j == 1)
            {
                
                for (i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine($"The Sum Of All THe Numbers In The Array Was :{sum} ");
            }
            if (j == 2)
            {
                Console.WriteLine($"The Difference Between The Large Index Value and Small Index Value Was : { arr[i - 1] - arr[0] } ");
            }
            if (j == 3)
            {
                for (i = 1; i < arr.Length; i++)
                {
                    for (int m = 0; m < arr.Length - i; m++)
                    {
                        if (arr[m] > arr[m + 1])
                        {
                            ch = arr[m];
                            arr[m] = arr[m + 1];
                            arr[m + 1] = ch;
                        }
                    }

                }
                Console.WriteLine("Ascending Order Of An Array Was:");
                foreach (int l in arr)
                {
                    ch = l;
                    Console.WriteLine(l);
                }
                for (i = 1;i<arr.Length;i++)
                {
                    for(int m = 0; m<arr.Length-i;m++)
                    {
                        if (arr[m] < arr[m + 1])
                        {
                            ch = arr[m];
                            arr[m] = arr[m + 1];
                            arr[m + 1] = ch;
                        }
                    }
                   
                }
                Console.WriteLine("Descending Order Of An Array Was:");
                foreach (int l in arr)
                {
                    ch = l;
                    Console.WriteLine(l);
                }

            }
            if (j == 4)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                int count = arr.Length;
                Console.WriteLine($"Average Of THe Array : {sum/count}");
            }
           
        }
    }
    
}
