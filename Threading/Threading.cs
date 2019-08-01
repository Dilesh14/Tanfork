using System;
using System.Threading;

namespace Threading
{
    class Threading
    {
        static void Main(string[] args)
        {
            // Create Thread class object and paas object of ThreadStart delegate with specified method its constructor 
            Thread th = new Thread(new ThreadStart(MyMethod));
            th.Name = "Child thread";
            // Start child thread
            th.Start();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Main Thread");
            }
            Console.WriteLine("End Thread...");
            Console.ReadKey();
        }
        // Method used in thread execution
        public static void MyMethod()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Child Thread");
            }
        }
    }
}
