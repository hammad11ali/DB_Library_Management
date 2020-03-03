namespace Library_Managements_System_for_class_Project
{
    partial class IssueBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.Books = new System.Windows.Forms.Label();
            this.btnsearchUser = new System.Windows.Forms.Button();
            this.btnbookName = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtissueName = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Book";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(210, 46);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(86, 16);
            this.lab.TabIndex = 1;
            this.lab.Text = "User Name";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(210, 144);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(89, 16);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Name";
            // 
            // Books
            // 
            this.Books.AutoSize = true;
            this.Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books.Location = new System.Drawing.Point(334, 237);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(59, 20);
            this.Books.TabIndex = 3;
            this.Books.Text = "Books";
            // 
            // btnsearchUser
            // 
            this.btnsearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchUser.Location = new System.Drawing.Point(322, 92);
            this.btnsearchUser.Name = "btnsearchUser";
            this.btnsearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnsearchUser.TabIndex = 6;
            this.btnsearchUser.Text = "Search";
            this.btnsearchUser.UseVisualStyleBackColor = true;
            this.btnsearchUser.Click += new System.EventHandler(this.btnsearchUser_Click);
            // 
            // btnbookName
            // 
            this.btnbookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookName.Location = new System.Drawing.Point(322, 211);
            this.btnbookName.Name = "btnbookName";
            this.btnbookName.Size = new System.Drawing.Size(75, 23);
            this.btnbookName.TabIndex = 7;
            this.btnbookName.Text = "Done";
            this.btnbookName.UseVisualStyleBackColor = true;
            this.btnbookName.Click += new System.EventHandler(this.btnbookName_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookName,
            this.AuthorName,
            this.Date,
            this.Quantity});
            this.dataGridView1.Location = new System.Drawing.Point(124, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 173);
            this.dataGridView1.TabIndex = 8;
            // 
            // BookId
            // 
            this.BookId.HeaderText = "Book ID";
            this.BookId.Name = "BookId";
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.Name = "AuthorName";
            // 
            // Date
            // 
            this.Date.HeaderText = "Today Date";
            this.Date.Name = "Date";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qualtity";
            this.Quantity.Name = "Quantity";
            // 
            // txtissueName
            // 
            this.txtissueName.Location = new System.Drawing.Point(309, 42);
            this.txtissueName.Name = "txtissueName";
            this.txtissueName.Size = new System.Drawing.Size(100, 20);
            this.txtissueName.TabIndex = 9;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(309, 140);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(309, 170);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(210, 174);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtissueName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbookName);
            this.Controls.Add(this.btnsearchUser);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label1);
            this.Name = "IssueBook";
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label Books;
        private System.Windows.Forms.Button btnsearchUser;
        private System.Windows.Forms.Button btnbookName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtissueName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}