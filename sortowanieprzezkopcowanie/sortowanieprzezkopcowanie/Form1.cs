namespace sortowanieprzezkopcowanie
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        void Heapify(List<int> A, int n, int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            int largest = i;

            if(left < n && A[left] > A[largest])
            {
                largest = left;
            }

            if (right < n && A[right] > A[largest])
            {
                largest = right;
            }

            if (largest != i) 
            {
                int temp = A[i];
                A[i] = A[largest];
                A[largest] = temp;

                Heapify(A, n, largest);
            }
        }

        void BuildMaxHeap(List<int> A)
        {
            int n = A.Count;
            for (int i = (n / 2) - 1; i >= 0; i--) 
            {
                Heapify(A, n, i);
            }
        }

        void HeapSort(List<int> A)
        {
            BuildMaxHeap(A);
            int n = A.Count;
            for(int i = n - 1; i > 0; i--) 
            {
                int temp = A[0];
                A[0] = A[i];
                A[i] = temp;

                Heapify(A, i, 0);
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
            lbl_sorted.Visible = true;

            HeapSort(numbers);

            lbl_sorted.Text = "Lista po sortowaniu: " + string.Join(", ", numbers);
        }
    }
}
