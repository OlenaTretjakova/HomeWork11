using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Oceanarium : Animal
    {

        public static List<Object> AllAnimals = new List<object>();
        public Oceanarium() { }

        public static void AddToAllAnimals(List<Dolphin> Dolphins)
        {
            AllAnimals.AddRange(Dolphins);
        }

        public static void AddToAllAnimals(List<Seal> Seals)
        {
            AllAnimals.AddRange(Seals);
        }

        public static IEnumerator<Oceanarium> GetEnumerator()
        {
            return GetEnumerator();
        }

        public  override  string ToString()
        {
            string result = "";

            foreach (var item in AllAnimals)
            {
                if (item is Dolphin)
                {
                    result += (item as Dolphin).ToString() + "\n";
                }
                else if (item is Seal)
                {
                    result += (item as Seal).ToString() + "\n";
                }
            }

            return result;
        }
    }



}
