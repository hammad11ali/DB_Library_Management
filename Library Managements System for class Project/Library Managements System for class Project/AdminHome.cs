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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            (new AddBook()).Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            (new addUser()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            (new categories()).Show();
        }

        private void btnIssuedBook_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            (new IssueBook()).Show();
        }
    }
}
