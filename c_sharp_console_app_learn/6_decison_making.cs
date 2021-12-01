using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class decision_logic
    {
        public static void Main(String[] args)
        {
            int i = 20;

            if (i == 10)
                Console.WriteLine("i is 10");
            else if (i == 15)
                Console.WriteLine("i is 15");
            else if (i == 20)
                Console.WriteLine("i is 20");
            else
                Console.WriteLine("i is not present");

            int number = 30;
            switch (number)
            {
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");
                    break;
                case 30:
                    Console.WriteLine("case 30");
                    break;
                default:
                    Console.WriteLine("None matches");
                    break;
            }

        }
    }
}
