namespace Kolo
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
            pictureBox1 = new PictureBox();
            bt_add = new Button();
            text_input = new TextBox();
            bt_delete = new Button();
            bt_search = new Button();
            bt_inorder = new Button();
            lbl_out = new Label();
            bt_preorder = new Button();
            bt_postorder = new Button();
            bt_wszerz = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(746, 526);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(808, 81);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(94, 29);
            bt_add.TabIndex = 1;
            bt_add.Text = "Dodaj";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // text_input
            // 
            text_input.Location = new Point(777, 28);
            text_input.Name = "text_input";
            text_input.Size = new Size(125, 27);
            text_input.TabIndex = 2;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(808, 116);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(94, 29);
            bt_delete.TabIndex = 3;
            bt_delete.Text = "Usuń";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(808, 151);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(94, 29);
            bt_search.TabIndex = 4;
            bt_search.Text = "Szukaj";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // bt_inorder
            // 
            bt_inorder.Location = new Point(808, 186);
            bt_inorder.Name = "bt_inorder";
            bt_inorder.Size = new Size(94, 29);
            bt_inorder.TabIndex = 5;
            bt_inorder.Text = "In-Order";
            bt_inorder.UseVisualStyleBackColor = true;
            bt_inorder.Click += bt_inorder_Click;
            // 
            // lbl_out
            // 
            lbl_out.AutoSize = true;
            lbl_out.Location = new Point(12, 546);
            lbl_out.Name = "lbl_out";
            lbl_out.Size = new Size(62, 20);
            lbl_out.TabIndex = 6;
            lbl_out.Text = "Output: ";
            // 
            // bt_preorder
            // 
            bt_preorder.Location = new Point(808, 221);
            bt_preorder.Name = "bt_preorder";
            bt_preorder.Size = new Size(94, 29);
            bt_preorder.TabIndex = 7;
            bt_preorder.Text = "Pre-Order";
            bt_preorder.UseVisualStyleBackColor = true;
            bt_preorder.Click += bt_preorder_Click;
            // 
            // bt_postorder
            // 
            bt_postorder.Location = new Point(808, 256);
            bt_postorder.Name = "bt_postorder";
            bt_postorder.Size = new Size(94, 29);
            bt_postorder.TabIndex = 8;
            bt_postorder.Text = "Post-Order";
            bt_postorder.UseVisualStyleBackColor = true;
            bt_postorder.Click += bt_postorder_Click;
            // 
            // bt_wszerz
            // 
            bt_wszerz.Location = new Point(808, 291);
            bt_wszerz.Name = "bt_wszerz";
            bt_wszerz.Size = new Size(94, 29);
            bt_wszerz.TabIndex = 9;
            bt_wszerz.Text = "Wszerz";
            bt_wszerz.UseVisualStyleBackColor = true;
            bt_wszerz.Click += bt_wszerz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(bt_wszerz);
            Controls.Add(bt_postorder);
            Controls.Add(bt_preorder);
            Controls.Add(lbl_out);
            Controls.Add(bt_inorder);
            Controls.Add(bt_search);
            Controls.Add(bt_delete);
            Controls.Add(text_input);
            Controls.Add(bt_add);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_add;
        private TextBox text_input;
        private Button bt_delete;
        private Button bt_search;
        private Button bt_inorder;
        private Label lbl_out;
        private Button bt_preorder;
        private Button bt_postorder;
        private Button bt_wszerz;
    }
}
