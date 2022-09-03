namespace Inventory_Management_System
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnorder = new System.Windows.Forms.PictureBox();
            this.btncust = new System.Windows.Forms.PictureBox();
            this.btnuser = new System.Windows.Forms.PictureBox();
            this.btnprod = new System.Windows.Forms.PictureBox();
            this.btnCate = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOPRITE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnorder);
            this.panel2.Controls.Add(this.btncust);
            this.panel2.Controls.Add(this.btnuser);
            this.panel2.Controls.Add(this.btnprod);
            this.panel2.Controls.Add(this.btnCate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 389);
            this.panel2.TabIndex = 1;
            // 
            // btnorder
            // 
            this.btnorder.Image = ((System.Drawing.Image)(resources.GetObject("btnorder.Image")));
            this.btnorder.Location = new System.Drawing.Point(95, 274);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(45, 37);
            this.btnorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnorder.TabIndex = 5;
            this.btnorder.TabStop = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btncust
            // 
            this.btncust.Image = ((System.Drawing.Image)(resources.GetObject("btncust.Image")));
            this.btncust.Location = new System.Drawing.Point(95, 213);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(45, 37);
            this.btncust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncust.TabIndex = 6;
            this.btncust.TabStop = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // btnuser
            // 
            this.btnuser.Image = ((System.Drawing.Image)(resources.GetObject("btnuser.Image")));
            this.btnuser.Location = new System.Drawing.Point(95, 143);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(45, 37);
            this.btnuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnuser.TabIndex = 4;
            this.btnuser.TabStop = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnprod
            // 
            this.btnprod.Image = ((System.Drawing.Image)(resources.GetObject("btnprod.Image")));
            this.btnprod.Location = new System.Drawing.Point(95, 83);
            this.btnprod.Name = "btnprod";
            this.btnprod.Size = new System.Drawing.Size(45, 37);
            this.btnprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnprod.TabIndex = 2;
            this.btnprod.TabStop = false;
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // btnCate
            // 
            this.btnCate.Image = ((System.Drawing.Image)(resources.GetObject("btnCate.Image")));
            this.btnCate.Location = new System.Drawing.Point(95, 25);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(45, 37);
            this.btnCate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCate.TabIndex = 0;
            this.btnCate.TabStop = false;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Users";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customers";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Products";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categories";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(162, 59);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(638, 390);
            this.panelMain.TabIndex = 2;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCate;
        private System.Windows.Forms.PictureBox btnprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btncust;
        private System.Windows.Forms.PictureBox btnorder;
        private System.Windows.Forms.PictureBox btnuser;
        private System.Windows.Forms.Panel panelMain;
    }
}