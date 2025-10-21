namespace mergesort_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SC(List<int> T, int l, int p)
        {
            if(l < p)
            {
                int s = (l + p) / 2;
                SC(T, l, s);
                SC(T, s + 1, p);
                SCAL(T, l, s, p);
            }
        }

        private void SCAL(List<int> t, int l, int s, int p)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            var T = new List<int>() { 38, 27, 43, 3, 9, 82, 10 };
            SC(T, 0, T.Count - 1);
        }
    }
}