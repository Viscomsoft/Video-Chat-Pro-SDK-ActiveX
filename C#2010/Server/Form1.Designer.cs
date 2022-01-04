namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textConfNo = new System.Windows.Forms.TextBox();
            this.chkUseRandomNo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSelectedUserID = new System.Windows.Forms.TextBox();
            this.axVideoChatServer1 = new AxVideoChatServerLib.AxVideoChatServer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Port No.";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(162, 33);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 20);
            this.textPort.TabIndex = 2;
            this.textPort.Text = "1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conference Number";
            // 
            // textConfNo
            // 
            this.textConfNo.Location = new System.Drawing.Point(162, 73);
            this.textConfNo.Name = "textConfNo";
            this.textConfNo.Size = new System.Drawing.Size(100, 20);
            this.textConfNo.TabIndex = 2;
            // 
            // chkUseRandomNo
            // 
            this.chkUseRandomNo.AutoSize = true;
            this.chkUseRandomNo.Checked = true;
            this.chkUseRandomNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseRandomNo.Location = new System.Drawing.Point(343, 35);
            this.chkUseRandomNo.Name = "chkUseRandomNo";
            this.chkUseRandomNo.Size = new System.Drawing.Size(288, 17);
            this.chkUseRandomNo.TabIndex = 3;
            this.chkUseRandomNo.Text = "The Conference Number, User ID use Random Number";
            this.chkUseRandomNo.UseVisualStyleBackColor = true;
            this.chkUseRandomNo.CheckedChanged += new System.EventHandler(this.chkUseRandomNo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID  (if the user connected, it will mark *** )";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Conference";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add User to this Conference ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selected User ID";
            // 
            // textSelectedUserID
            // 
            this.textSelectedUserID.Location = new System.Drawing.Point(400, 229);
            this.textSelectedUserID.Name = "textSelectedUserID";
            this.textSelectedUserID.Size = new System.Drawing.Size(121, 20);
            this.textSelectedUserID.TabIndex = 7;
            // 
            // axVideoChatServer1
            // 
            this.axVideoChatServer1.Enabled = true;
            this.axVideoChatServer1.Location = new System.Drawing.Point(366, 375);
            this.axVideoChatServer1.Name = "axVideoChatServer1";
            this.axVideoChatServer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatServer1.OcxState")));
            this.axVideoChatServer1.Size = new System.Drawing.Size(194, 119);
            this.axVideoChatServer1.TabIndex = 0;
            this.axVideoChatServer1.ClientConnected += new AxVideoChatServerLib._DVideoChatServerEvents_ClientConnectedEventHandler(this.axVideoChatServer1_ClientConnected);
            this.axVideoChatServer1.ClientDisconnected += new AxVideoChatServerLib._DVideoChatServerEvents_ClientDisconnectedEventHandler(this.axVideoChatServer1_ClientDisConnected);
            this.axVideoChatServer1.AllClientDisconnected += new AxVideoChatServerLib._DVideoChatServerEvents_AllClientDisconnectedEventHandler(this.axVideoChatServer1_AllClientDisconnected);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 355);
            this.listBox1.TabIndex = 12;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 551);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textSelectedUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkUseRandomNo);
            this.Controls.Add(this.textConfNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axVideoChatServer1);
            this.Name = "Form1";
            this.Text = "Video Chat Pro Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form1_Closing);

            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxVideoChatServerLib.AxVideoChatServer axVideoChatServer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textConfNo;
        private System.Windows.Forms.CheckBox chkUseRandomNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSelectedUserID;
        private System.Windows.Forms.ListBox listBox1;
    }
}

