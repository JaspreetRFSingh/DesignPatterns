using DesignPatterns.Singleton;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => printFirst(),
            () => printSecond());

        }


        static void printFirst()
        {
            SingletonExample sExample1 = SingletonExample.Instance;
            sExample1.PrintMessage("FIRST");
        }
        static void printSecond()
        {
            SingletonExample sExample2 = SingletonExample.Instance;
            sExample2.PrintMessage("SECOND");
        }

    }
}
