using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheGame
{
    static class TextUtils
    {
        public static void Animate(string text, int sleepTime)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(sleepTime);
            }
            Console.WriteLine();
        }
    }
}
