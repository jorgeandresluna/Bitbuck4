﻿﻿using System;
namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var iAmTrue = true;
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            
            //TODO

            Console.ReadKey();
        }

        public static bool AlwaysReturnsTrue()
        {
            //TODO
            return true;
        }

        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
