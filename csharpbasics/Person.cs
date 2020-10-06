using System;
namespace csharpbasics 
{
class Person
{
    string name;
    int age;
    public byte Age
    {
        get
        {
            return Age;
        }
        set
        {
            if(value >20&&value<30)
            age = value;
        }
    }
    //autoimplemented property
    public string Name {get; set;}
    //random property
    public string address {get;}

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
}