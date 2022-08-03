using System;

namespace PersonnelInformationEmployees
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateEmployment { get; set; }
        public string Adress { get; set; }
        public decimal WageRate { get; set; }
        public int TotalMinutesWork { get; set; }
        public decimal Salary { get; set; }
    }
    
}
