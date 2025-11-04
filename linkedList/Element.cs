using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class Element
    {
        public int wartość { get; set; }
        public Element next { get; set; }
        public Element prev { get; set; }

        public Element(int value)
        {
            wartość = value;
        }
        public override string ToString()
        {
            return wartość.ToString();
        }
    }
}
