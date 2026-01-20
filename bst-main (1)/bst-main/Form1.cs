using BST;

namespace Kolo
{
    public partial class Form1 : Form
    {
        BST.Tree tree = new BST.Tree();
        BST.Visualization visualization;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visualization = new BST.Visualization(tree, pictureBox1);

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);
            tree.Add(value);
            Refresh();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);
            tree.Delete(value);
            Refresh();
        }

        private void bt_pre_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            PreOrder(tree.root, list);

            lbl_out.Text = String.Join(", ", list);
        }

        private void PreOrder(Node node, List<int> list)
        {
            list.Add(node.value);
            if(node.left != null)
            {
                PreOrder(node.left, list);
            }
            if(node.right != null)
            {
                PreOrder(node.right, list);
            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            InOrder(tree.root, list);

            lbl_out.Text = String.Join(", ", list);
        }

        private void InOrder(Node node, List<int> list)
        {
            if (node.left != null)
            {
                InOrder(node.left, list);
            }
            list.Add(node.value);
            if (node.right != null)
            {
                InOrder(node.right, list);
            }
        }

        private void bt_post_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            PostOrder(tree.root, list);

            lbl_out.Text = String.Join(", ", list);
        }

        private void PostOrder(Node node, List<int> list)
        {
            if (node.left != null)
            {
                PostOrder(node.left, list);
            }
            if (node.right != null)
            {
                PostOrder(node.right, list);
            }
            list.Add(node.value);
        }

        private void bt_wszerz_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            Wszerz(list);

            lbl_out.Text = String.Join(", ", list);

        }

        private int GetHeight(Node node)
        {
            if (node.value == 0)
            {
                return 0;
            }
            return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
        }

        private void PrintCurrentLevel(Node node, int level, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            if (node.value == 1)
            {
                list.Add(node.value);
            }

            else if (node.value > 1)
            {
                PrintCurrentLevel(node.left, level - 1, list);
                PrintCurrentLevel(node.right, level - 1, list);
            }
        }

        private void Wszerz(List<int> list)
        {
            int h = GetHeight(tree.root);

            for (int i = 1; i <= h; i++)
            {
                PrintCurrentLevel(tree.root, i, list);
            }
        }

        private void bt_wypisz_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);
            List<int> list = new List<int>();


            Node startNode = tree.Search(value);
            PreOrder(startNode, list);

            lbl_out.Text = String.Join(", ", list);

            // BARDZO WA¯NE I PROSTE

        }

        private void bt_zigzag_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);

            Node x = tree.Search(value);

            if(x != null && x.parent != null && x.parent.parent != null)
            {
                Node p = x.parent;
                Node g = p.parent;

                bool pIsLeft = (g.left == p);
                bool xIsLeft = (p.left == x);

                if(pIsLeft && !xIsLeft)
                {
                    tree.Zag(x, p);
                    tree.Zig(x, g);
                    Refresh();
                }

                else
                {
                    tree.Zig(x, p);
                    tree.Zag(x, g);
                    Refresh();
                }
            }
        }
    }
}
