namespace twoSortsInsertPlusSelect
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int[] tab = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void insertSort(int[] tab)
        {
            int i = 1;
            while(i < tab.Length)
            {
                int j = i;
                while(j > 0 && tab[j-1] > tab[j])
                {
                    int temp = tab[j];
                    tab[j] = tab[j - 1];
                    tab[j - 1] = temp;
                    j--;
                }
                i++;
            }
        }

        private void selectSort(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                int minVal = i;
                for(int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[minVal])
                    {
                        minVal = j;
                    }
                }
                int temp = tab[i];
                tab[i] = tab[minVal];
                tab[minVal] = temp;
            }
        }

        private void bt_roll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                tab[i] = r.Next(0, 100);
            }

            lbl_nsorted.Text = "Nieposortowana tablica: " + String.Join(", ", tab);

            label2.Text = " ";

            sortowaniePrzezWstawianie.Visible = true;

            sortowaniePrzezWybieranie.Visible = true;
        }

        private void sortowaniePrzezWstawianie_Click(object sender, EventArgs e)
        {
            insertSort(tab);

            label2.Visible = true;

            label2.Text = "Posortowana tablica: " + String.Join(", ", tab);

        }

        private void sortowaniePrzezWybieranie_Click(object sender, EventArgs e)
        {
            selectSort(tab);

            label2.Visible = true;

            label2.Text = "Posortowana tablica: " + String.Join(", ", tab);

            // to do: zrób quick sort :)
        }
    }
}