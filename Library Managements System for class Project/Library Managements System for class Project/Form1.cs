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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

                    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form form = new AdminLogin();
            form.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form form = new UserLogin();
            form.Show();
            
        }
    }
}
