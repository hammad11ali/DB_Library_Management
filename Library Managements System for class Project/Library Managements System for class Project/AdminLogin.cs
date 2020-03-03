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
    public partial class AdminLogin : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            bool check=server.adminLogin(txtAdminId.Text, txtAdminPassword.Text);
            if(check)
            {
                ActiveForm.Hide();
                (new AdminHome()).Show();
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }
    }
}
