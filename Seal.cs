using System.Collections.Generic;

namespace HomeWork11
{
    internal class Seal : Animal
    {
        public static List<Seal> Seals = new List<Seal>();
        public Seal(int age, string description)
        {
            Name = "Seal";
            Description = description;
            Age = age;

        }

        public static void AddSeal(Seal seal){ Seals.Add(seal);}

        public static List<Seal> GetSeals() { return Seals; }

        public static IEnumerator<Seal> GetEnumerator()
        {
            return Seals.GetEnumerator();
        }

        public override string ToString()
        {
            return $"Seal:"+ base.ToString();
        }
    }

}
