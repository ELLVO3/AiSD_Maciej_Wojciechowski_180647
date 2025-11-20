namespace quickSort
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
            lbl_quickSort = new Label();
            lbl_nsorted = new Label();
            lbl_sorted = new Label();
            bt_roll = new Button();
            bt_sort = new Button();
            SuspendLayout();
            // 
            // lbl_quickSort
            // 
            lbl_quickSort.AutoSize = true;
            lbl_quickSort.Location = new Point(321, 36);
            lbl_quickSort.Name = "lbl_quickSort";
            lbl_quickSort.Size = new Size(80, 20);
            lbl_quickSort.TabIndex = 0;
            lbl_quickSort.Text = "Quick Sort:";
            // 
            // lbl_nsorted
            // 
            lbl_nsorted.AutoSize = true;
            lbl_nsorted.Location = new Point(175, 95);
            lbl_nsorted.Name = "lbl_nsorted";
            lbl_nsorted.Size = new Size(171, 20);
            lbl_nsorted.TabIndex = 1;
            lbl_nsorted.Text = "Nieposortowana tablica:";
            // 
            // lbl_sorted
            // 
            lbl_sorted.AutoSize = true;
            lbl_sorted.Location = new Point(175, 141);
            lbl_sorted.Name = "lbl_sorted";
            lbl_sorted.Size = new Size(147, 20);
            lbl_sorted.TabIndex = 2;
            lbl_sorted.Text = "Posortowana Tablica:";
            // 
            // bt_roll
            // 
            bt_roll.Location = new Point(694, 369);
            bt_roll.Name = "bt_roll";
            bt_roll.Size = new Size(94, 29);
            bt_roll.TabIndex = 3;
            bt_roll.Text = "Generuj";
            bt_roll.UseVisualStyleBackColor = true;
            bt_roll.Click += bt_roll_Click;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(694, 409);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(94, 29);
            bt_sort.TabIndex = 4;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Visible = false;
            bt_sort.Click += bt_sort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_sort);
            Controls.Add(bt_roll);
            Controls.Add(lbl_sorted);
            Controls.Add(lbl_nsorted);
            Controls.Add(lbl_quickSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_quickSort;
        private Label lbl_nsorted;
        private Label lbl_sorted;
        private Button bt_roll;
        private Button bt_sort;
    }
}
