using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Negative_Power
    {
        public static void Main()
        {
            Console.WriteLine("Enter a  base number");
            int basen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an exponent number");
            int exp = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for (int i = 0; i > exp; i--)
            {
                result *= basen;
            }
            result = 1 / result;
            Console.WriteLine(result);



        }
    }
}