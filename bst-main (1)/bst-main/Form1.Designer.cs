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
            bt_del = new Button();
            lbl_out = new Label();
            bt_pre = new Button();
            bt_in = new Button();
            bt_post = new Button();
            bt_wszerz = new Button();
            bt_wypisz = new Button();
            bt_zigzag = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(732, 522);
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
            // bt_del
            // 
            bt_del.Location = new Point(808, 84);
            bt_del.Name = "bt_del";
            bt_del.Size = new Size(94, 29);
            bt_del.TabIndex = 3;
            bt_del.Text = "Usuń";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += bt_del_Click;
            // 
            // lbl_out
            // 
            lbl_out.AutoSize = true;
            lbl_out.Location = new Point(14, 560);
            lbl_out.Name = "lbl_out";
            lbl_out.Size = new Size(101, 20);
            lbl_out.TabIndex = 4;
            lbl_out.Text = "Wypisywajka: ";
            // 
            // bt_pre
            // 
            bt_pre.Location = new Point(808, 119);
            bt_pre.Name = "bt_pre";
            bt_pre.Size = new Size(94, 29);
            bt_pre.TabIndex = 5;
            bt_pre.Text = "Pre-Order";
            bt_pre.UseVisualStyleBackColor = true;
            bt_pre.Click += bt_pre_Click;
            // 
            // bt_in
            // 
            bt_in.Location = new Point(808, 154);
            bt_in.Name = "bt_in";
            bt_in.Size = new Size(94, 29);
            bt_in.TabIndex = 6;
            bt_in.Text = "In-Order";
            bt_in.UseVisualStyleBackColor = true;
            bt_in.Click += bt_in_Click;
            // 
            // bt_post
            // 
            bt_post.Location = new Point(808, 189);
            bt_post.Name = "bt_post";
            bt_post.Size = new Size(94, 29);
            bt_post.TabIndex = 7;
            bt_post.Text = "Post-Order";
            bt_post.UseVisualStyleBackColor = true;
            bt_post.Click += bt_post_Click;
            // 
            // bt_wszerz
            // 
            bt_wszerz.Location = new Point(808, 224);
            bt_wszerz.Name = "bt_wszerz";
            bt_wszerz.Size = new Size(94, 29);
            bt_wszerz.TabIndex = 8;
            bt_wszerz.Text = "Wszerz";
            bt_wszerz.UseVisualStyleBackColor = true;
            bt_wszerz.Click += bt_wszerz_Click;
            // 
            // bt_wypisz
            // 
            bt_wypisz.Location = new Point(808, 259);
            bt_wypisz.Name = "bt_wypisz";
            bt_wypisz.Size = new Size(94, 29);
            bt_wypisz.TabIndex = 9;
            bt_wypisz.Text = "Wypisz";
            bt_wypisz.UseVisualStyleBackColor = true;
            bt_wypisz.Click += bt_wypisz_Click;
            // 
            // bt_zigzag
            // 
            bt_zigzag.Location = new Point(808, 294);
            bt_zigzag.Name = "bt_zigzag";
            bt_zigzag.Size = new Size(94, 29);
            bt_zigzag.TabIndex = 10;
            bt_zigzag.Text = "Zig-Zag";
            bt_zigzag.UseVisualStyleBackColor = true;
            bt_zigzag.Click += bt_zigzag_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(bt_zigzag);
            Controls.Add(bt_wypisz);
            Controls.Add(bt_wszerz);
            Controls.Add(bt_post);
            Controls.Add(bt_in);
            Controls.Add(bt_pre);
            Controls.Add(lbl_out);
            Controls.Add(bt_del);
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
        private Button bt_del;
        private Label lbl_out;
        private Button bt_pre;
        private Button bt_in;
        private Button bt_post;
        private Button bt_wszerz;
        private Button bt_wypisz;
        private Button bt_zigzag;
    }
}
