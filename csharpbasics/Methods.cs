using System;
using System.Linq;

class Methods
{
    void PrintInfo()
    {
        Console.WriteLine("Printing something....");
        Multiply(23.5f, 2233.534f);

        Sum(2.3, 45.1);

        Greet("Rupesh", "Mr");

        byte[] numbers = { 2, 4, 6, 7, 12, 234, 56 };
        (byte Min, byte Max) result = FindMinMax(numbers);

        PrintCustomerDetails(age: 23, name: "Rupesh", isMale: true, address: "ktm");
    }
    void PrintSomething(string message)
    {
        Console.WriteLine(message);
    }
    float Multiply(float firstNum, float secondNum)
    {
        float product = firstNum * secondNum;
        return product;
    }
    //float Multiply(float firstNum, float secondNum,float thirdNum)
    //{
       // float product =firstNum*secondNum*thirdNum;
       // return product;
    //}
//variable number of arguments
double Sum(params double[] numbers)
{
    double sum = 0;
    foreach (double num in numbers)
    {
        sum = sum + num;
    }
    return sum;
}
//optional arguments
string Greet(string name, string prefix)
{
    string fullName = prefix + " ," + name;
    //string fullName =$"{prefix},  {name}"; //string interpolation
    return fullName;
}
// Returning multiple values: using tuple

(byte,byte) FindMinMax(byte[] numbers)
{
    byte max = numbers.Max ();
    byte min = numbers.Min ();

    return (min, max);
}
void PrintCustomerDetails(string name, string address, byte age, bool isMale)
{
    Console.WriteLine($"{name}[{age}],{address}");
}

}