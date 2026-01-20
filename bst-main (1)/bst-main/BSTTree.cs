using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Tree
    {
        public Node? root = null;

        public Tree()
        {

        }

        public Node? FindNodeWithID(int id)
        {
            return nodeIDSearch(this.root, id);
        }

        private Node? nodeIDSearch(Node? node, int id)
        {
            if (node == null)
                return null;

            if (node.GetUID() == id)
                return node;

            Node? l = nodeIDSearch(node.left, id);
            if (l != null)
                return l;
            return nodeIDSearch(node.right, id);
        }

        public void Add(int value)
        {
            Node w = new Node(value);

            if(root == null)
            {
                root = w;
            }

            else
            {
                Node ptr = root;

                while((ptr.left != null && ptr.value > w.value) || (ptr.right != null && ptr.value <= w.value))
                {
                    if(ptr.value > value)
                    {
                        ptr = ptr.left;
                    }
                    else
                    {
                        ptr = ptr.right;
                    }
                }

                if(ptr.value > w.value)
                {
                    ptr.left = w;
                }
                else
                {
                    ptr.right = w;
                }
                w.parent = ptr;
            }
        }

        public void Delete(int value)
        {
            Node ptr = root;

            while(ptr != null)
            {
                if(ptr.value == value)
                {
                    RemoveNode(ptr);
                    return;
                }

                if(value < ptr.value)
                {
                    ptr = ptr.left;
                }
                else
                {
                    ptr = ptr.right;
                }
            }
        }

        public Node FindMin(Node node)
        {
            Node min = node;
            while(min.left != null)
            {
                min = min.left;
            }
            return min;
        }

        public void RemoveNode(Node node)
        {
            Node kandydat = null;

            switch (node.CountKids())
            {
                case 0:
                    node.Unparent();
                    break;

                case 1:
                    kandydat = node.Unchild();
                    node.Unparent(kandydat);
                    break;

                case 2:
                    kandydat = this.FindMin(node.right);
                    RemoveNode(kandydat);
                    node.Unparent(kandydat);

                    kandydat.left = node.left;
                    kandydat.left.parent = kandydat;
                    kandydat.right = node.right;

                    if(kandydat.right != null)
                    {
                        kandydat.right.parent = kandydat;
                    }

                    node.left = null;
                    node.right = null;
                    break;
            }

            if(node == this.root)
            {
                this.root = kandydat;
            }
        }

        public void Zig(Node x, Node y)
        {
            x.parent = y.parent;

            if(y.parent != null)
            {
                if(y.parent.left == y)
                {
                    y.parent.left = x;
                }
                else
                {
                    y.parent.right = x;
                }
            }

            y.left = x.right;

            if(x.right != null)
            {
                y.left.parent = y;
            }

            y.parent = x;
            x.right = y;

            if(y == this.root)
            {
                this.root = x;
            }
        }

        public void Zag(Node x, Node y)
        {
            x.parent = y.parent;

            if(y.parent != null)
            {
                if(y.parent.left == y)
                {
                    y.parent.left = x;
                }
                else
                {
                    y.parent.right = x;
                }
            }

            y.right = x.left;

            if(x.left != null)
            {
                y.right.parent = y;
            }

            x.left = y;
            y.parent = x;

            if (y == this.root)
            {
                this.root = x;
            }
        }

        public Node Search(int value)
        {
            Node ptr = root;

            while(ptr != null)
            {
                if(ptr.value == value)
                {
                    return ptr;
                }
                if(value < ptr.value)
                {
                    ptr = ptr.left;
                }
                else
                {
                    ptr = ptr.right;
                }
            }
            return ptr;
        }
        
    }
}
