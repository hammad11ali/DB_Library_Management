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
    public partial class EditBook : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        string bookId;
        string bookName;
        string bookAuthor;
        string bookquantity;

        public EditBook()
        {
            InitializeComponent();
        }
        public EditBook(string Id, string name,string author,string quantity)
        {
            InitializeComponent();
            bookId = Id;
            bookName = name;
            bookAuthor = author;
            bookquantity = quantity;

        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            string[] allCategories = server.getallCategories();
            for (int j = 0; j < allCategories.Length; j++)
            {
                cbBookCategory.Items.Add(Convert.ToString(allCategories[j]));
            }
            
            txtName.Text = bookName;
            txtAuthor.Text = bookAuthor;
            txtQuntity.Text = bookquantity;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            server.editBook(txtName.Text, txtAuthor.Text, Convert.ToInt32(txtQuntity.Text), cbBookCategory.Text);
            
                ActiveForm.Hide();
                (new AddBook()).Show();
            
        }
    }
}
