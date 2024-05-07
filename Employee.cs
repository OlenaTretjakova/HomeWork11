using System.Collections.Generic;

namespace HomeWork11
{
    internal class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int EmployeeID { get; set; }
        public string Phone { get; set; }

       
        public Employee(string lastName, string firstName, int employeeID, string phone)
        {
            LastName = lastName;
            FirstName = firstName;
            EmployeeID = employeeID;
            Phone = phone;
        }
       
        public override string ToString()
        {
            return $"First name: {FirstName}, last name: {LastName}, employee ID: {EmployeeID}, phone:{Phone}";
        }
    }
}
