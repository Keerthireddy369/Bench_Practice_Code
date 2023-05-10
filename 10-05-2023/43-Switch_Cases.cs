using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class _43_Switch_Cases
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Please enter a number from 1-7");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:

                    Console.WriteLine("your day is sunday");
                    break;
                case 2:

                    Console.WriteLine("your day is Monday");
                    break;
                case 3:

                    Console.WriteLine("your day is Tuesday");
                    break;
                case 4:

                    Console.WriteLine("your day is Wednesday");
                    break;
                case 5:

                    Console.WriteLine("your day is Thursday");
                    break;
                case 6:

                    Console.WriteLine("your day is Friday");
                    break;
                case 7:

                    Console.WriteLine("your day is Saturday");
                    break;
                default:
                    Console.WriteLine("Your given wrong input. Please stop debug and execute again");
                    break;



            }



        }
    }
}
