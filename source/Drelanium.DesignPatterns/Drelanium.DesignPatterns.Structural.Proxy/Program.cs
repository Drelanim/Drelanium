using System;

namespace Drelanium.DesignPatterns.Structural.Proxy
{
    // https://refactoring.guru/design-patterns/proxy
    // https://refactoring.guru/design-patterns/proxy/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);
        }
    }
}

//Output

//Client: Executing the client code with a real subject:
//RealSubject: Handling Request.

//Client: Executing the same client code with a proxy:
//Proxy: Checking access prior to firing a real request.
//RealSubject: Handling Request.
//Proxy: Logging the time of request.