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

    }
}
