using System;
using System.Threading;
using System.Threading.Tasks;

namespace threading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Task.Factory.StartNew(Method1);
            //Thread th = new Thread(Method1);
            //th.Start();
            Test();
        }


        static async void Test()
        {
            Console.WriteLine("Hello World!");
            Method1();
            Console.WriteLine("last");
            Console.Read();
        }
        static async Task Method1()
        {
            Console.WriteLine("Method 2");
            await Task.Delay(3000);
            Console.WriteLine("Method 1");
        }
    }
}
