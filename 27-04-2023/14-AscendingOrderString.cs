using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class AscendingOrderString
    {
        public static void Main()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            Console.WriteLine("Ascending order of the given string");
            foreach (char c in ch)
                Console.WriteLine(c);
        }
    }
}
