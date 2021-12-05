using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _19_in_out_ref
    {

        public static void reassign(out int a)    //modification must
        {
            a = 6;
        }
        public static void change(ref int d)    //modification not nust
        {
            d++;
        }
        public static void show(in int c)    //modification not allowed
        {
            Console.WriteLine(c);
        }

        public static void Main()
        {
            int a = 0;
            int b = 1;
            int c = 2;
            reassign(out a);
            change(ref b);
            show(in c);
            Console.WriteLine("Updated value is: {0}", a);
            Console.WriteLine("Changed value is: {0}", b);
            Console.WriteLine("Shown value is: {0}", c);
        }

    }

}
