using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace videochatsample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbovideodevice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboaudiodevice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbovideoformat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtVideobitrate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtconnectIP;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblvideobitrate;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblaudiobitrate;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtframerate;
		private System.Windows.Forms.CheckBox chksendvideo;
        private System.Windows.Forms.CheckBox chksendaudio;
		private System.Windows.Forms.ComboBox cboaudiocomplex;
		private System.Windows.Forms.ComboBox cboaudioquality;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textUserID;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox txtConnectPortNo;
		private System.Windows.Forms.CheckBox chkreceiveaudio;
		private System.Windows.Forms.CheckBox chkreceivevideo;
        public System.Windows.Forms.TextBox textConfNo;
        private Button button5;
        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender1;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
        private Button SelectImage;
        private TextBox textImage;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox2;
        private Button button6;
        private TextBox textBox1;
        private Label label16;
        private CheckBox checkBox1;
        private Label label9;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox4;
        private TextBox txtmp4audiosamplerate;
        private Label label23;
        private TextBox txtmp4framerate;
        private Label label22;
        private TextBox txtmp4audiobitrate;
        private Label label21;
        private TextBox txtmp4videobitrate;
        private Label label20;
        private TextBox txtmp4audiochannels;
        private Label label19;
        private TextBox txtmp4height;
        private Label label18;
        private TextBox txtmp4width;
        private Label label17;
        private GroupBox groupBox3;
        private RadioButton RadioAspectRatio3;
        private RadioButton RadioAspectRatio2;
        private RadioButton RadioAspectRatio1;
        private Button button7;
        private Button button8;
        private GroupBox groupBox5;
        private RadioButton radioButtonWMV;
        private RadioButton radioButtonMP4;
        private Label label24;
        private ListBox listBox1;
        public TextBox txtPeertoPeerListenIP;
        private Label label25;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        internal TextBox txtoverlayimagealpha;
        internal Label Label52;
        internal Button btnoverlayimagetranscolor;
        internal TextBox txtoverlayimagey;
        internal Label Label51;
        internal TextBox txtoverlayimagex;
        internal Label Label50;
        internal Button btnseloverlayimage;
        internal Label Label49;
        internal TextBox txtoverlayimage;
        internal Button btnclearimage;
        internal Button btnoverlayimagedraw;

        public Color clrTransColor;
        Form opener;
        public Form1(Form parentForm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            opener = parentForm;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.cbovideodevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboaudiodevice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbovideoformat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtframerate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVideobitrate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chksendvideo = new System.Windows.Forms.CheckBox();
            this.chksendaudio = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtconnectIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConnectPortNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboaudiocomplex = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboaudioquality = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblvideobitrate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblaudiobitrate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnoverlayimagedraw = new System.Windows.Forms.Button();
            this.btnclearimage = new System.Windows.Forms.Button();
            this.txtoverlayimagealpha = new System.Windows.Forms.TextBox();
            this.Label52 = new System.Windows.Forms.Label();
            this.btnoverlayimagetranscolor = new System.Windows.Forms.Button();
            this.txtoverlayimagey = new System.Windows.Forms.TextBox();
            this.Label51 = new System.Windows.Forms.Label();
            this.txtoverlayimagex = new System.Windows.Forms.TextBox();
            this.Label50 = new System.Windows.Forms.Label();
            this.btnseloverlayimage = new System.Windows.Forms.Button();
            this.Label49 = new System.Windows.Forms.Label();
            this.txtoverlayimage = new System.Windows.Forms.TextBox();
            this.axVideoChatSender1 = new AxVideoChatSenderLib.AxVideoChatSender();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonWMV = new System.Windows.Forms.RadioButton();
            this.radioButtonMP4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtmp4audiosamplerate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtmp4framerate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtmp4audiobitrate = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtmp4videobitrate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtmp4audiochannels = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtmp4height = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtmp4width = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioAspectRatio3 = new System.Windows.Forms.RadioButton();
            this.RadioAspectRatio2 = new System.Windows.Forms.RadioButton();
            this.RadioAspectRatio1 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SelectImage = new System.Windows.Forms.Button();
            this.textImage = new System.Windows.Forms.TextBox();
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.chkreceiveaudio = new System.Windows.Forms.CheckBox();
            this.chkreceivevideo = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textConfNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtPeertoPeerListenIP = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Device";
            // 
            // cbovideodevice
            // 
            this.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideodevice.Location = new System.Drawing.Point(128, 69);
            this.cbovideodevice.Name = "cbovideodevice";
            this.cbovideodevice.Size = new System.Drawing.Size(216, 20);
            this.cbovideodevice.TabIndex = 2;
            this.cbovideodevice.SelectedIndexChanged += new System.EventHandler(this.cbovideodevice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Audio Device";
            // 
            // cboaudiodevice
            // 
            this.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiodevice.Location = new System.Drawing.Point(128, 101);
            this.cboaudiodevice.Name = "cboaudiodevice";
            this.cboaudiodevice.Size = new System.Drawing.Size(216, 20);
            this.cboaudiodevice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Format";
            // 
            // cbovideoformat
            // 
            this.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideoformat.Location = new System.Drawing.Point(128, 133);
            this.cbovideoformat.Name = "cbovideoformat";
            this.cbovideoformat.Size = new System.Drawing.Size(128, 20);
            this.cbovideoformat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(272, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Frame Rate";
            // 
            // txtframerate
            // 
            this.txtframerate.Location = new System.Drawing.Point(352, 133);
            this.txtframerate.Name = "txtframerate";
            this.txtframerate.Size = new System.Drawing.Size(64, 18);
            this.txtframerate.TabIndex = 8;
            this.txtframerate.Text = "25";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Video Bitrate";
            // 
            // txtVideobitrate
            // 
            this.txtVideobitrate.Location = new System.Drawing.Point(128, 173);
            this.txtVideobitrate.Name = "txtVideobitrate";
            this.txtVideobitrate.Size = new System.Drawing.Size(96, 18);
            this.txtVideobitrate.TabIndex = 10;
            this.txtVideobitrate.Text = "1280000";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(232, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "bits";
            // 
            // chksendvideo
            // 
            this.chksendvideo.Checked = true;
            this.chksendvideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendvideo.Location = new System.Drawing.Point(288, 173);
            this.chksendvideo.Name = "chksendvideo";
            this.chksendvideo.Size = new System.Drawing.Size(128, 16);
            this.chksendvideo.TabIndex = 12;
            this.chksendvideo.Text = "Send Video Stream";
            // 
            // chksendaudio
            // 
            this.chksendaudio.Checked = true;
            this.chksendaudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendaudio.Location = new System.Drawing.Point(432, 165);
            this.chksendaudio.Name = "chksendaudio";
            this.chksendaudio.Size = new System.Drawing.Size(128, 32);
            this.chksendaudio.TabIndex = 13;
            this.chksendaudio.Text = "Send Audio Stream";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Connect to IP Address";
            // 
            // txtconnectIP
            // 
            this.txtconnectIP.Location = new System.Drawing.Point(189, 28);
            this.txtconnectIP.Name = "txtconnectIP";
            this.txtconnectIP.Size = new System.Drawing.Size(77, 18);
            this.txtconnectIP.TabIndex = 15;
            this.txtconnectIP.Text = "127.0.0.1";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(272, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Port No";
            // 
            // txtConnectPortNo
            // 
            this.txtConnectPortNo.Location = new System.Drawing.Point(335, 19);
            this.txtConnectPortNo.Name = "txtConnectPortNo";
            this.txtConnectPortNo.Size = new System.Drawing.Size(72, 18);
            this.txtConnectPortNo.TabIndex = 17;
            this.txtConnectPortNo.Text = "7000";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(360, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Audio Complexity";
            // 
            // cboaudiocomplex
            // 
            this.cboaudiocomplex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiocomplex.Location = new System.Drawing.Point(448, 93);
            this.cboaudiocomplex.Name = "cboaudiocomplex";
            this.cboaudiocomplex.Size = new System.Drawing.Size(112, 20);
            this.cboaudiocomplex.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(424, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Audio Quality";
            // 
            // cboaudioquality
            // 
            this.cboaudioquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudioquality.Location = new System.Drawing.Point(512, 125);
            this.cboaudioquality.Name = "cboaudioquality";
            this.cboaudioquality.Size = new System.Drawing.Size(112, 20);
            this.cboaudioquality.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(24, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Video bitrate (bit/sec)";
            // 
            // lblvideobitrate
            // 
            this.lblvideobitrate.Location = new System.Drawing.Point(136, 296);
            this.lblvideobitrate.Name = "lblvideobitrate";
            this.lblvideobitrate.Size = new System.Drawing.Size(80, 24);
            this.lblvideobitrate.TabIndex = 25;
            this.lblvideobitrate.Text = "0";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(240, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "Audio bitrate (bit/sec)";
            // 
            // lblaudiobitrate
            // 
            this.lblaudiobitrate.Location = new System.Drawing.Point(360, 296);
            this.lblaudiobitrate.Name = "lblaudiobitrate";
            this.lblaudiobitrate.Size = new System.Drawing.Size(88, 24);
            this.lblaudiobitrate.TabIndex = 27;
            this.lblaudiobitrate.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Connect";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "Disconnect";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnoverlayimagedraw);
            this.groupBox1.Controls.Add(this.btnclearimage);
            this.groupBox1.Controls.Add(this.txtoverlayimagealpha);
            this.groupBox1.Controls.Add(this.Label52);
            this.groupBox1.Controls.Add(this.btnoverlayimagetranscolor);
            this.groupBox1.Controls.Add(this.txtoverlayimagey);
            this.groupBox1.Controls.Add(this.Label51);
            this.groupBox1.Controls.Add(this.txtoverlayimagex);
            this.groupBox1.Controls.Add(this.Label50);
            this.groupBox1.Controls.Add(this.btnseloverlayimage);
            this.groupBox1.Controls.Add(this.Label49);
            this.groupBox1.Controls.Add(this.txtoverlayimage);
            this.groupBox1.Controls.Add(this.axVideoChatSender1);
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 612);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // btnoverlayimagedraw
            // 
            this.btnoverlayimagedraw.Location = new System.Drawing.Point(418, 185);
            this.btnoverlayimagedraw.Name = "btnoverlayimagedraw";
            this.btnoverlayimagedraw.Size = new System.Drawing.Size(59, 21);
            this.btnoverlayimagedraw.TabIndex = 45;
            this.btnoverlayimagedraw.Text = "Draw";
            this.btnoverlayimagedraw.UseVisualStyleBackColor = true;
            this.btnoverlayimagedraw.Click += new System.EventHandler(this.btnoverlayimagedraw_Click);
            // 
            // btnclearimage
            // 
            this.btnclearimage.Location = new System.Drawing.Point(486, 185);
            this.btnclearimage.Name = "btnclearimage";
            this.btnclearimage.Size = new System.Drawing.Size(74, 21);
            this.btnclearimage.TabIndex = 44;
            this.btnclearimage.Text = "Clear Image";
            this.btnclearimage.UseVisualStyleBackColor = true;
            this.btnclearimage.Click += new System.EventHandler(this.btnclearimage_Click);
            // 
            // txtoverlayimagealpha
            // 
            this.txtoverlayimagealpha.Location = new System.Drawing.Point(152, 207);
            this.txtoverlayimagealpha.Name = "txtoverlayimagealpha";
            this.txtoverlayimagealpha.Size = new System.Drawing.Size(24, 18);
            this.txtoverlayimagealpha.TabIndex = 43;
            this.txtoverlayimagealpha.Text = "255";
            // 
            // Label52
            // 
            this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label52.Location = new System.Drawing.Point(117, 210);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(32, 15);
            this.Label52.TabIndex = 42;
            this.Label52.Text = "Alpha";
            // 
            // btnoverlayimagetranscolor
            // 
            this.btnoverlayimagetranscolor.Location = new System.Drawing.Point(183, 208);
            this.btnoverlayimagetranscolor.Name = "btnoverlayimagetranscolor";
            this.btnoverlayimagetranscolor.Size = new System.Drawing.Size(79, 18);
            this.btnoverlayimagetranscolor.TabIndex = 41;
            this.btnoverlayimagetranscolor.Text = "Trans Color";
            this.btnoverlayimagetranscolor.UseVisualStyleBackColor = true;
            this.btnoverlayimagetranscolor.Click += new System.EventHandler(this.btnoverlayimagetranscolor_Click);
            // 
            // txtoverlayimagey
            // 
            this.txtoverlayimagey.Location = new System.Drawing.Point(81, 207);
            this.txtoverlayimagey.Name = "txtoverlayimagey";
            this.txtoverlayimagey.Size = new System.Drawing.Size(24, 18);
            this.txtoverlayimagey.TabIndex = 40;
            this.txtoverlayimagey.Text = "0";
            // 
            // Label51
            // 
            this.Label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label51.Location = new System.Drawing.Point(63, 210);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(20, 15);
            this.Label51.TabIndex = 39;
            this.Label51.Text = "Y";
            // 
            // txtoverlayimagex
            // 
            this.txtoverlayimagex.Location = new System.Drawing.Point(32, 207);
            this.txtoverlayimagex.Name = "txtoverlayimagex";
            this.txtoverlayimagex.Size = new System.Drawing.Size(24, 18);
            this.txtoverlayimagex.TabIndex = 38;
            this.txtoverlayimagex.Text = "0";
            // 
            // Label50
            // 
            this.Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label50.Location = new System.Drawing.Point(11, 210);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(20, 15);
            this.Label50.TabIndex = 37;
            this.Label50.Text = "X";
            // 
            // btnseloverlayimage
            // 
            this.btnseloverlayimage.Location = new System.Drawing.Point(353, 185);
            this.btnseloverlayimage.Name = "btnseloverlayimage";
            this.btnseloverlayimage.Size = new System.Drawing.Size(59, 21);
            this.btnseloverlayimage.TabIndex = 36;
            this.btnseloverlayimage.Text = "Image";
            this.btnseloverlayimage.UseVisualStyleBackColor = true;
            this.btnseloverlayimage.Click += new System.EventHandler(this.btnseloverlayimage_Click);
            // 
            // Label49
            // 
            this.Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.Location = new System.Drawing.Point(11, 187);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(39, 15);
            this.Label49.TabIndex = 35;
            this.Label49.Text = "Image";
            // 
            // txtoverlayimage
            // 
            this.txtoverlayimage.Location = new System.Drawing.Point(56, 184);
            this.txtoverlayimage.Name = "txtoverlayimage";
            this.txtoverlayimage.Size = new System.Drawing.Size(284, 18);
            this.txtoverlayimage.TabIndex = 34;
            // 
            // axVideoChatSender1
            // 
            this.axVideoChatSender1.Enabled = true;
            this.axVideoChatSender1.Location = new System.Drawing.Point(56, 298);
            this.axVideoChatSender1.Name = "axVideoChatSender1";
            this.axVideoChatSender1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender1.OcxState")));
            this.axVideoChatSender1.Size = new System.Drawing.Size(382, 284);
            this.axVideoChatSender1.TabIndex = 0;
            this.axVideoChatSender1.SendStream += new AxVideoChatSenderLib._DvideochatEvents_SendStreamEventHandler(this.axVideoChatSender1_SendStream);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.SelectImage);
            this.groupBox2.Controls.Add(this.textImage);
            this.groupBox2.Controls.Add(this.axVideoChatReceiver1);
            this.groupBox2.Controls.Add(this.chkreceiveaudio);
            this.groupBox2.Controls.Add(this.chkreceivevideo);
            this.groupBox2.Location = new System.Drawing.Point(648, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 483);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listen";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(456, 354);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 23;
            this.label24.Text = "Events";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(453, 380);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 100);
            this.listBox1.TabIndex = 22;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonWMV);
            this.groupBox5.Controls.Add(this.radioButtonMP4);
            this.groupBox5.Location = new System.Drawing.Point(20, 428);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(149, 54);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // radioButtonWMV
            // 
            this.radioButtonWMV.AutoSize = true;
            this.radioButtonWMV.Location = new System.Drawing.Point(68, 26);
            this.radioButtonWMV.Name = "radioButtonWMV";
            this.radioButtonWMV.Size = new System.Drawing.Size(45, 16);
            this.radioButtonWMV.TabIndex = 1;
            this.radioButtonWMV.Text = "WMV";
            this.radioButtonWMV.UseVisualStyleBackColor = true;
            // 
            // radioButtonMP4
            // 
            this.radioButtonMP4.AutoSize = true;
            this.radioButtonMP4.Checked = true;
            this.radioButtonMP4.Location = new System.Drawing.Point(4, 26);
            this.radioButtonMP4.Name = "radioButtonMP4";
            this.radioButtonMP4.Size = new System.Drawing.Size(41, 16);
            this.radioButtonMP4.TabIndex = 0;
            this.radioButtonMP4.TabStop = true;
            this.radioButtonMP4.Text = "MP4";
            this.radioButtonMP4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtmp4audiosamplerate);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtmp4framerate);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtmp4audiobitrate);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtmp4videobitrate);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtmp4audiochannels);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtmp4height);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtmp4width);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(175, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 94);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MP4";
            // 
            // txtmp4audiosamplerate
            // 
            this.txtmp4audiosamplerate.Location = new System.Drawing.Point(211, 58);
            this.txtmp4audiosamplerate.Name = "txtmp4audiosamplerate";
            this.txtmp4audiosamplerate.Size = new System.Drawing.Size(51, 18);
            this.txtmp4audiosamplerate.TabIndex = 13;
            this.txtmp4audiosamplerate.Text = "44100";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(127, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 12);
            this.label23.TabIndex = 12;
            this.label23.Text = "Audio Samplerate";
            // 
            // txtmp4framerate
            // 
            this.txtmp4framerate.Location = new System.Drawing.Point(78, 58);
            this.txtmp4framerate.Name = "txtmp4framerate";
            this.txtmp4framerate.Size = new System.Drawing.Size(51, 18);
            this.txtmp4framerate.TabIndex = 11;
            this.txtmp4framerate.Text = "25";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 12);
            this.label22.TabIndex = 10;
            this.label22.Text = "Frame Rate";
            // 
            // txtmp4audiobitrate
            // 
            this.txtmp4audiobitrate.Location = new System.Drawing.Point(211, 38);
            this.txtmp4audiobitrate.Name = "txtmp4audiobitrate";
            this.txtmp4audiobitrate.Size = new System.Drawing.Size(51, 18);
            this.txtmp4audiobitrate.TabIndex = 9;
            this.txtmp4audiobitrate.Text = "96000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(147, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 12);
            this.label21.TabIndex = 8;
            this.label21.Text = "Audio Bitrate";
            // 
            // txtmp4videobitrate
            // 
            this.txtmp4videobitrate.Location = new System.Drawing.Point(76, 40);
            this.txtmp4videobitrate.Name = "txtmp4videobitrate";
            this.txtmp4videobitrate.Size = new System.Drawing.Size(51, 18);
            this.txtmp4videobitrate.TabIndex = 7;
            this.txtmp4videobitrate.Text = "4600000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 12);
            this.label20.TabIndex = 6;
            this.label20.Text = "Video Bitrate";
            // 
            // txtmp4audiochannels
            // 
            this.txtmp4audiochannels.Location = new System.Drawing.Point(78, 79);
            this.txtmp4audiochannels.Name = "txtmp4audiochannels";
            this.txtmp4audiochannels.Size = new System.Drawing.Size(51, 18);
            this.txtmp4audiochannels.TabIndex = 5;
            this.txtmp4audiochannels.Text = "2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "Audio Channel";
            // 
            // txtmp4height
            // 
            this.txtmp4height.Location = new System.Drawing.Point(211, 17);
            this.txtmp4height.Name = "txtmp4height";
            this.txtmp4height.Size = new System.Drawing.Size(51, 18);
            this.txtmp4height.TabIndex = 3;
            this.txtmp4height.Text = "480";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(147, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "Height";
            // 
            // txtmp4width
            // 
            this.txtmp4width.Location = new System.Drawing.Point(76, 16);
            this.txtmp4width.Name = "txtmp4width";
            this.txtmp4width.Size = new System.Drawing.Size(51, 18);
            this.txtmp4width.TabIndex = 1;
            this.txtmp4width.Text = "720";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "Width";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioAspectRatio3);
            this.groupBox3.Controls.Add(this.RadioAspectRatio2);
            this.groupBox3.Controls.Add(this.RadioAspectRatio1);
            this.groupBox3.Location = new System.Drawing.Point(24, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 52);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aspect Ratio of Max Video Window";
            // 
            // RadioAspectRatio3
            // 
            this.RadioAspectRatio3.AutoSize = true;
            this.RadioAspectRatio3.Location = new System.Drawing.Point(153, 18);
            this.RadioAspectRatio3.Name = "RadioAspectRatio3";
            this.RadioAspectRatio3.Size = new System.Drawing.Size(53, 16);
            this.RadioAspectRatio3.TabIndex = 2;
            this.RadioAspectRatio3.Text = "Stretch";
            this.RadioAspectRatio3.UseVisualStyleBackColor = true;
            // 
            // RadioAspectRatio2
            // 
            this.RadioAspectRatio2.AutoSize = true;
            this.RadioAspectRatio2.Location = new System.Drawing.Point(85, 18);
            this.RadioAspectRatio2.Name = "RadioAspectRatio2";
            this.RadioAspectRatio2.Size = new System.Drawing.Size(41, 16);
            this.RadioAspectRatio2.TabIndex = 1;
            this.RadioAspectRatio2.Text = "16:9";
            this.RadioAspectRatio2.UseVisualStyleBackColor = true;
            // 
            // RadioAspectRatio1
            // 
            this.RadioAspectRatio1.AutoSize = true;
            this.RadioAspectRatio1.Checked = true;
            this.RadioAspectRatio1.Location = new System.Drawing.Point(12, 18);
            this.RadioAspectRatio1.Name = "RadioAspectRatio1";
            this.RadioAspectRatio1.Size = new System.Drawing.Size(36, 16);
            this.RadioAspectRatio1.TabIndex = 0;
            this.RadioAspectRatio1.TabStop = true;
            this.RadioAspectRatio1.Text = "4:3";
            this.RadioAspectRatio1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 402);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 16);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Max First Video Window";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Capture to File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 13;
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(562, 293);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(19, 23);
            this.SelectImage.TabIndex = 12;
            this.SelectImage.Text = "...";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // textImage
            // 
            this.textImage.Location = new System.Drawing.Point(281, 298);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(282, 18);
            this.textImage.TabIndex = 11;
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(45, 17);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(505, 277);
            this.axVideoChatReceiver1.TabIndex = 10;
            this.axVideoChatReceiver1.OnNewUserConnection += new AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnNewUserConnectionEventHandler(this.axVideoChatReceiver1_OnNewUserConnection);
            this.axVideoChatReceiver1.OnUserConnectionLost += new AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnUserConnectionLostEventHandler(this.axVideoChatReceiver1_OnUserConnectionLost);
            // 
            // chkreceiveaudio
            // 
            this.chkreceiveaudio.Checked = true;
            this.chkreceiveaudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkreceiveaudio.Location = new System.Drawing.Point(160, 300);
            this.chkreceiveaudio.Name = "chkreceiveaudio";
            this.chkreceiveaudio.Size = new System.Drawing.Size(128, 16);
            this.chkreceiveaudio.TabIndex = 6;
            this.chkreceiveaudio.Text = "Received Audio Stream";
            // 
            // chkreceivevideo
            // 
            this.chkreceivevideo.Checked = true;
            this.chkreceivevideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkreceivevideo.Location = new System.Drawing.Point(24, 300);
            this.chkreceivevideo.Name = "chkreceivevideo";
            this.chkreceivevideo.Size = new System.Drawing.Size(120, 16);
            this.chkreceivevideo.TabIndex = 5;
            this.chkreceivevideo.Text = "Receive Video Stream";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(844, 597);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 26);
            this.button6.TabIndex = 17;
            this.button6.Text = "Snapshot";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 602);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 18);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(655, 608);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "Video Window Index";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(876, 543);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Read IP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(750, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Disconnect";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start Listening";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(757, 19);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(102, 18);
            this.textUserID.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(691, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "User ID";
            // 
            // textConfNo
            // 
            this.textConfNo.Location = new System.Drawing.Point(565, 19);
            this.textConfNo.Name = "textConfNo";
            this.textConfNo.Size = new System.Drawing.Size(94, 18);
            this.textConfNo.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(454, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Conference Number";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(973, 596);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 26);
            this.button7.TabIndex = 32;
            this.button7.Text = "Show one To One Mode";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1103, 596);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 25);
            this.button8.TabIndex = 33;
            this.button8.Text = "Close one To One Mode";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtPeertoPeerListenIP
            // 
            this.txtPeertoPeerListenIP.Location = new System.Drawing.Point(186, 2);
            this.txtPeertoPeerListenIP.Name = "txtPeertoPeerListenIP";
            this.txtPeertoPeerListenIP.Size = new System.Drawing.Size(80, 18);
            this.txtPeertoPeerListenIP.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(150, 12);
            this.label25.TabIndex = 35;
            this.label25.Text = "Listening IP (For one to one mode)";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(4, 11);
            this.ClientSize = new System.Drawing.Size(1265, 679);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtPeertoPeerListenIP);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblaudiobitrate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblvideobitrate);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cboaudioquality);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textConfNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboaudiocomplex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtConnectPortNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtconnectIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chksendaudio);
            this.Controls.Add(this.chksendvideo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVideobitrate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtframerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbovideoformat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboaudiodevice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbovideodevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Form1";
            this.Text = "Video Chat Pro ActiveX Control ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form2());

			
		}



		private void cbovideodevice_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			int ivideodevicecount;
			int iaudiodevicecount;
            string strApp;
            int iFindIndex;
			int i;

            clrTransColor = Color.Black;


             strApp = Application.ExecutablePath;

            iFindIndex = strApp.IndexOf("Examples");

            if(iFindIndex !=-1)
            {
                txtoverlayimage.Text = strApp.Substring(0, iFindIndex) + "image.bmp";
            }



            ivideodevicecount = axVideoChatSender1.GetVideoDeviceCount();
		
			for(i=0; i<ivideodevicecount; i++)
			{

                cbovideodevice.Items.Add(axVideoChatSender1.GetVideoDeviceName((short)i));

			}
			if(cbovideodevice.Items.Count >0)
				cbovideodevice.SelectedIndex=0;

            iaudiodevicecount = axVideoChatSender1.GetAudioDeviceCount();

			for(i=0; i< iaudiodevicecount;i++)
                cboaudiodevice.Items.Add(axVideoChatSender1.GetAudioDeviceName((short)i));

			if(cboaudiodevice.Items.Count >0)
				cboaudiodevice.SelectedIndex=0;

			cbovideoformat.Items.Add("160x120");
			cbovideoformat.Items.Add("176x144");
			cbovideoformat.Items.Add("320x240");
			cbovideoformat.Items.Add("352x288");
			cbovideoformat.Items.Add("640x480");
            cbovideoformat.Items.Add("1280x720");
            cbovideoformat.Items.Add("1920x1080");
            cbovideoformat.Items.Add("1920x1280");

			cbovideoformat.SelectedIndex=4;

		
			cboaudiocomplex.Items.Add("0");
			cboaudiocomplex.Items.Add("1");
			cboaudiocomplex.Items.Add("2");
			cboaudiocomplex.Items.Add("3");
			cboaudiocomplex.SelectedIndex=0;


			
			for(i=0;i<=10;i++)
			{
			

				cboaudioquality.Items.Add(i.ToString());

			}
			cboaudioquality.SelectedIndex=8;


    	}

  
		private void button1_Click(object sender, System.EventArgs e)
		{

            axVideoChatSender1.OverlayType = 1;

            axVideoChatSender1.VideoDevice = (short)cbovideodevice.SelectedIndex;

            axVideoChatSender1.AudioDevice = (short)cboaudiodevice.SelectedIndex;


            axVideoChatSender1.VideoFormat = (short)cbovideoformat.SelectedIndex;
            axVideoChatSender1.FrameRate = Convert.ToInt32(txtframerate.Text, 10);
            axVideoChatSender1.VideoBitrate = Convert.ToInt32(txtVideobitrate.Text, 10);
            axVideoChatSender1.AudioComplexity = (short)cboaudiocomplex.SelectedIndex;
            axVideoChatSender1.AudioQuality = (short)cboaudioquality.SelectedIndex;
            axVideoChatSender1.SendAudioStream = chksendaudio.Checked;
            axVideoChatSender1.SendVideoStream = chksendvideo.Checked;

            axVideoChatSender1.ConferenceNumber = Convert.ToInt32(textConfNo.Text);
            axVideoChatSender1.ConferenceUserID = Convert.ToInt32(textUserID.Text);

            int iResult = axVideoChatSender1.Connect(txtconnectIP.Text, Convert.ToInt32(txtConnectPortNo.Text, 10));

		


		}

		private void button3_Click(object sender, System.EventArgs e)
		{
             if(checkBox2.Checked==true)
                 axVideoChatReceiver1.VideoWindowAutoMax = true;
             else
                axVideoChatReceiver1.VideoWindowAutoMax = false;


             if (RadioAspectRatio1.Checked)
                 axVideoChatReceiver1.VideoWindowAspectRatio = 0;
             else if (RadioAspectRatio2.Checked)
                 axVideoChatReceiver1.VideoWindowAspectRatio = 1;
             else if (RadioAspectRatio3.Checked)
                 axVideoChatReceiver1.VideoWindowAspectRatio = 2;

             if (radioButtonMP4.Checked)
                 axVideoChatReceiver1.CaptureFileType = 0;
             else
                 axVideoChatReceiver1.CaptureFileType = 1;

        
             if (checkBox1.Checked)
             {
                 if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
                 {
                     axVideoChatReceiver1.CaptureMode = true;
                     axVideoChatReceiver1.CaptureOutputFolder = folderBrowserDialog1.SelectedPath;

                     axVideoChatReceiver1.MP4Width =(short) Convert.ToInt32(txtmp4width.Text);
                     axVideoChatReceiver1.MP4Height = (short)Convert.ToInt32(txtmp4height.Text);

                     axVideoChatReceiver1.MP4Videobitrate = Convert.ToInt32(txtmp4videobitrate.Text);
                     axVideoChatReceiver1.MP4Audiobitrate = Convert.ToInt32(txtmp4audiobitrate.Text);
                     axVideoChatReceiver1.MP4Audiochannel = (short)Convert.ToInt32(this.txtmp4audiochannels.Text);
                     axVideoChatReceiver1.MP4AudioSamplerate = Convert.ToInt32(txtmp4audiosamplerate.Text);
                     axVideoChatReceiver1.MP4FrameRate = (short)Convert.ToInt32(txtmp4framerate.Text);




                   
                 }
             }
             else
                 axVideoChatReceiver1.CaptureMode = false;
       


            axVideoChatReceiver1.ReceiveAudioStream = chkreceivevideo.Checked;
            axVideoChatReceiver1.ReceiveVideoStream = chkreceivevideo.Checked;
            axVideoChatReceiver1.ReceiverVideoNoVideoImage(textImage.Text);

            axVideoChatReceiver1.ConferenceNumber = Convert.ToInt32(textConfNo.Text);
            axVideoChatReceiver1.ConferenceUserID = Convert.ToInt32(textUserID.Text);
            bool bResult =false;
            if(txtPeertoPeerListenIP.Text != "0")

                bResult = axVideoChatReceiver1.Listen(txtPeertoPeerListenIP.Text, Convert.ToInt32(txtConnectPortNo.Text, 10));
            else
                bResult = axVideoChatReceiver1.Listen(txtconnectIP.Text , Convert.ToInt32(txtConnectPortNo.Text, 10));
        
            button3.Enabled = false;
            button4.Enabled = true;


		}

		private void button2_Click(object sender, System.EventArgs e)
		{
            axVideoChatSender1.Disconnect();

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
            axVideoChatReceiver1.Disconnect();

            button3.Enabled = true;
            button4.Enabled = false;

		}

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(axVideoChatReceiver1.GetIPAddress().ToString());


        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "bmp file(*.bmp)|*.bmp";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textImage.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG File (*.jpg)|*.jpg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                          axVideoChatReceiver1.SnapShot(Convert.ToInt32(textBox1.Text), saveFileDialog1.FileName);
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            axVideoChatReceiver1.ShowOneToOneMode((short)Convert.ToInt32(textBox1.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axVideoChatReceiver1.CloseOneToOneMode();
      
        }

        private void axVideoChatReceiver1_OnNewUserConnection(object sender, AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnNewUserConnectionEvent e)
        {
            listBox1.Items.Add("User ID:" + e.iUserID.ToString() + " Confer :" + e.iConferenceNumber.ToString());

        }

        private void axVideoChatReceiver1_OnUserConnectionLost(object sender, AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnUserConnectionLostEvent e)
        {
            listBox1.Items.Add("Disconnected User ID:" + e.iUserID.ToString() + " Confer :" + e.iConferenceNumber.ToString());

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            opener.Close();
           
        }

        private void btnseloverlayimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG File (*.jpg)|*.jpg|TIFF File (*.tif)|*.tif|PNG File (*.png)|*.png";

            if (openFileDialog1.ShowDialog()== DialogResult.OK )
            {
                txtoverlayimage.Text = openFileDialog1.FileName;
            }

        }

        private void btnoverlayimagetranscolor_Click(object sender, EventArgs e)
        {
              ColorDialog  cd  =new ColorDialog();

            if ( cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                clrTransColor = cd.Color;
                axVideoChatSender1.SetOverlayImageTransColor((short)cd.Color.R,(short)cd.Color.G, (short)cd.Color.B,Convert.ToInt16(txtoverlayimagealpha.Text));
            }
                
        }

        private void btnclearimage_Click(object sender, EventArgs e)
        {
            txtoverlayimage.Text ="";
            axVideoChatSender1.SetOverlayImage("");
     
        }

        private void btnoverlayimagedraw_Click(object sender, EventArgs e)
        {
          
           
                axVideoChatSender1.SetOverlayImage(txtoverlayimage.Text);
                axVideoChatSender1.SetOverlayImagePos(Convert.ToInt32(txtoverlayimagex.Text), Convert.ToInt32(txtoverlayimagey.Text));
                axVideoChatSender1.SetOverlayImageTransColor((short)clrTransColor.R, (short)clrTransColor.G, (short)clrTransColor.B, Convert.ToInt16(txtoverlayimagealpha.Text));
      

        }

        private void axVideoChatSender1_SendStream(object sender, AxVideoChatSenderLib._DvideochatEvents_SendStreamEvent e)
        {
             lblvideobitrate.Text = e.fVideoBitrate.ToString();
             lblaudiobitrate.Text = e.fAudioBitrate.ToString();
        }
       
	}
}
