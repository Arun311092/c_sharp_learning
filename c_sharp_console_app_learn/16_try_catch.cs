using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _16_try_catch
    {
        class DivNumbers
        {
            int result;

            DivNumbers()
            {
                result = 0;
            }
            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
            static void Main(string[] args)
            {
                DivNumbers d = new DivNumbers();
                d.division(25, 0);
                Console.ReadKey();
            }
        }
    }
}
