using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _22_async_await_exception
    {
        class Program
        {
            static void Main(string[] args)
            {
                Method1();
                Method2();
                Console.ReadKey();
            }

            public static async Task Method1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 25; i++)
                    {
                        Console.WriteLine(" Method 1 " + i);
                        // Do something
                        Task.Delay(100).Wait();
                    }
                    try
                    {
                        throw new Exception("my expn");
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                });
            }


            public static async Task Method2()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(" Method 2 " + i);
                        // Do something
                        Task.Delay(100).Wait();
                    }
                });
            }
        }
    }
}
