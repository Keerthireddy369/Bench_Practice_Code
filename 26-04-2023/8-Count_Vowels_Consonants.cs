using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Count_Vowels_Consonants
    {
       



       public static void Main()

        {

            int v = 0, c = 0;

            Console.WriteLine("Enter the String");

            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)

            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')

                    v++;



                else

                {

                    c++;

                }

            }

            Console.WriteLine("The no of vowels in the given array are  " + v);

            Console.WriteLine("The no of consonants in the given array are  " + c);

        }






    }
}
