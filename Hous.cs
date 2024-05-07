using System;
using System.Collections.Generic;

namespace HomeWork11
{
    internal class House : Apartment
    {
        public int NumberApartment { get; set; }

        public Dictionary<int, Apartment> Apartments { get; } = new Dictionary<int, Apartment>();

        public House() : base()
        {
            NumberApartment = 0;

        }
        public void AddApartment(int numberApartment, Apartment apartment)
        {
            if (!Apartments.ContainsKey(NumberApartment))
            {
                Apartments.Add(numberApartment, apartment);
            }
            else
            {
                Console.WriteLine("The apartment with this number has already been created.");
            }

        }

        public IEnumerator<KeyValuePair<int, Apartment>> GetEnumerator()
        {
            return Apartments.GetEnumerator();
        }

        public override string ToString()
        {
            return NumberApartment + base.ToString();
        }

    }
}
