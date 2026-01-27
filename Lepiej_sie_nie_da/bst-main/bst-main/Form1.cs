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

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);
            tree.Delete(value);
            Refresh();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);

            Node n = tree.Search(value);

            if (n != null)
            {
                lbl_out.Text = $"Znaleziono: {n.value}.";
            }
            else
            {
                lbl_out.Text = $"Nie znaleziono takiego elementu w drzewie.";
            }

            Refresh();
        }

        private void bt_wszerz_Click(object sender, EventArgs e)
        {
            List<int> values = tree.Wszerz();

            if (values.Count > 0)
            {
                lbl_out.Text = String.Join(", ", values);
            }
            else
            {
                lbl_out.Text = $"Drzewo jest puste";
            }
            Refresh();
        }

        private void bt_preorder_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            PreOrder(tree.root, list);
            lbl_out.Text = String.Join(", ", list);
            Refresh();
        }

        private void PreOrder(Node node, List<int> list)
        {
            list.Add(node.value);
            if (node.left != null)
            {
                PreOrder(node.left, list);
            }
            if (node.right != null)
            {
                PreOrder(node.right, list);
            }
        }

        private void bt_inorder_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            InOrder(tree.root, list);
            lbl_out.Text = String.Join(", ", list);
            Refresh();
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

        private void bt_postorder_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            PostOrder(tree.root, list);
            lbl_out.Text = String.Join(", ", list);
            Refresh();
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

        private void bt_ZigZig_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);

            Node x = tree.Search(value);

            if (x.parent.parent != null && x.parent.left == x && x.parent.parent.left == x.parent)
            {
                Node y = x.parent;
                Node z = y.parent;
                tree.Zig(y, z);
                tree.Zig(x, y);
            }
            Refresh();
        }

        private void bt_ZagZag_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);

            Node x = tree.Search(value);

            if (x.parent.parent != null && x.parent.right == x && x.parent.parent.right == x.parent)
            {
                Node y = x.parent;
                Node z = y.parent;
                tree.Zag(y, z);
                tree.Zag(x, y);
            }
            Refresh();
        }

        private void bt_ZigZag_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);

            Node x = tree.Search(value);

            if (x.parent.parent != null && x.parent.right == x && x.parent.parent.left == x.parent)
            {
                Node y = x.parent;
                Node z = y.parent;
                tree.Zag(x, y);
                tree.Zig(x, z);
            }
            Refresh();
        }

        private void bt_ZagZig_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_insert.Text);

            Node x = tree.Search(value);

            if(x.parent.parent != null && x.parent.left == x && x.parent.parent.right == x.parent)
            {
                Node y = x.parent;
                Node z = y.parent;
                tree.Zig(x, y);
                tree.Zag(x, z);
            }
            Refresh();
        }
    }
}
