using System;

namespace Drelanium.DesignPatterns.Structural.Proxy
{
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
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