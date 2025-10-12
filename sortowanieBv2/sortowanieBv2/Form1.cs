using System.Threading.Tasks.Dataflow;

namespace sortowanieBv2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(0, 100);
            }

            lbl_nsorted.Text = "Tablica przed sortowaniem: " + string.Join(", ", tab);

            int n = tab.Length;
            bool change = true;
            while (change)
            {
                int i = 0;
                change = false;
                while (i < (tab.Length) - 1)
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
                n--;
            }
            lbl_sorted.Text = "Tablica posortowana: " + string.Join(", ", tab);
        }

        private void lbl_nsorted_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_sorted_Click(object sender, EventArgs e)
        {

        }
    }
}
