using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> alphabet = new List<string>{
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            Alphabet latin = new Alphabet(alphabet);

            Console.Write("Latin letters: ");

            foreach (string letter in latin)
            {
                Console.Write(letter + ' ');
            }

            Console.WriteLine();

            Apartment ap1 = new Apartment(1, 2);
            Apartment ap2 = new Apartment(1, 1);
            Apartment ap3 = new Apartment(2, 2);
            Apartment ap4 = new Apartment(4, 3);
            Apartment ap5 = new Apartment(3, 4);
            Apartment ap6 = new Apartment(3, 2);

            House house = new House();

            house.AddApartment(1,ap1);
            house.AddApartment(2,ap2);
            house.AddApartment(3,ap3);
            house.AddApartment(4,ap4);
            house.AddApartment(5,ap5);
            house.AddApartment(6,ap6);

            foreach (var iteam in house)
            {
                Console.WriteLine(iteam.ToString()); 
            }

            Avto avto1 = new Avto("John Doe", "Toyota", "ABC123", new DateTime(2024, 05, 05));
            Avto avto2 = new Avto("Jane Smith", "Honda", "DEF456", new DateTime(2024, 05, 03));
            Avto avto3 = new Avto("Alice Johnson", "Ford", "GHI789", new DateTime(2024, 05, 04), new DateTime(2024, 05, 05));

            Console.WriteLine();

            Park avtopark = new Park();
            avtopark.AddToPark(avto1);
            avtopark.AddToPark(avto2);
            avtopark.AddToPark(avto3);

            Console.WriteLine();

            foreach (var car in avtopark)
            {
               Console.WriteLine(car.ToString());

            }

            Oceanarium oceanarium = new Oceanarium();

            Dolphin dolphin1 = new Dolphin(10, "Friendly dolphin");
            Dolphin dolphin2 = new Dolphin(8, "Playful dolphin");

            Dolphin.AddDolphin(dolphin1);
            Dolphin.AddDolphin(dolphin2);

            
            Oceanarium.AddToAllAnimals(Dolphin.GetDolphins());
           
            Seal seal1 = new Seal(5, "Cute seal");
            Seal seal2 = new Seal(7, "Funny seal");

            Seal.AddSeal(seal1);
            Seal.AddSeal(seal2);

            Oceanarium.AddToAllAnimals(Seal.GetSeals());

            Console.WriteLine("All animals in the oceanarium:");
            Console.WriteLine(oceanarium.ToString());

            Employee employee1 = new Employee("Doe", "John", 1001, "123-456-7890");
            Employee employee2 = new Employee("Smith", "Jane", 1002, "987-654-3210");

            
            List<Employee> cafeEmployees = new List<Employee> { employee1, employee2 };

            Cafe cafe = new Cafe("Sunshine Cafe", "123 Main St", cafeEmployees);

            Console.WriteLine(cafe.ToString());
            foreach (Employee employee in cafeEmployees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.ReadLine();

        }
    }
}
