using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managements_System_for_class_Project
{
    public partial class IssueBook : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int userId;
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnsearchUser_Click(object sender, EventArgs e)
        {
            userId = server.getUser(txtissueName.Text);
            if(userId!=0)
            {
                txtBookName.Show();
                lblBookName.Show();
                btnbookName.Show();
                txtQuantity.Show();
                lblQuantity.Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void btnbookName_Click(object sender, EventArgs e)
        {
            bool check = server.addBookToUser(userId, txtBookName.Text, Convert.ToInt32(txtQuantity.Text));
            if(check)
            {
                show();
            }
        }
        void show()
        {
            txtBookName.Hide();
            lblBookName.Hide();
            btnbookName.Hide();
            txtQuantity.Hide();
            lblQuantity.Hide();
            int[] bookId = server.getBookId();
            string[] category = server.getCategoriesName();
            string[] bookName = server.getBookName();
            string[] bookAuthor = server.getBookAuthor();
            int[] quatitiesofBook = server.getQuantity();
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            for (int i = 0; i < bookId.Length; i++)
            {
                dataGridView1.Rows.Add(bookId[i], bookName[i], bookAuthor[i], date, quatitiesofBook[i]);
            }
        }
    }
}
