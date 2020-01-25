using System;
using System.Collections.Generic;
using System.Text;

namespace SoundClass
{
    public class Beep
    {

        public Beep() { }
        public void Start(int code)
        {
            bool isTheCodeCorrect = PlayBeepIfPasswordIsCorrect(code);
            if (!isTheCodeCorrect)
            {
                Console.WriteLine("The PassWord You entered is not right [:(] ");
            }
        }
        private bool PlayBeepIfPasswordIsCorrect(int passcode)
        {
            const int code = 1100;
            if(code == passcode)
            {
                _play();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Plays beeps
        /// </summary>
        private void _play()
        {
            Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep();
        }
    }
}
