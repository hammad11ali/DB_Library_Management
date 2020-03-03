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
    public partial class EditUser : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int currentIndex;
        string name;
        string password;
        public EditUser()
        {
            InitializeComponent();
        }
        public EditUser(string index,string n,string p)
        {
            InitializeComponent();
            currentIndex =Convert.ToInt32( index);
            name = n;
            password = p;
        }
        private void EditUser_Load(object sender, EventArgs e)
        {
            txtUserName.Text = name;
            txtUserPassword.Text = password;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
           server.editUserData(txtUserName.Text,txtUserPassword.Text,currentIndex);
            ActiveForm.Hide();
            (new addUser()).Show();
        }
    }
}
