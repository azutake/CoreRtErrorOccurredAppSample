using System;
using CoreRtCantWorkLibrarySample;

namespace CoreRtErrorOccurredAppSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Class1().TestAsync().Wait();
            Console.WriteLine("Execution finished!!");
        }
    }
}
