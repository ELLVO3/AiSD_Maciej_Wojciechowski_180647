using System;
using System.Collections.Generic;
using System.Linq;
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
                return;
            }

            Node ptr = root;
            Node parent = null;

            while(ptr != null)
            {
                parent = ptr;
                if(value < ptr.value)
                {
                    ptr = ptr.left;
                }
                else
                {
                    ptr = ptr.right;
                }
            }
            w.parent = parent;

            if(value < parent.value)
            {
                parent.left = w;
            }
            else
            {
                parent.right = w;
            }
        }

        public void Delete(int value)
        {
            Node ptr = root;

            while(ptr != null )
            {
                if(ptr.value == value)
                {
                    RemoveNode(ptr);
                    return;
                }
                if (value < ptr.value)
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
            switch (node.CountKids())
            {
                case 0:
                    if(node == root)
                    {
                        root = null;
                    }
                    else
                    {
                        if(node.parent.left == node)
                        {
                            node.parent.left = null;
                        }
                        else
                        {
                            node.parent.right = null;
                        }
                    }
                    node.parent = null;
                    break;

                case 1:
                    Node child = (node.left != null) ? node.left : node.right;

                    if(node == root)
                    {
                        root = child;
                        child.parent = null;
                    }
                    else
                    {
                        if(node.parent.left == node)
                        {
                            node.parent.left = child;
                        }
                        else
                        {
                            node.parent.right = child;
                        }
                        child.parent = node.parent;
                    }
                    node.parent = null;
                    break;

                case 2:
                    Node successor = FindMin(node.right);

                    int tempValue = successor.value;

                    RemoveNode(successor);

                    node.value = tempValue;
                    break;
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

        public List<int> Wszerz()
        {
            List<int> result = new List<int>();
            if(root == null)
            {
                return result;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count() > 0)
            {
                Node current = queue.Dequeue();
                result.Add(current.value);

                if(current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
            return result;
        }

        public void Zig(Node x, Node y)
        {
            if (y == null || x == null) return;

            x.parent = y.parent;
            if(y.parent == null)
            {
                this.root = x;
            }
            else if(y.parent.left == y)
            {
                y.parent.left = x;
            }
            else
            {
                y.parent.right = x;
            }

            y.left = x.right;
            if(x.right != null)
            {
                x.right.parent = y;
            }
            x.right = y;
            y.parent = x;
        }

        public void Zag(Node x, Node y)
        {
            if (y == null || x == null) return;

            x.parent = y.parent;
            if(y.parent == null)
            {
                this.root = x;
            }
            else if (y.parent.left == y)
            {
                y.parent.left = x;
            }
            else
            {
                y.parent.right = x;
            }

            y.right = x.left;
            if(x.left != null)
            {
                x.left.parent = y;
            }

            x.left = y;
            y.parent = x;

        }
    }
}
