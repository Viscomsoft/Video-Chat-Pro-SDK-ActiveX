using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textPort.Text == "")
            {
                MessageBox.Show("Please input Port No.");
                return;
            }
            this.axVideoChatServer1.InitServer(Convert.ToInt32(this.textPort.Text), 300);
            
            if (this.chkUseRandomNo.Checked == true)
            {
                this.axVideoChatServer1.UseRandomNumber = true;
            }
            else
            {
                this.axVideoChatServer1.UseRandomNumber = false;
            }

            
            this.textConfNo.Text = Convert.ToString(this.axVideoChatServer1.CreateConference());
            this.listBox1.Items.Clear();
         
        
            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = false;
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            this.axVideoChatServer1.UnInitServer();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            long iUserID = 0;
            iUserID = this.axVideoChatServer1.AddUser(Convert.ToInt32(this.textConfNo.Text));

            

            if (iUserID != 0)
            {
                this.listBox1.Items.Add(iUserID.ToString());
            }
            else
            {
                MessageBox.Show("Max is 12 user per Room");
            }
        }

        private void listUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void axVideoChatServer1_ClientConnected(object sender, AxVideoChatServerLib._DVideoChatServerEvents_ClientConnectedEvent e)
        {
            string strUserID;
            string strListID;
            
            strUserID = e.iUserID.ToString();
            
            
            int index = listBox1.Items.IndexOf(strUserID);
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, strUserID+"***");
                listBox1.SelectedIndex = index;
            }

            this.listBox1.Refresh();
        }

        private void axVideoChatServer1_ClientDisConnected(object sender, AxVideoChatServerLib._DVideoChatServerEvents_ClientDisconnectedEvent e)
        {
            string strUserID;
            string strListID;
            strUserID = e.iUserID.ToString();



            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                strListID = this.listBox1.Items[i].ToString();
                if (strListID == (strUserID + "***"))
                {
                    this.listBox1.Items.RemoveAt(i);
                    this.listBox1.Items.Insert(i, strUserID);
                   }
            }

            this.listBox1.Refresh();
        }
        private void axVideoChatServer1_AllClientDisconnected(object sender, AxVideoChatServerLib._DVideoChatServerEvents_AllClientDisconnectedEvent e)
        {
            MessageBox.Show("All client disconnected");
            this.listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textSelectedUserID.Text = this.listBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkUseRandomNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int index = listBox1.Items.IndexOf(textSelectedUserID.Text);
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, textSelectedUserID.Text + "***");
                //listBox1.Items[index] = strUserID + "***";
                listBox1.SelectedIndex = index;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
