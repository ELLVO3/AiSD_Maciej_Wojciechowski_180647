using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Node
    {
        public int value;
        public Node? parent = null;
        public Node? left = null;
        public Node? right = null;

        private int UID;
        static private int s_IDCounter = 1;

        public Node(int value)
        {
            this.value = value;
            this.UID = Node.s_IDCounter;
            Node.s_IDCounter += 1;
        }

        public int GetUID()
        {
            return this.UID;
        }

        public int CountKids()
        {
            int i = 2;
            if(this.left == null)
            {
                i--;
            }
            if(this.right == null)
            {
                i--;
            }
            return i;
        }

        public void Unparent(Node dziecko = null)
        {
            if (this.parent == null)
            {
                if(dziecko != null)
                {
                    dziecko.parent = null;
                }
                return;
            }

            if(this.parent.left == this)
            {
                this.parent.left = null;
                if(dziecko != null)
                {
                    this.parent.left = dziecko;
                }
            }

            else if(this.parent.right == this)
            {
                this.parent.right = null;
                if(dziecko != null)
                {
                    this.parent.right = dziecko;
                }
            }

            if(dziecko != null)
            {
                dziecko.parent = this.parent;
            }
            this.parent = null;
        }

        public Node Unchild()
        {
            Node dziecko = null;

            if(this.left != null)
            {
                dziecko = this.left;
            }
            if(this.right != null)
            {
                dziecko = this.right;
            }
            dziecko.Unparent();
            return dziecko;
        }
    }
}
