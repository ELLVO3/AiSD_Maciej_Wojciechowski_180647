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
            int value = int.Parse(text_input.Text);
            tree.Add(value);
            Refresh();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_input.Text);
            tree.Delete(value);
            Refresh();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int value = int.Parse(text_input.Text);

            Node x = tree.Search(value);

            tree.ZigZag(x);
            Refresh();

        }

        private void bt_inorder_Click(object sender, EventArgs e)
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

        private void bt_preorder_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            PreOrder(tree.root, list);

            lbl_out.Text = String.Join(", ", list);
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

        private void bt_postorder_Click(object sender, EventArgs e)
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
            if(node == null)
            {
                return 0;
            }

            return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
        }

        private void PrintCurrentLevel(Node node, int level, List<int> list)
        {
            if(node == null)
            {
                return;
            }

            if(level == 1)
            {
                list.Add(node.value);
            }

            else if(level > 1)
            {
                PrintCurrentLevel(node.left, level - 1, list);
                PrintCurrentLevel(node.right, level - 1, list);
            }
        }

        private void Wszerz(List<int> list)
        {
            int h = GetHeight(tree.root);

            for(int i = 1; i <= h; i++)
            {
                PrintCurrentLevel(tree.root, i, list);
            }
        }
    }
}
