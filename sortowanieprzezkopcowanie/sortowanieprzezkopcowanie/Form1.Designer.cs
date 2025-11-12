namespace sortowanieprzezkopcowanie
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
            lbl_sortName = new Label();
            bt_roll = new Button();
            bt_sort = new Button();
            lbl_nsorted = new Label();
            lbl_sorted = new Label();
            SuspendLayout();
            // 
            // lbl_sortName
            // 
            lbl_sortName.AutoSize = true;
            lbl_sortName.Location = new Point(556, 26);
            lbl_sortName.Name = "lbl_sortName";
            lbl_sortName.Size = new Size(211, 20);
            lbl_sortName.TabIndex = 0;
            lbl_sortName.Text = "Sortowanie przez kopcowanie:";
            // 
            // bt_roll
            // 
            bt_roll.Location = new Point(1242, 396);
            bt_roll.Name = "bt_roll";
            bt_roll.Size = new Size(94, 29);
            bt_roll.TabIndex = 1;
            bt_roll.Text = "Losuj";
            bt_roll.UseVisualStyleBackColor = true;
            bt_roll.Click += bt_roll_Click;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(1242, 443);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(94, 29);
            bt_sort.TabIndex = 2;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Visible = false;
            bt_sort.Click += bt_sort_Click;
            // 
            // lbl_nsorted
            // 
            lbl_nsorted.AutoSize = true;
            lbl_nsorted.Location = new Point(466, 68);
            lbl_nsorted.Name = "lbl_nsorted";
            lbl_nsorted.Size = new Size(0, 20);
            lbl_nsorted.TabIndex = 3;
            // 
            // lbl_sorted
            // 
            lbl_sorted.AutoSize = true;
            lbl_sorted.Location = new Point(466, 131);
            lbl_sorted.Name = "lbl_sorted";
            lbl_sorted.Size = new Size(0, 20);
            lbl_sorted.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 484);
            Controls.Add(lbl_sorted);
            Controls.Add(lbl_nsorted);
            Controls.Add(bt_sort);
            Controls.Add(bt_roll);
            Controls.Add(lbl_sortName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sortName;
        private Button bt_roll;
        private Button bt_sort;
        private Label lbl_nsorted;
        private Label lbl_sorted;
    }
}
