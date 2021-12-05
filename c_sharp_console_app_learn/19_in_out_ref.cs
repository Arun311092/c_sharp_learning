using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _19_in_out_ref
    {

        public static void update(out int a)    //modification must
        {
            a = 10;
        }
        public static void change(ref int d)    //modification not nust
        {
            d = 11;
        }
        public static void show(in int d)    //modification not allowed
        {
            Console.WriteLine(d);
        }

        public static void Main()
        {
            int b;
            int c = 9;
            update(out b);
            change(ref c);
            show(in b);
            Console.WriteLine("Updated value is: {0}", b);
            Console.WriteLine("Changed value is: {0}", c);
        }

    }

}
