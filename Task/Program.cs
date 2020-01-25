using System;

namespace Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static System.Threading.Tasks.Task SleepFunction()
        {
            return System.Threading.Tasks.Task.Delay(5000); //5 secs sleep
        }
    }
}
