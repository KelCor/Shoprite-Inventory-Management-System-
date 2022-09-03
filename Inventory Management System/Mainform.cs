using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }
    }
}
