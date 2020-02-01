namespace Drelanium.DesignPatterns.Structural.Facade
{
    // Some facades can work with multiple subsystems at the same time.
    public class Subsystem2
    {
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}

//Output

//Facade initializes subsystems:
//Subsystem1: Ready!
//Subsystem2: Get ready!
//Facade orders subsystems to perform the action:
//Subsystem1: Go!
//Subsystem2: Fire!
