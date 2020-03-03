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
    public partial class categories : Form
    {
        ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            showCategory();
        }
        void showCategory()
        {
            dgvCategory.Rows.Clear();
            dgvCategory.Refresh();
            string[] categories = server.getCategoryName();
            for(int i=0;i<categories.Length;i++)
            {
                dgvCategory.Rows.Add(categories[i], "Edit", "Delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = server.addCategory(txtCName.Text);
            if(check)
            {
                showCategory();
            }
            else
            {
                MessageBox.Show("This Category is already exist");
            }
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==1)
            {
                bool flag=server.editCategory(Convert.ToString(dgvCategory.Rows[e.RowIndex].Cells[0].Value));
                if(flag)
                {
                    showCategory();
                }
                else
                {
                    MessageBox.Show("This category is already exist");
                }
                if(e.ColumnIndex==2)
                {
                    server.deleteCategory(Convert.ToString(dgvCategory.Rows[e.RowIndex].Cells[0].Value));
                    showCategory();
                }
            }
        }
    }
}
