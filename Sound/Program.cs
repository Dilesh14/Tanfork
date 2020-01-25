using SoundClass;
using System;
namespace Sound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The key");
            int _key = int.Parse(Console.ReadLine());
            Beep beep = new Beep();
            beep.Start(_key);
        }
    }
}
