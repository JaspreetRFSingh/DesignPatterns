using System;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonLazy
    {
        private static int counter = 0;
        private static readonly Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(()=>new SingletonLazy());
        public static SingletonLazy Instance
        {
            get
            {
                return instance.Value;
            }
        }
        private SingletonLazy() {
            counter++;
            Console.WriteLine("Counter: " + counter.ToString());
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine("SingletonLazy: " + message);
        }

    }
}
