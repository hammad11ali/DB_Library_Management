namespace Library_Managements_System_for_class_Project
{
    partial class AdminHome
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
            this.btnAddbooks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnIssuedBook = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // btnAddbooks
            // 
            this.btnAddbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddbooks.Location = new System.Drawing.Point(53, 85);
            this.btnAddbooks.Name = "btnAddbooks";
            this.btnAddbooks.Size = new System.Drawing.Size(139, 56);
            this.btnAddbooks.TabIndex = 5;
            this.btnAddbooks.Text = "Add Book";
            this.btnAddbooks.UseVisualStyleBackColor = true;
            this.btnAddbooks.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Total Issued Books";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(598, 213);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(139, 56);
            this.btnReturnBook.TabIndex = 7;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(598, 85);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(139, 56);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnIssuedBook
            // 
            this.btnIssuedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssuedBook.Location = new System.Drawing.Point(53, 213);
            this.btnIssuedBook.Name = "btnIssuedBook";
            this.btnIssuedBook.Size = new System.Drawing.Size(139, 56);
            this.btnIssuedBook.TabIndex = 9;
            this.btnIssuedBook.Text = "Issue Book";
            this.btnIssuedBook.UseVisualStyleBackColor = true;
            this.btnIssuedBook.Click += new System.EventHandler(this.btnIssuedBook_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(598, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 56);
            this.button6.TabIndex = 10;
            this.button6.Text = "All Books";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(331, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnIssuedBook);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddbooks);
            this.Controls.Add(this.label1);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddbooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnIssuedBook;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
    }
}