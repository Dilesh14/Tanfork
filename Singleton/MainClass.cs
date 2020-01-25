using System;

namespace Singleton
{
    public class MainClass
    {
        public static void Main() 
        {
            SingletonClass ClassA = SingletonClass.Singleton;
            ClassA.Num = 100;
            Console.WriteLine("ClassA: " + ClassA.Num);
            SingletonClass ClassB = SingletonClass.Singleton;
            Console.WriteLine("ClassB: " + ClassB.Num);
        }
    }
}
