using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _7_array_loop
    {

        public static void Main()
        {

            char[] arr = {'G', 'e', 'e', 'k', 's',
                        'f', 'o', 'r', 'G', 'e',
                                 'e', 'k', 's'};


            Console.Write("Array printing using for loop = ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.WriteLine();

            Console.Write("Array printing using foreach loop = ");

            foreach (char ch in arr)
            {
                Console.Write(ch);
            }
        }
    }
}
