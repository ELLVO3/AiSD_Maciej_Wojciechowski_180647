namespace twoSortsInsertPlusSelect
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
            this.bt_roll = new System.Windows.Forms.Button();
            this.sortowaniePrzezWstawianie = new System.Windows.Forms.Button();
            this.sortowaniePrzezWybieranie = new System.Windows.Forms.Button();
            this.lbl_nsorted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_roll
            // 
            this.bt_roll.Location = new System.Drawing.Point(713, 342);
            this.bt_roll.Name = "bt_roll";
            this.bt_roll.Size = new System.Drawing.Size(75, 23);
            this.bt_roll.TabIndex = 0;
            this.bt_roll.Text = "Generuj";
            this.bt_roll.UseVisualStyleBackColor = true;
            this.bt_roll.Click += new System.EventHandler(this.bt_roll_Click);
            // 
            // sortowaniePrzezWstawianie
            // 
            this.sortowaniePrzezWstawianie.Location = new System.Drawing.Point(713, 371);
            this.sortowaniePrzezWstawianie.Name = "sortowaniePrzezWstawianie";
            this.sortowaniePrzezWstawianie.Size = new System.Drawing.Size(75, 23);
            this.sortowaniePrzezWstawianie.TabIndex = 1;
            this.sortowaniePrzezWstawianie.Text = "Insert";
            this.sortowaniePrzezWstawianie.UseVisualStyleBackColor = true;
            this.sortowaniePrzezWstawianie.Visible = false;
            this.sortowaniePrzezWstawianie.Click += new System.EventHandler(this.sortowaniePrzezWstawianie_Click);
            // 
            // sortowaniePrzezWybieranie
            // 
            this.sortowaniePrzezWybieranie.Location = new System.Drawing.Point(713, 400);
            this.sortowaniePrzezWybieranie.Name = "sortowaniePrzezWybieranie";
            this.sortowaniePrzezWybieranie.Size = new System.Drawing.Size(75, 23);
            this.sortowaniePrzezWybieranie.TabIndex = 2;
            this.sortowaniePrzezWybieranie.Text = "Select";
            this.sortowaniePrzezWybieranie.UseVisualStyleBackColor = true;
            this.sortowaniePrzezWybieranie.Visible = false;
            this.sortowaniePrzezWybieranie.Click += new System.EventHandler(this.sortowaniePrzezWybieranie_Click);
            // 
            // lbl_nsorted
            // 
            this.lbl_nsorted.AutoSize = true;
            this.lbl_nsorted.Location = new System.Drawing.Point(214, 43);
            this.lbl_nsorted.Name = "lbl_nsorted";
            this.lbl_nsorted.Size = new System.Drawing.Size(135, 15);
            this.lbl_nsorted.TabIndex = 3;
            this.lbl_nsorted.Text = "Nieposortowana tablica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = " ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nsorted);
            this.Controls.Add(this.sortowaniePrzezWybieranie);
            this.Controls.Add(this.sortowaniePrzezWstawianie);
            this.Controls.Add(this.bt_roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_roll;
        private Button sortowaniePrzezWstawianie;
        private Button sortowaniePrzezWybieranie;
        private Label lbl_nsorted;
        private Label label2;
    }
}