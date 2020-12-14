using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models{

public class Department{
    public int Id { get;set;}
    [Required(ErrorMessage="We need your FirstName")]
    public string Name { get;set;}
    public int Code { get; set;}
    public string Branch { get; set;}
    
         public static List<Department> GetDepartment()
         {
              Department department1 = new Department()

            {
                Id =1,
                Name = "S&S Groups",
                Code =3876, 
                Branch = "Kathmandu",

            };
            Department department2 = new Department()
            {
                Id = 2,
                Name = "R&G Groups",
                Code =6454, 
                Branch = "Lalitpur",


            };
            List<Department> departments =new List<Department>(){department1,department2};
            return (departments);
}
}
}