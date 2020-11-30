using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ- Language Integrated Query
            int[] numbers = {11,20,16,23,45,67,34,46,76,82,90};
            //find all the elements form numbers which are less than 75 and greater than 20

            //using method syntax -lambda expression
            var result = numbers.Select(x => x < 75 && x > 20);

            //query syntax -query expression
            var result2 = from x in numbers
                         where x < 75 && x > 20
                         select x;

            string[] names = {"Ram","Shyam","Hari","Binod","Bibek","Rupesh"};

            //find names starts with letter 'B' and having length less than 6
            var result3 =from name in names
                         where name.StartsWith("B") && name.Length < 6
                         select name; 
            
            //projection
            var result4 =from num in numbers
                         select num * num; 

            //ordering
            var result5 = from num in numbers
                         orderby num
                         select num; 
            // partitioning
            var result6 = numbers.Take(5);
            var result7 = numbers.Skip(5).Take(5);

            // Quantifiers
            var isEvenThere = numbers.Any(num =>num %2==0); 
            var areAllEven = numbers.All(num =>num %2==0);
            var is26there = numbers.Contains(26);

            var result8 = Enumerable.Range(1, 1000);
            var result9 = Enumerable.Repeat("Hello World", 10);

            List<Person> people = new List<Person>()
            {
                new Person() {Id =1, FirstName="Ram",LastName="A",Address, age},
                new Person() {Id =2, FirstName="Shyam",LastName="B",Address, age},
                new Person() {Id =3, FirstName="Hari",LastName="C",Address, age},
                new Person() {Id =4, FirstName="Gita",LastName="D",Address, age},
                new Person() {Id =5, FirstName="Sita",LastName="E",Address, age},
                new Person() {Id =6, FirstName="Rita",LastName="F",Address, age},
            };
                // find all people who live in kathmandu?
                var result10 = from person in  people
                              where person.Address =="ktm"
                              select person;

                //find all people who are minors 
                var result10 = from person in  people
                              where person.Age < 18 &&person.Address =="Bhaktapur"
                              select person;              
                                                            
        }
    }
}
