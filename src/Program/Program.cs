using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton<Greeter>.Instance.SayHiToTheWorld();
        }
    }
}
