using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Library_Managements_System_for_class_Project
{
    public partial class addUser : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        public addUser()
        {
            InitializeComponent();
        }

        private void addUser_Load(object sender, EventArgs e)
        {

            showUser();

        }
        void showUser()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Refresh();
            int[] ids;
            ids = server.getUserId();
            string[] name = server.getUserName();
            string[] password = server.getUserPassword();
            for (int i = 0; i < ids.Length; i++)
            {
                dgvUsers.Rows.Add(ids[i], name[i], password[i], "Edit", "Delete");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = server.adUser(txtUserName.Text, txtUserPassword.Text);
            if (check)
            {
                MessageBox.Show("User Add successfully");
                showUser();
            }
            else
            {
                MessageBox.Show("User already Exist with that Name and Password");
            }

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ActiveForm.Hide();
                (new EditUser(Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[0].Value), Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[1].Value), Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[2].Value))).Show();
            }
            if(e.ColumnIndex==4)
            {
                server.deleteUser(Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value));
                showUser();
            }
        }
    }
}

