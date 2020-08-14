using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonEager
    {
        private static int counter = 0;
        private static readonly SingletonEager instance = new SingletonEager();
        public static SingletonEager Instance
        {
            get
            {
                return instance;
            }
        }
        private SingletonEager() {
            counter++;
            Console.WriteLine("Counter: " + counter.ToString());
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine("SingletonEager: "+ message);
        }

    }
}
