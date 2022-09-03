using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kelvi\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            combocat.Items.Clear();
            cm = new SqlCommand("SELECT catname FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                combocat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
                

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {                
                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pname,pqty,pprice,pdescription,pcategory)VALUES(@pname,@pqty,@pprice,@pdescription,@pcategory)", con);
                    cm.Parameters.AddWithValue("@pname", txtpname.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtpqty.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtpprice.Text));
                    cm.Parameters.AddWithValue("@pdescription", txtpdescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", combocat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been saved successfully.");
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        public void Clear()
        {
            txtpname.Clear();
            txtpqty.Clear();
            txtpprice.Clear();
            txtpdescription.Clear();
            combocat.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {                
                if (MessageBox.Show("Are you sure you want to update this product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET pname = @pname, pqty = @pqty, pprice = @pprice, pdescription = @pdescription, pcategory = @pcategory WHERE pid LIKE '" + lblpid.Text + "'", con);
                    cm.Parameters.AddWithValue("@pname", txtpname.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtpqty.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtpprice.Text));
                    cm.Parameters.AddWithValue("@pdescription", txtpdescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", combocat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been updated successfully.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
