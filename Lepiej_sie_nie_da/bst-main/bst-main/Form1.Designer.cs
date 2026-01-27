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
            text_insert = new TextBox();
            bt_delete = new Button();
            bt_search = new Button();
            lbl_out = new Label();
            bt_wszerz = new Button();
            bt_preorder = new Button();
            bt_inorder = new Button();
            bt_postorder = new Button();
            bt_ZigZig = new Button();
            bt_ZagZag = new Button();
            bt_ZigZag = new Button();
            bt_ZagZig = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 498);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(808, 49);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(94, 29);
            bt_add.TabIndex = 1;
            bt_add.Text = "Dodaj";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // text_insert
            // 
            text_insert.Location = new Point(777, 16);
            text_insert.Name = "text_insert";
            text_insert.Size = new Size(125, 27);
            text_insert.TabIndex = 2;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(808, 84);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(94, 29);
            bt_delete.TabIndex = 3;
            bt_delete.Text = "Usuń";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(808, 119);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(94, 29);
            bt_search.TabIndex = 4;
            bt_search.Text = "Wyszukaj";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // lbl_out
            // 
            lbl_out.AutoSize = true;
            lbl_out.Location = new Point(12, 571);
            lbl_out.Name = "lbl_out";
            lbl_out.Size = new Size(101, 20);
            lbl_out.TabIndex = 5;
            lbl_out.Text = "Wypisywajka: ";
            // 
            // bt_wszerz
            // 
            bt_wszerz.Location = new Point(808, 154);
            bt_wszerz.Name = "bt_wszerz";
            bt_wszerz.Size = new Size(94, 29);
            bt_wszerz.TabIndex = 6;
            bt_wszerz.Text = "Wszerz";
            bt_wszerz.UseVisualStyleBackColor = true;
            bt_wszerz.Click += bt_wszerz_Click;
            // 
            // bt_preorder
            // 
            bt_preorder.Location = new Point(808, 189);
            bt_preorder.Name = "bt_preorder";
            bt_preorder.Size = new Size(94, 29);
            bt_preorder.TabIndex = 7;
            bt_preorder.Text = "Pre-Order";
            bt_preorder.UseVisualStyleBackColor = true;
            bt_preorder.Click += bt_preorder_Click;
            // 
            // bt_inorder
            // 
            bt_inorder.Location = new Point(808, 224);
            bt_inorder.Name = "bt_inorder";
            bt_inorder.Size = new Size(94, 29);
            bt_inorder.TabIndex = 8;
            bt_inorder.Text = "In-Order";
            bt_inorder.UseVisualStyleBackColor = true;
            bt_inorder.Click += bt_inorder_Click;
            // 
            // bt_postorder
            // 
            bt_postorder.Location = new Point(808, 259);
            bt_postorder.Name = "bt_postorder";
            bt_postorder.Size = new Size(94, 29);
            bt_postorder.TabIndex = 9;
            bt_postorder.Text = "Post-Order";
            bt_postorder.UseVisualStyleBackColor = true;
            bt_postorder.Click += bt_postorder_Click;
            // 
            // bt_ZigZig
            // 
            bt_ZigZig.Location = new Point(808, 294);
            bt_ZigZig.Name = "bt_ZigZig";
            bt_ZigZig.Size = new Size(94, 29);
            bt_ZigZig.TabIndex = 10;
            bt_ZigZig.Text = "Zig-Zig";
            bt_ZigZig.UseVisualStyleBackColor = true;
            bt_ZigZig.Click += bt_ZigZig_Click;
            // 
            // bt_ZagZag
            // 
            bt_ZagZag.Location = new Point(808, 329);
            bt_ZagZag.Name = "bt_ZagZag";
            bt_ZagZag.Size = new Size(94, 29);
            bt_ZagZag.TabIndex = 11;
            bt_ZagZag.Text = "Zag-Zag";
            bt_ZagZag.UseVisualStyleBackColor = true;
            bt_ZagZag.Click += bt_ZagZag_Click;
            // 
            // bt_ZigZag
            // 
            bt_ZigZag.Location = new Point(808, 364);
            bt_ZigZag.Name = "bt_ZigZag";
            bt_ZigZag.Size = new Size(94, 29);
            bt_ZigZag.TabIndex = 12;
            bt_ZigZag.Text = "Zig-Zag";
            bt_ZigZag.UseVisualStyleBackColor = true;
            bt_ZigZag.Click += bt_ZigZag_Click;
            // 
            // bt_ZagZig
            // 
            bt_ZagZig.Location = new Point(808, 399);
            bt_ZagZig.Name = "bt_ZagZig";
            bt_ZagZig.Size = new Size(94, 29);
            bt_ZagZig.TabIndex = 13;
            bt_ZagZig.Text = "Zag-Zig";
            bt_ZagZig.UseVisualStyleBackColor = true;
            bt_ZagZig.Click += bt_ZagZig_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(bt_ZagZig);
            Controls.Add(bt_ZigZag);
            Controls.Add(bt_ZagZag);
            Controls.Add(bt_ZigZig);
            Controls.Add(bt_postorder);
            Controls.Add(bt_inorder);
            Controls.Add(bt_preorder);
            Controls.Add(bt_wszerz);
            Controls.Add(lbl_out);
            Controls.Add(bt_search);
            Controls.Add(bt_delete);
            Controls.Add(text_insert);
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
        private TextBox text_insert;
        private Button bt_delete;
        private Button bt_search;
        private Label lbl_out;
        private Button bt_wszerz;
        private Button bt_preorder;
        private Button bt_inorder;
        private Button bt_postorder;
        private Button bt_ZigZig;
        private Button bt_ZagZag;
        private Button bt_ZigZag;
        private Button bt_ZagZig;
    }
}
