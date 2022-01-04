namespace videochatsample
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPortNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textConfNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtListenIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stream to IP address ";
            // 
            // textIPAddress
            // 
            this.textIPAddress.Location = new System.Drawing.Point(302, 80);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(84, 20);
            this.textIPAddress.TabIndex = 1;
            this.textIPAddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port No";
            // 
            // textPortNo
            // 
            this.textPortNo.Location = new System.Drawing.Point(159, 130);
            this.textPortNo.Name = "textPortNo";
            this.textPortNo.Size = new System.Drawing.Size(100, 20);
            this.textPortNo.TabIndex = 3;
            this.textPortNo.Text = "1234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conference Number";
            // 
            // textConfNo
            // 
            this.textConfNo.Location = new System.Drawing.Point(159, 182);
            this.textConfNo.Name = "textConfNo";
            this.textConfNo.Size = new System.Drawing.Size(100, 20);
            this.textConfNo.TabIndex = 3;
            this.textConfNo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "User ID";
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(159, 231);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(100, 20);
            this.textUserID.TabIndex = 3;
            this.textUserID.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter 0 for One to One Video Chat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Multiple people video chat";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "One to One video chat";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "IP address of Current computer (For Listening)";
            // 
            // txtListenIP
            // 
            this.txtListenIP.Location = new System.Drawing.Point(302, 104);
            this.txtListenIP.Name = "txtListenIP";
            this.txtListenIP.Size = new System.Drawing.Size(84, 20);
            this.txtListenIP.TabIndex = 8;
            this.txtListenIP.Text = "127.0.0.1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 392);
            this.Controls.Add(this.txtListenIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textConfNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPortNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIPAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox textIPAddress;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox textPortNo;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.TextBox textConfNo;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.TextBox textUserID;
        //private System.Windows.Forms.Button button1;

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textIPAddress;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textPortNo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textConfNo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textUserID;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtListenIP;
    }
}