namespace Drelanium.DesignPatterns.Behavioral.Command
{
    // https://refactoring.guru/design-patterns/command
    // https://refactoring.guru/design-patterns/command/csharp/example

    // Also known as Action, Transaction

    // Command is a behavioral design pattern that turns a request into a stand-alone object
    // that contains all information about the request.This transformation lets you parameterize methods with
    // different requests, delay or queue a request’s execution, and support undoable operations.
    // The conversion allows deferred or remote execution of commands, storing command history, etc.

    // Usage examples: The Command pattern is pretty common in C# code.
    // Most often it’s used as an alternative for callbacks to parameterizing UI elements with actions.
    // It’s also used for queueing tasks, tracking operations history, etc.

    // Identification: The Command pattern is recognizable by behavioral methods in an abstract/interface type (sender)
    // which invokes a method in an implementation of a different abstract/interface type (receiver) which has
    // been encapsulated by the command implementation during its creation.
    // Command classes are usually limited to specific actions.

    class Program
    {
        static void Main(string[] args)
        {
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
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