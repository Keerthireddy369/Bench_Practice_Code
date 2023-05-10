using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _44_Two_Arrays_Same_Element
    {
        public static void Main()
        {
            Console.WriteLine("enter the of the two arrays");
            int ln = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[ln];
            int[] arr2 = new int[ln];
            Console.WriteLine("The first array elements are");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The second array elements are");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }



            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine("Two array elements are same " + arr1[i] + " = " + arr2[j]);
                    }

                }

            }





        }
    }
}
