using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Launcher
    {
        public static void Main()
        {
            Entry();
        }
        public static void Entry()
        {
            Console.WriteLine("Hello, what would you like to do?");
            Console.WriteLine("0............................Exit");
            Console.WriteLine("1..Target an integer via a string");
            int selector = Convert.ToInt32(Console.ReadLine());
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    targetIntViaString.Entry();
                    break;
                default:
                    Console.WriteLine("Please select one of the available options");
                    break;
            }

        }
    }
}
