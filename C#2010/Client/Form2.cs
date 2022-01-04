using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace videochatsample
{
   
    public partial class Form2 : Form
     {


        public Form2()
        {
            InitializeComponent();
        }

        static void Hello()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textIPAddress.Text == "")
            {
                MessageBox.Show("Please input IP Address");
                return;
            }
            if (radioButton1.Checked)
            {
                if (this.txtListenIP.Text == "" || this.txtListenIP.Text == "0")
                {
                    MessageBox.Show("Please input Listening IP Address");
                    return;
                }
            }
            if (this.textPortNo.Text == "")
            {
                MessageBox.Show("Please input Port No");
                return;
            }
            if (this.textConfNo.Text == "")
            {
                MessageBox.Show("Please input Conference No");
                return;
            }
            if (this.textUserID.Text == "")
            {
                MessageBox.Show("Please input User ID");
                return;
            }
            Form1 frm = new Form1(this);

            this.Hide();
            frm.Show();
            frm.txtconnectIP.Text = this.textIPAddress.Text;
            
            frm.txtPeertoPeerListenIP.Text = txtListenIP.Text;
            frm.txtConnectPortNo.Text = this.textPortNo.Text;
            frm.textConfNo.Text = this.textConfNo.Text;
            frm.textUserID.Text = this.textUserID.Text;
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label1.Text = "Stream to IP address";
            textConfNo.Text = "0";
            textUserID.Text = "0";
            textConfNo.Enabled = false;
            textUserID.Enabled = false;
            txtListenIP.Enabled = true;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "IP address of Video Chat Pro server";
             textConfNo.Text = "5000";
            textUserID.Text = "10000";
            textConfNo.Enabled = true;
            textUserID.Enabled = true;
            txtListenIP.Enabled = false;
            txtListenIP.Text = "0";
        }
    }
}
