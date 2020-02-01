namespace Drelanium.DesignPatterns.Structural.Flyweight
{
    public class Car
    {
        public string Owner { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }
}

//Output

//FlyweightFactory: I have 5 flyweights:
//Camaro2018_Chevrolet_pink
//black_C300_Mercedes Benz
//C500_Mercedes Benz_red
//BMW_M5_red
//BMW_white_X6

//Client: Adding a car to database.
//FlyweightFactory: Reusing existing flyweight.
//Flyweight: Displaying shared {"Owner":null,"Number":null,"Company":"BMW","Model":"M5","Color":"red"}
//and unique {"Owner":"James Doe","Number":"CL234IR","Company":"BMW","Model":"M5","Color":"red"}
//state.

//Client: Adding a car to database.
//FlyweightFactory: Can't find a flyweight, creating new one.
//Flyweight: Displaying shared {"Owner":null,"Number":null,"Company":"BMW","Model":"X1","Color":"red"}
//and unique {"Owner":"James Doe","Number":"CL234IR","Company":"BMW","Model":"X1","Color":"red"}
//state.

//FlyweightFactory: I have 6 flyweights:
//Camaro2018_Chevrolet_pink
//black_C300_Mercedes Benz
//C500_Mercedes Benz_red
//BMW_M5_red
//BMW_white_X6
//BMW_red_X1