namespace sortowanieBv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nsorted = new Label();
            lbl_sorted = new Label();
            btn_sort = new Button();
            SuspendLayout();
            // 
            // lbl_nsorted
            // 
            lbl_nsorted.AutoSize = true;
            lbl_nsorted.Location = new Point(192, 113);
            lbl_nsorted.Name = "lbl_nsorted";
            lbl_nsorted.Size = new Size(184, 15);
            lbl_nsorted.TabIndex = 0;
            lbl_nsorted.Text = "Tu będzie tablica nieposortowana";
            lbl_nsorted.Click += lbl_nsorted_Click;
            // 
            // lbl_sorted
            // 
            lbl_sorted.AutoSize = true;
            lbl_sorted.Location = new Point(192, 159);
            lbl_sorted.Name = "lbl_sorted";
            lbl_sorted.Size = new Size(114, 15);
            lbl_sorted.TabIndex = 1;
            lbl_sorted.Text = "A tutaj posortowana";
            lbl_sorted.Click += lbl_sorted_Click;
            // 
            // btn_sort
            // 
            btn_sort.Location = new Point(713, 415);
            btn_sort.Name = "btn_sort";
            btn_sort.Size = new Size(75, 23);
            btn_sort.TabIndex = 2;
            btn_sort.Text = "Sortuj";
            btn_sort.UseVisualStyleBackColor = true;
            btn_sort.Click += btn_sort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_sort);
            Controls.Add(lbl_sorted);
            Controls.Add(lbl_nsorted);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nsorted;
        private Label lbl_sorted;
        private Button btn_sort;
    }
}
