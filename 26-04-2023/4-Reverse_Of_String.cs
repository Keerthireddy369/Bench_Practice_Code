using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp_26_04_23
{
    class Reverse_Of_String
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("enter the string");
            name = Console.ReadLine();
            Reverse_Of_String str = new Reverse_Of_String();
            string rev = str.Reverse(name);
            Console.WriteLine("Reverse of a string is " + rev);

        }



        private string Reverse(string name)
        {
            if (name.Length > 0)
                return name[name.Length - 1] + Reverse(name.Substring(0, name.Length - 1));
            else
                return name;
        }

        
    }
}
