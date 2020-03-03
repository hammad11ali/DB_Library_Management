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
    public partial class AddBook : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            showBook();

        }
        void showBook()
        {
            dgvBooks.Rows.Clear();
            dgvBooks.Refresh();
            int[] bookId = server.getBookId();
            string[] category = server.getCategoriesName();
            string[] bookName = server.getBookName();
            string[] bookAuthor = server.getBookAuthor();
            int[] quatitiesofBook = server.getQuantity();
            for (int i = 0; i < bookId.Length; i++)
            {
                dgvBooks.Rows.Add(bookId[i], category[i], bookName[i], bookAuthor[i], quatitiesofBook[i], "Edit", "Delete");
            }
            string[] allCategories=server.getallCategories();
            for (int j=0;j<allCategories.Length;j++)
            {
              cbBookCategory.Items.Add(Convert.ToString(allCategories[j]));
            }
                    }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool addBook = server.addBook(Convert.ToInt32(txtBookISBN.Text), txtName.Text, txtAuthor.Text, Convert.ToInt32(txtQuntity.Text), cbBookCategory.Text);
            if(addBook)
            {
                showBook();
            }
            else
            {
                MessageBox.Show("This book is already exist");
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                ActiveForm.Hide();
                (new EditBook(Convert.ToString(dgvBooks.Rows[e.RowIndex].Cells[0].Value), Convert.ToString(dgvBooks.Rows[e.RowIndex].Cells[2].Value), Convert.ToString(dgvBooks.Rows[e.RowIndex].Cells[3].Value), Convert.ToString( dgvBooks.Rows[e.RowIndex].Cells[4].Value))).Show();
            }
            if(e.ColumnIndex==6)
            {
                server.delete(Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells[0].Value));
            }
        }
    }
}
