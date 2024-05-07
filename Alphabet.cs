using System.Collections;
using System.Collections.Generic;

namespace HomeWork11
{
    internal class Alphabet : IEnumerable
    {

        public List<string> List = new List<string>();
        public Alphabet(List<string> list)
        {
            foreach (var item in list)
            {
                List.Add(item);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }





    }
}
