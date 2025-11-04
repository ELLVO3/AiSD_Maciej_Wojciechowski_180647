namespace linkedList
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
            this.lb_linkedList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_roll
            // 
            this.bt_roll.Location = new System.Drawing.Point(713, 377);
            this.bt_roll.Name = "bt_roll";
            this.bt_roll.Size = new System.Drawing.Size(75, 23);
            this.bt_roll.TabIndex = 0;
            this.bt_roll.Text = "Losuj";
            this.bt_roll.UseVisualStyleBackColor = true;
            this.bt_roll.Click += new System.EventHandler(this.bt_roll_Click);
            // 
            // lb_linkedList
            // 
            this.lb_linkedList.AutoSize = true;
            this.lb_linkedList.Location = new System.Drawing.Point(354, 19);
            this.lb_linkedList.Name = "lb_linkedList";
            this.lb_linkedList.Size = new System.Drawing.Size(63, 15);
            this.lb_linkedList.TabIndex = 1;
            this.lb_linkedList.Text = "Linked List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_linkedList);
            this.Controls.Add(this.bt_roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_roll;
        private Label lb_linkedList;
    }
}