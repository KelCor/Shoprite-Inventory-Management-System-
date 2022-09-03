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
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kelvi\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        public void LoadCustomer()
        {
            int i = 0;
            ddgCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT cid,cname FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%"+txtsearchCus.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                ddgCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadProduct()
        {
            int i = 0;
            ddgProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid,pname,pprice,pdescription,pcategory) LIKE '%" + txtsearchProduct.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                ddgProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearchCus_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtsearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

              

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Getqty();
            if (Convert.ToInt16(udqty.Value)>qty)
            {
                MessageBox.Show("Quantity in stock is not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                udqty.Value = udqty.Value - 1;
                return;
            }
            if (Convert.ToInt16(udqty.Value) > 0)
            {
                int total = Convert.ToInt16(txtprice.Text) * Convert.ToInt16(udqty.Value);
                txttotal.Text = total.ToString();
            }
        }

        private void ddgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcid.Text = ddgCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcname.Text = ddgCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void ddgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = ddgProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpname.Text = ddgProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtprice.Text = ddgProduct.Rows[e.RowIndex].Cells[4].Value.ToString();            
        }

        private void ddgCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ddgProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcid.Text == "")
                {
                    MessageBox.Show("Please select customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtpid.Text == "")
                {
                    MessageBox.Show("Please select product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, qty, price, total)VALUES(@odate, @pid, @cid, @qty, @price, @total)", con);
                    cm.Parameters.AddWithValue("@odate", dtorder.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt16(txtpid.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt16(txtcid.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(udqty.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(txtprice.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt16(txttotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been inserted successfully.");
                   

                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty-@pqty) WHERE pid LIKE '" + txtpid.Text + "'", con);                    
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(udqty.Text));                   
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtcid.Clear();
            txtcname.Clear();

            txtpid.Clear();
            txtpname.Clear();

            txtprice.Clear();
            udqty.Value = 1;
            txttotal.Clear();
            dtorder.Value = DateTime.Now;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();           
        }

        public void Getqty()
        {
            cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid = '" + txtpid.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        
    }
}
