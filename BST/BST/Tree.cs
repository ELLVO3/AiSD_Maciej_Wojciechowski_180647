using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Tree
    {
        public Wezel root;
        public int counter = 0;

        public void addValue(int value)
        {
            if(root == null)
            {
                root = new Wezel(value);
                counter = 1;
                return;
            }

            Wezel temp = root;

            while (true)
            {
                if (value < temp.value)
                {
                    if (temp.left == null)
                    {
                        temp.left = new Wezel(temp, value);
                        counter++;
                        return;
                    }
                    temp = temp.left;
                }

                else
                {
                    if (temp.right == null)
                    {
                        temp.right = new Wezel(temp, value);
                        counter++;
                        return;
                    }
                    temp = temp.right;
                }
            }
        }

        public Wezel search()
        {
            if (root == null)
            {
                return null;
            }

            Wezel temp = root;

            while (temp.left != null)
            {
                temp = temp.left;
            }
            return temp;
        }

        public int returnValue()
        {
            if (root == null)
            {
                throw new InvalidOperationException("Drzewo jest puste.");
            }

            Wezel temp = search();
            int usunietaWartosc = temp.value;

            counter--;

            if (this.root == temp)
            {
                root = temp.right;
                if (root != null)
                {
                    root.parent = null;
                }
            }

            else
            {
                Wezel rodzic = temp.parent;
                Wezel praweDziecko = temp.right;

                if (rodzic.left == temp)
                {
                    rodzic.left = praweDziecko;
                }

                else
                {
                    rodzic.right = praweDziecko;
                }

                if (praweDziecko != null)
                {
                    praweDziecko.parent = rodzic;
                }
            }

            temp.parent = null;
            temp.right = null;

            return usunietaWartosc;
        }

        public void Zig(Wezel x)
        {
            var y = x.parent;
            var b = x.right;
            var ry = y.parent;

            x.right = y;
            y.parent = x;
            y.left = b;

            if (b != null)
            {
                b.parent = y;
            }

            x.parent = ry;

            if (ry == null)
            {
                root = x;
            }

            else 
            { 
                if(ry.left == y)
                {
                    ry.left = x;
                }
                else
                {
                    ry.right = x;
                }
            }
        }

        public void Zag(Wezel x)
        {
            if(x == null || x.parent == null)
            {
                return;
            }

            var y = x.parent;
            var b = x.left;
            var ry = y.parent;

            x.left = y;
            y.parent = x;
            y.right = b;

            if(b != null)
            {
                b.parent = y;
            }

            x.parent = y;

            if(ry == null)
            {
                root = x;
            }
            else
            {
                if(ry.left == y)
                {
                    ry.left = x;
                }
                else
                {
                    ry.right = x;
                }
            }

        }

        public void ZigZig(Wezel x)
        {
            Wezel y = x.parent;

            if(y == null || y.parent == null)
            {
                return;
            }

            Wezel z = y.parent;

            if(z.left == x && y.parent.left == y)
            {
                Zig(y);
                Zig(x);
            }

            else if(z.right == y && y.right == x)
            {
                Zag(y);
                Zag(x);
            }
        }

        public void ZigZag(Wezel x)
        {
            Wezel y = x.parent;

            if(y == null || y.parent == null)
            {
                return;
            }

            Wezel z = y.parent;

            if(z.left == y && y.right == x)
            {
                Zag(x);
                Zig(x);
            }

            else if(z.right == y && y.left == x)
            {
                Zig(x);
                Zag(x);
            }
        }

        public Wezel Find(int value)
        {
            Wezel current = root;
            while(current != null)
            {
                if(value == current.value)
                {
                    return current;
                }

                if(value < current.value)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            return null;
        }

    }
}
