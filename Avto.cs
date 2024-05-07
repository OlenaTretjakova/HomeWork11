using System;

namespace HomeWork11
{
    internal class Avto
    {
        public string NameOwner { get; set; }
        public string Marka { get; set; }
        public string Num { get; set; }
        public DateTime DateArrived { get; set; }
        public DateTime DateLeft { get; set; }

        public Avto() { }

        public Avto(string nameOwner, string marka, string num, DateTime dateArrived)
        {
            NameOwner = nameOwner;
            Marka = marka;
            Num = num;
            DateArrived = dateArrived;
            DateLeft = DateTime.MinValue;

        }
        public Avto(string nameOwner, string marka, string num, DateTime dateArrived, DateTime dateleft)
        {
            NameOwner = nameOwner;
            Marka = marka;
            Num = num;
            DateArrived = dateArrived;
            DateLeft = dateleft;

        }

            public override string ToString()
        {
            return $"NameOwner: {NameOwner}, marka avto: {Marka}, avto`s number: {Num},\n" +
                   $"date arravel: {DateArrived}, date left:{DateLeft}\n";
        }

    }
}
