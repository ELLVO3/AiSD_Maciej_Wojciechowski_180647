using System.Windows.Forms.VisualStyles;

namespace BST
{
    public partial class Form1 : Form
    {
        Tree drzewo = new Tree();
        public Form1()
        {
            InitializeComponent();
        }

        private TreeNode BuildTreeNode(Wezel wezelDrzewa)
        {
            if (wezelDrzewa == null)
            {
                return null;
            }

            TreeNode treeNode = new TreeNode(wezelDrzewa.ToString());

            TreeNode leftChild = BuildTreeNode(wezelDrzewa.left);
            if (leftChild != null)
            {
                treeNode.Nodes.Add(leftChild);
            }

            TreeNode rightChild = BuildTreeNode(wezelDrzewa.right);
            if (rightChild != null)
            {
                treeNode.Nodes.Add(rightChild);
            }

            return treeNode;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_insert.Text, out int value))
            {
                drzewo.addValue(value);

                tree_show.BeginUpdate();
                tree_show.Nodes.Clear();

                if (drzewo.root != null)
                {
                    TreeNode rootNode = BuildTreeNode(drzewo.root);
                    tree_show.Nodes.Add(rootNode);
                    rootNode.ExpandAll();
                }

                tree_show.EndUpdate();
            }
            else
            {
                MessageBox.Show("Proszê wprowadziæ poprawn¹ liczbê ca³kowit¹.");
            }

        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            int[] tab = new int[drzewo.counter];

            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = drzewo.returnValue();
            }

            lbl_result.Text = "Posortowane wartoœci w tablicy: " + String.Join(", ", tab);

            lbl_result.Visible = true;

        }
    }
}
