using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_app_learn
{
    internal class _22_async_await_params
    {
        class Program
        {
            static void Main(string[] args)
            {
                Method1("Hello");
                Method2("World");
                Console.ReadKey();
            }

            public static async Task Method1(String param)
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(param);
                        // Do something
                        Task.Delay(100).Wait();
                    }
                });
            }

            public static void Method2(String param)
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine(param);
                    // Do something
                    Task.Delay(100).Wait();
                }
            }
        }
    }
}
