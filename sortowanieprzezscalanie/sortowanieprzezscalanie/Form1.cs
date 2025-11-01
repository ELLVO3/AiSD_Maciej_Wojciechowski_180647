using System.Globalization;

namespace sortowanieprzezscalanie
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void MergeSort(List<int> T, int L, int R)
        {
            if (L < R)
            {
                int M = (L + R) / 2;
                MergeSort(T, L, M);
                MergeSort(T, M + 1, R);
                Merge(T, L, M, R);
            }
        }

        private void Merge(List<int> T, int L, int M, int R)
        {
            List<int> temp = new List<int>();

            int i = L;
            int j = M + 1;

            while (i <= M && j <= R)
            {
                if (T[i] < T[j])
                {
                    temp.Add(T[i]);
                    i++;
                }

                else
                {
                    temp.Add(T[j]);
                    j++;
                }
            }

            while (i <= M)
            {
                temp.Add(T[i]);
                i++;
            }

            while (j <= R)
            {
                temp.Add(T[j]);
                j++;
            }

            for (int k = 0; k < temp.Count; k++)
            {
                T[L + k] = temp[k];
            }
        }

        private void bt_roll_Click(object sender, EventArgs e)
        {
            numbers.Clear();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(r.Next(0, 100));
            }

            lbl_nsorted.Text = "Lista przed sortowaniem: " + string.Join(", ", numbers);

            lbl_sorted.Text = " ";

            bt_sort.Visible = true;
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            MergeSort(numbers, 0, numbers.Count - 1);

            lbl_sorted.Visible = true;

            lbl_sorted.Text = "Posortowana lista: " + string.Join(", ", numbers);
        }
    }
}
