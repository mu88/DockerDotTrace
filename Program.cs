using System;
using System.Threading.Tasks;

namespace TestWithDocker
{
    internal class Program
    {
        private static async Task Main()
        {
            while (true)
            {
                await Task.Delay(1000);

                DoSomeWork();
            }
        }

        private static void DoSomeWork()
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(new Random().Next());
            }
        }
    }
}