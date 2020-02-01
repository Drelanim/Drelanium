using System;

namespace Drelanium.DesignPatterns.Creational.Singleton
{
    // https://refactoring.guru/design-patterns/singleton
    // https://refactoring.guru/design-patterns/singleton/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}


//Output

//Singleton works, both variables contain the same instance.