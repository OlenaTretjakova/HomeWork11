using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace HomeWork11
{
    internal class Park:Avto
    {
        public Avto Car;

        public List<Avto> Cars = new List<Avto>();

        public Park():base()
        {
            Cars = new List<Avto>();
        }

        public void AddToPark(Avto car)
        {
            Cars.Add(car);
        }

        public IEnumerator<Avto> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
    }
}
