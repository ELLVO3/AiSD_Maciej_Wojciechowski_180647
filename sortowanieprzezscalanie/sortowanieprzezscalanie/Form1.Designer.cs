namespace sortowanieprzezscalanie
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
            bt_roll = new Button();
            bt_sort = new Button();
            lbl_merge_sort_txt = new Label();
            lbl_nsorted = new Label();
            lbl_sorted = new Label();
            SuspendLayout();
            // 
            // bt_roll
            // 
            bt_roll.Location = new Point(694, 374);
            bt_roll.Name = "bt_roll";
            bt_roll.Size = new Size(94, 29);
            bt_roll.TabIndex = 0;
            bt_roll.Text = "Losuj";
            bt_roll.UseVisualStyleBackColor = true;
            bt_roll.Click += bt_roll_Click;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(694, 409);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(94, 29);
            bt_sort.TabIndex = 1;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Visible = false;
            bt_sort.Click += bt_sort_Click;
            // 
            // lbl_merge_sort_txt
            // 
            lbl_merge_sort_txt.AutoSize = true;
            lbl_merge_sort_txt.Location = new Point(299, 9);
            lbl_merge_sort_txt.Name = "lbl_merge_sort_txt";
            lbl_merge_sort_txt.Size = new Size(181, 20);
            lbl_merge_sort_txt.TabIndex = 2;
            lbl_merge_sort_txt.Text = "Sortowanie przez scalanie";
            // 
            // lbl_nsorted
            // 
            lbl_nsorted.AutoSize = true;
            lbl_nsorted.Location = new Point(154, 53);
            lbl_nsorted.Name = "lbl_nsorted";
            lbl_nsorted.Size = new Size(153, 20);
            lbl_nsorted.TabIndex = 3;
            lbl_nsorted.Text = "Nieposortowana lista:";
            // 
            // lbl_sorted
            // 
            lbl_sorted.AutoSize = true;
            lbl_sorted.Location = new Point(168, 94);
            lbl_sorted.Name = "lbl_sorted";
            lbl_sorted.Size = new Size(128, 20);
            lbl_sorted.TabIndex = 4;
            lbl_sorted.Text = "Posortowana lista:";
            lbl_sorted.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_sorted);
            Controls.Add(lbl_nsorted);
            Controls.Add(lbl_merge_sort_txt);
            Controls.Add(bt_sort);
            Controls.Add(bt_roll);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_roll;
        private Button bt_sort;
        private Label lbl_merge_sort_txt;
        private Label lbl_nsorted;
        private Label lbl_sorted;
    }
}
