using System;

namespace Drelanium.DesignPatterns.Creational.Prototype
{
    // https://refactoring.guru/design-patterns/prototype
    // https://refactoring.guru/design-patterns/prototype/csharp/example

    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = Name;
            return clone;
        }
    }
}

//Output
//
//    Original values of p1, p2, p3:
//   p1 instance values: 
//      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
//      ID#: 666
//   p2 instance values:
//      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
//      ID#: 666
//   p3 instance values:
//      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
//      ID#: 666

//Values of p1, p2 and p3 after changes to p1:
//   p1 instance values: 
//      Name: Frank, Age: 32, BirthDate: 01/01/00
//      ID#: 7878
//   p2 instance values(reference values have changed):
//      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
//      ID#: 7878
//   p3 instance values(everything was kept the same):
//      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
//      ID#: 666