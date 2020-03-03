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
    
    public partial class UserLogin : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            bool check = server.userLogin(txtuserId.Text, txtUserPassword.Text);
            if(check)
            {
                ActiveForm.Hide();
                (new user_Hume()).Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
