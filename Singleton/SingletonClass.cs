using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SingletonClass
    {
        public int Num { get; set; }
        private SingletonClass() 
        {
        }
        public static SingletonClass Singleton = new SingletonClass();
    }
}
