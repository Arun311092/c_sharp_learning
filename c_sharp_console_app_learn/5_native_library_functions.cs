using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _5_native_library_functions
    {
        static public void Main()
        {

            // using Floor() Method
            Console.WriteLine("Floor value of 123.123: "
                                 + Math.Floor(123.123));

            // using Asin() Method
            Console.WriteLine("Asin value of 0.35: "
                                 + Math.Asin(0.35));

            // using Sqrt() Method
            Console.WriteLine("Square Root of 81: "
                                  + Math.Sqrt(81));

            // using Round() Method
            Console.WriteLine("Round value of 14.6534: "
                                 + Math.Round(14.6534));
        }
    }
}
