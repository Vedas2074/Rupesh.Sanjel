using LearningClasses;
using System;

class Program
{
    static void Main()
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

        Rectangle rectangle = new Rectangle(23.4,43.4);
        //{
            // object initializer
             //  rectangle.Length = 23.7;
            //rectangle.Breadth = 6.352;
        //};
        rectangle.Length = 23.7;
        rectangle.Breadth = 6.352;
        var result = rectangle.GetArea();
        rectangle.PrintDetails();
        //Rectangle rectangle =new Rectangle(32.6,6.32); 
        Circle c =new Circle(23.4);
        c.PrintDetails();
    }
}