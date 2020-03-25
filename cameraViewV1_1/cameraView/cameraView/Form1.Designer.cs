namespace cameraView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.list_port = new System.Windows.Forms.ComboBox();
            this.btDisConn = new System.Windows.Forms.Button();
            this.btConn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baud_list = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.info_ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(5, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 163;
            this.button1.Text = "Update Comport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_port
            // 
            this.list_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_port.FormattingEnabled = true;
            this.list_port.Location = new System.Drawing.Point(133, 21);
            this.list_port.Name = "list_port";
            this.list_port.Size = new System.Drawing.Size(234, 33);
            this.list_port.TabIndex = 156;
            // 
            // btDisConn
            // 
            this.btDisConn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btDisConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDisConn.Location = new System.Drawing.Point(255, 100);
            this.btDisConn.Name = "btDisConn";
            this.btDisConn.Size = new System.Drawing.Size(116, 35);
            this.btDisConn.TabIndex = 161;
            this.btDisConn.Text = "Disconnect";
            this.btDisConn.UseVisualStyleBackColor = true;
            this.btDisConn.Click += new System.EventHandler(this.btDisConn_Click);
            // 
            // btConn
            // 
            this.btConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btConn.Location = new System.Drawing.Point(133, 100);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(116, 35);
            this.btConn.TabIndex = 160;
            this.btConn.Text = "Connect";
            this.btConn.UseVisualStyleBackColor = true;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 157;
            this.label1.Text = "ComPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 158;
            this.label2.Text = "Baudrate";
            // 
            // baud_list
            // 
            this.baud_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud_list.FormattingEnabled = true;
            this.baud_list.Location = new System.Drawing.Point(133, 60);
            this.baud_list.Name = "baud_list";
            this.baud_list.Size = new System.Drawing.Size(234, 33);
            this.baud_list.TabIndex = 159;
            this.baud_list.SelectedIndexChanged += new System.EventHandler(this.baud_list_SelectedIndexChanged);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 165;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(79, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 166;
            this.label4.Text = "Disconnect";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 264);
            this.richTextBox1.TabIndex = 167;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(12, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 168;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.DarkBlue;
            this.info.Location = new System.Drawing.Point(393, 21);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(89, 18);
            this.info.TabIndex = 169;
            this.info.Text = "Resolution";
            // 
            // info_
            // 
            this.info_.AutoSize = true;
            this.info_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_.ForeColor = System.Drawing.Color.OrangeRed;
            this.info_.Location = new System.Drawing.Point(488, 21);
            this.info_.Name = "info_";
            this.info_.Size = new System.Drawing.Size(34, 18);
            this.info_.TabIndex = 170;
            this.info_.Text = "0x0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cameraView.Properties.Resources.preview;
            this.pictureBox1.Location = new System.Drawing.Point(380, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 321);
            this.pictureBox1.TabIndex = 164;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(986, 481);
            this.Controls.Add(this.info_);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_port);
            this.Controls.Add(this.btDisConn);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baud_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "Form1";
            this.Text = "JPG Serial Streaming (ThaiEasyElec.com)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox list_port;
        private System.Windows.Forms.Button btDisConn;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baud_list;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label info_;
        private System.Windows.Forms.Timer timer1;
    }
}

