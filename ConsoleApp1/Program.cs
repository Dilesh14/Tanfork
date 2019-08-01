using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void CarEngineHandler(string msg);
        CarEngineHandler ListOfHandler;
        public static Program tt = new Program();
        static void Main(string[] args)
        {
            Car car = new Car();
            car.CurrentSpeed = 80;
            car.ModelName = "bmw";
            car.MaxSpeed = 120;
            tt.ListOfHandler += tt.SayMsg;
            tt.ListOfHandler += tt.printStuff;
            for (int i = 0; i < 200; i += 10)
            {
                if (car.CurrentSpeed < car.MaxSpeed)
                {
                    tt.ListOfHandler(" Keep going  your speed is " + car.CurrentSpeed);
                }
                else if (car.CurrentSpeed > car.MaxSpeed)
                {
                    if (tt.ListOfHandler != null)
                    {
                        tt.ListOfHandler("STOPPPPP");
                    }

                }
                car.CurrentSpeed += i;
            }
            Console.ReadLine();

        }

        void SayMsg(string msg)
        {
            Console.WriteLine("Hey there!");
        }

        void printStuff(string msg)
        {
            Console.WriteLine(msg);
        }


    }
}
