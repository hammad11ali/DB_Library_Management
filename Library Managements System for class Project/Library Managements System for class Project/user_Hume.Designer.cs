﻿namespace Library_Managements_System_for_class_Project
{
    partial class user_Hume
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
            this.button6 = new System.Windows.Forms.Button();
            this.btnIssuedBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(548, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 56);
            this.button6.TabIndex = 17;
            this.button6.Text = "Available Books";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnIssuedBook
            // 
            this.btnIssuedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssuedBook.Location = new System.Drawing.Point(58, 197);
            this.btnIssuedBook.Name = "btnIssuedBook";
            this.btnIssuedBook.Size = new System.Drawing.Size(139, 56);
            this.btnIssuedBook.TabIndex = 16;
            this.btnIssuedBook.Text = "Issued Book";
            this.btnIssuedBook.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Library Management System";
            // 
            // user_Hume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnIssuedBook);
            this.Controls.Add(this.label1);
            this.Name = "user_Hume";
            this.Text = "user_Hume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnIssuedBook;
        private System.Windows.Forms.Label label1;
    }
}