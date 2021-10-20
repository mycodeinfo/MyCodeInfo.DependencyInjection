using System;

namespace MyCodeInfo.DependencyInjectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLifetimeTest.Run();

            Console.WriteLine("Tests completed.");
        }
    }
}
