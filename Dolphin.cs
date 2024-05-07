using System.Collections.Generic;

namespace HomeWork11
{
    internal class Dolphin : Animal
    {
        public static List<Dolphin> Dolphins = new List<Dolphin>();

        public static List<Dolphin> GetDolphins()
        {
            return Dolphins;
        }
        public Dolphin(int age, string description)
        {
            Name = "Dolphin";
            Description = description;
            Age = age;
           

        }

        public static void AddDolphin(Dolphin dolphin)
        {
            Dolphins.Add(dolphin);
        }
        public static IEnumerator<Dolphin> GetEnumerator()
        {
            return Dolphins.GetEnumerator();
        }
        
        public override string ToString()
        {
            return $"Dolphin:" + base.ToString();
        }
    }
}
