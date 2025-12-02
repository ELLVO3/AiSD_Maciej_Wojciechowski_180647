using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Wezel
    {
        public Wezel left;
        public Wezel right;
        public int value;
        public Wezel parent;

        public Wezel( Wezel parent, int value)
        {
            this.parent = parent;
            this.value = value;
        }

        public Wezel(int value)
        {
            this.value = value;
        }

        public int ileDzieci()
        {
            int x = 0;
            if (left != null)
            {
                x++;
            }

            if (right != null)
            {
                x++;
            }
            return x;
        }

        override
        public String ToString()
        {
            return "[" + value + "]";
        }

    }
}
