using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _3_string_formatting
    {
        static void Main(string[] args)
        {
            string s = "Name:{0} {1}, Location:{2}, Age:{3}";
            string msg = string.Format(s, "Ram", "Singh", "Mumbai", 32);
            Console.WriteLine("Format Result: {0}", msg);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
