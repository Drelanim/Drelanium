using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Behavioral.Strategy
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}

//Output

//Client: Strategy is set to normal sorting.
//Context: Sorting data using the strategy(not sure how it'll do it)
//a, b, c, d, e

//Client: Strategy is set to reverse sorting.
//Context: Sorting data using the strategy(not sure how it'll do it)
//e, d, c, b, a