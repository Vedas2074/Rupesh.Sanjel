using LearningClasses;
using System;

class Program
{
    static void Main2342()
    {       
        var person1 = new Person("Bishnu", "Ktm");
        var person2 = new Person("Ramesh", "Bhaktapur", 23);
        var person3 = new Person("Rame", "Bhaktapur", 20);

        var person4 = new Person();

        // Accessing static members
        var x = Person.ScientificName;
        Person.Do();
        var y = Math.Sqrt(342);

        var s1 = Calculator.Sum<int>(23, 34);
        var s2 = Calculator.Sum<decimal>(233443.23m, 34344656.1m);

        Rectangle rectangle = new Rectangle();
        rectangle.Length = 23.6;
        rectangle.Breadth = 6.32;
        var result = rectangle.GetArea();
    }
}