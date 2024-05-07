using System.Collections.Generic;

namespace HomeWork11
{
    internal class Cafe 
    {
        public string NameCafe { get; set; }
        public string Address { get; set; }

        public List<Employee> Employees = new List<Employee>();
        public Cafe(string nameCafe, string address, List<Employee> employees)
        {
            NameCafe = nameCafe;
            Address = address;
            Employees = employees;

        }
        IEnumerator<Employee> GetEnumerator() { return Employees.GetEnumerator(); }
        public override string ToString()
        {
            return $"Cafe`s name:{NameCafe}, address:{Address}";

        }


    }
}
