namespace bubbleSortV3
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
            lbl_nsorted = new Label();
            lbl_sorted = new Label();
            SuspendLayout();
            // 
            // bt_roll
            // 
            bt_roll.BackColor = SystemColors.ActiveCaption;
            bt_roll.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_roll.ForeColor = SystemColors.Info;
            bt_roll.Location = new Point(713, 352);
            bt_roll.Name = "bt_roll";
            bt_roll.Size = new Size(75, 40);
            bt_roll.TabIndex = 0;
            bt_roll.Text = "Losuj";
            bt_roll.UseVisualStyleBackColor = false;
            bt_roll.Click += bt_roll_Click;
            // 
            // bt_sort
            // 
            bt_sort.BackColor = SystemColors.ActiveCaption;
            bt_sort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_sort.ForeColor = SystemColors.Info;
            bt_sort.Location = new Point(713, 398);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(75, 40);
            bt_sort.TabIndex = 1;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = false;
            bt_sort.Visible = false;
            bt_sort.Click += button1_Click;
            // 
            // lbl_nsorted
            // 
            lbl_nsorted.AutoSize = true;
            lbl_nsorted.BackColor = SystemColors.ButtonFace;
            lbl_nsorted.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_nsorted.Location = new Point(12, 33);
            lbl_nsorted.Name = "lbl_nsorted";
            lbl_nsorted.Size = new Size(181, 30);
            lbl_nsorted.TabIndex = 2;
            lbl_nsorted.Text = "Nieposortowana:";
            // 
            // lbl_sorted
            // 
            lbl_sorted.AutoSize = true;
            lbl_sorted.BackColor = SystemColors.ButtonFace;
            lbl_sorted.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_sorted.Location = new Point(14, 74);
            lbl_sorted.Name = "lbl_sorted";
            lbl_sorted.Size = new Size(147, 30);
            lbl_sorted.TabIndex = 3;
            lbl_sorted.Text = "Posortowana:";
            lbl_sorted.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_sorted);
            Controls.Add(lbl_nsorted);
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
        private Label lbl_nsorted;
        private Label lbl_sorted;
    }
}
