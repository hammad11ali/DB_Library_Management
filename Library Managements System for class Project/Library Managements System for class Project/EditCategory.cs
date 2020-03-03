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
    public partial class EditCategory : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        string categoryName;
        public EditCategory()
        {
            InitializeComponent();
        }
        public EditCategory(string n)
        {
            InitializeComponent();
            categoryName = n;
            txtCName.Text = n;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool flag = server.editCategory(categoryName);
            if(flag)
            {
                ActiveForm.Hide();
                (new categories()).Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
