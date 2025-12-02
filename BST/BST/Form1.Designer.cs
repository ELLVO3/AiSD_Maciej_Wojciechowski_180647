namespace BST
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
            lbl_BST = new Label();
            bt_add = new Button();
            txt_insert = new TextBox();
            tree_show = new TreeView();
            lbl_result = new Label();
            bt_sort = new Button();
            SuspendLayout();
            // 
            // lbl_BST
            // 
            lbl_BST.AutoSize = true;
            lbl_BST.Location = new Point(339, 9);
            lbl_BST.Name = "lbl_BST";
            lbl_BST.Size = new Size(103, 15);
            lbl_BST.TabIndex = 0;
            lbl_BST.Text = "Binary Search Tree";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(713, 390);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 1;
            bt_add.Text = "Dodaj";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // txt_insert
            // 
            txt_insert.Location = new Point(339, 70);
            txt_insert.Name = "txt_insert";
            txt_insert.Size = new Size(100, 23);
            txt_insert.TabIndex = 2;
            // 
            // tree_show
            // 
            tree_show.Location = new Point(202, 99);
            tree_show.Name = "tree_show";
            tree_show.Size = new Size(374, 314);
            tree_show.TabIndex = 3;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Location = new Point(12, 9);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(38, 15);
            lbl_result.TabIndex = 4;
            lbl_result.Text = "label1";
            lbl_result.Visible = false;
            // 
            // bt_sort
            // 
            bt_sort.Location = new Point(713, 419);
            bt_sort.Name = "bt_sort";
            bt_sort.Size = new Size(75, 23);
            bt_sort.TabIndex = 5;
            bt_sort.Text = "Sortuj";
            bt_sort.UseVisualStyleBackColor = true;
            bt_sort.Click += bt_sort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_sort);
            Controls.Add(lbl_result);
            Controls.Add(tree_show);
            Controls.Add(txt_insert);
            Controls.Add(bt_add);
            Controls.Add(lbl_BST);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_BST;
        private Button bt_add;
        private TextBox txt_insert;
        private TreeView tree_show;
        private Label lbl_result;
        private Button bt_sort;
    }
}
