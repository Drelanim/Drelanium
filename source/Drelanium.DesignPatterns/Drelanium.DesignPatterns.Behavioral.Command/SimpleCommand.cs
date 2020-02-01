using System;

namespace Drelanium.DesignPatterns.Behavioral.Command
{
    // Some commands can implement simple operations on their own.
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
        }
    }
}

//Output

//Invoker: Does anybody want something done before I begin?
//SimpleCommand: See, I can do simple things like printing(Say Hi!)
//Invoker: ...doing something really important...
//Invoker: Does anybody want something done after I finish?
//ComplexCommand: Complex stuff should be done by a receiver object.
//Receiver: Working on(Send email.)
//Receiver: Also working on(Save report.)