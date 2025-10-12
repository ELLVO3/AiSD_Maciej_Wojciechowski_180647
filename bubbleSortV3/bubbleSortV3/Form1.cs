using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bubbleSortV3
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int[] tab = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_roll_Click(object sender, EventArgs e)
        {
            //tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(0, 100);
            }

            lbl_nsorted.Text = "Tablica przed sortowaniem: " + string.Join(", ", tab);

            lbl_sorted.Text = "";

            bt_sort.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tab = new int[10];
            bool change = true;

            while (change)
            {
                int i = 0;
                change = false;
                while (i < tab.Length - 1)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        change = true;
                    }
                    i++;
                }
            }

            lbl_sorted.Visible = true;

            lbl_sorted.Text = "Tablica po sortowaniu: " + string.Join(", ", tab);
        }
    }
}
