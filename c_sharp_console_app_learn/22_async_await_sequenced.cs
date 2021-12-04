using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _22_async_await_sequenced
    {
        class Program
        {
            static async Task Main(string[] args)
            {
                await Method1();
                Method2();
                Console.ReadKey();
            }

            public static async Task Method1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(" Method 1");
                        // Do something
                        Task.Delay(100).Wait();
                    }
                });
            }


            public static void Method2()
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine(" Method 2");
                    // Do something
                    Task.Delay(100).Wait();
                }
            }
        }
    }
}
