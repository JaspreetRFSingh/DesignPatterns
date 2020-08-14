
using System;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonExample
    {
        private static int counter = 0;
        private static SingletonExample singleInstance = null;
        private static readonly object obj = new object();
        public static SingletonExample Instance
        {
            get
            {
                if (singleInstance == null)
                {
                    lock (obj)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new SingletonExample();
                        }
                    }
                }
                return singleInstance;
            }
        }
        private SingletonExample()
        {
            counter++;
            Console.WriteLine("Counter: " + counter.ToString());
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine("Singleton: " + message);
        }
    }
}
