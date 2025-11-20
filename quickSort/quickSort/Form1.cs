namespace quickSort
{
    public partial class Form1 : Form
    {
        int[] tab = new int[10];
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public void quickSort(int[] tab, int low, int high)
        {
            if (low < high)
            {
                int pivot_location = partition(tab, low, high);

                quickSort(tab, low, pivot_location - 1);
                quickSort(tab, pivot_location + 1, high);
            }
        }

        public int partition(int[] tab, int low, int high)
        {
            int pivot = tab[low];
            int left_wall = low;

            for (int i = low + 1; i <= high; i++)
            {
                if (tab[i] < pivot)
                {
                    left_wall++;

                    int temp = tab[i];
                    tab[i] = tab[left_wall];
                    tab[left_wall] = temp;
                }
            }
            int temp2 = tab[low];
            tab[low] = tab[left_wall];
            tab[left_wall] = temp2;

            return left_wall;
        }

        private void bt_roll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                tab[i] = r.Next(0, 100);
            }

            lbl_nsorted.Text = "Nieposortowana tablica: " + String.Join(", ", tab);

            bt_sort.Visible = true;

            lbl_sorted.Text = " ";
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            lbl_sorted.Visible = true;

            quickSort(tab, 0, tab.Length - 1);

            lbl_sorted.Text = "Posortowana tablica: " + String.Join(", ", tab);
        }
    }
}
