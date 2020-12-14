using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models{

public class Employee{
    public int Id { get;set;}
    [Required(ErrorMessage="We need your FirstName")]
    public string FirstName { get;set;}
    
    [Required(ErrorMessage="We need your LastName")]
    public string LastName { get; set;}
    public string Address { get; set;}
    public byte? Age { get; set;}
    public float? Salary { get; set;}
     
     public static List<Employee> GetEmployee()
     {
     Employee employee1 = new Employee()
            {
                Id =1,
                FirstName = "Bibek",
                LastName ="Regmi", 
                Address = "Kathmandu",
                Age = 25,
                Salary = 7500

            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Rupesh",
                LastName ="Sanjel", 
                Address ="Lalitpur",
                Age = 21,
                Salary = 5000

            };
            List<Employee> employees =new List<Employee>(){employee1,employee2};
            return employees;
     }
}
}