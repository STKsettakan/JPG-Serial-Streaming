using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Threading;
using System.Text.RegularExpressions;



namespace cameraView
{
    public partial class Form1 : Form
    {
        int flag_soi = 0;
        int flag_dbg = 0;
        byte[] serial_buffer_jpg;
        byte[] buffer_jpg;
        Int32 jpg_length = 0;
        Int32 cnt_buffer_jpg = 0;
        byte[] bytes;
        int intBytes;
        bool closeprogram;
        string dbgMsg="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] strbaud = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "250000", "500000", "1000000", "1280000", "2000000", "3000000" };
            baud_list.Items.Clear();
            foreach (string s in strbaud)
            {
                baud_list.Items.Add(s);
            }
            baud_list.SelectedIndex = 13;
            list_comport();
            serial_buffer_jpg = new byte[1000 * 1000 * 4];
            buffer_jpg = new byte[1000 * 1000 * 4];
           // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            btDisConn.Enabled = false;
        }
        private void list_comport()
        {
            string[] s = SerialPort.GetPortNames();
            int i = 0;
            list_port.Items.Clear();
            foreach (string port in s)
            {
                list_port.Items.Add(s[i]);
                i++;
            }
            if (i != 0)
            {
                list_port.SelectedIndex = 0;
                btConn.Enabled = true;
            }    
            else
            {
                MessageBox.Show("No ComPort!!!");
                list_port.ResetText();
                btConn.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_comport();
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                if (list_port.Items.Count > 0) // If there are ports available
                {
                    try
                    {
                        serialPort.BaudRate = int.Parse(baud_list.Text);
                        serialPort.DataBits = 8;
                        serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                        serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                        serialPort.PortName = list_port.Text;
                        serialPort.Open();
                        label4.Text = "Connected";
                        btDisConn.Enabled = true;
                        btConn.Enabled = false;
                    }
                    catch
                    {
                        string str = "Access to the port "+ list_port.Text + " is denied.";
                        MessageBox.Show(str);
                    }
                }
            }
        }
           
        private void btDisConn_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                closeprogram = false;
                Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit));
                CloseDown.Start();
                label4.Text = "Disconnected";
                btConn.Enabled = true;
                btDisConn.Enabled = false;
            }
        }
        private void CloseSerialOnExit()
        {
            try

            {

                serialPort.Close(); // Close port

            }

            catch (Exception ex)

            {

               // MessageBox.Show(ex.Message); //catch any serial port closing error messages

            }
            if (closeprogram)
                this.Invoke(new EventHandler(NowClose)); //now close back in the main thread

        }
        private void NowClose(object sender, EventArgs e)

        {
            this.Close(); //now close the form
        }


        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(Serialprocess));
        }

        private void debugprocess(object sender, EventArgs e)
        {
            for (int cnt = 0; cnt < intBytes; cnt++)
            {
                dbgMsg += System.Text.Encoding.ASCII.GetString(new[] { bytes[cnt] });
            }

            string[] lines = Regex.Split(dbgMsg, "<DBG>");
            if (lines.Length > 0)
            {
                foreach (string line in lines)
                {
                    int index = line.IndexOf("</DBG>");
                    if (index != -1)
                    {
                        string s = line.Substring(0, index);
                        if (s.Length == 0)
                            richTextBox1.Clear();
                        else
                            richTextBox1.AppendText(line.Substring(0, index) + "\r\n");
                        richTextBox1.ScrollToCaret();  
                    }

                }
                int index2 = dbgMsg.LastIndexOf("</DBG>");
                if (index2 != -1)
                {
                    string buf = dbgMsg.Substring(index2+6);
                    dbgMsg = buf;
                   
                }

               
            }



            /*    for (int i = 0; i < lines.Length; i++)
              {
                 index1 = dbgMsg.IndexOf("<DBG>", index1);
                  index2 = dbgMsg.IndexOf("</DBG>", index2);

                  if ((index1 != -1) && (index2 != -1))
                  {
                      if (index2 <= index1)
                      {
                          dbgMsg = "";
                          return;
                      }
                      int len = index2 - (index1 + 5);
                      if (len == 0)
                          richTextBox1.Clear();
                      richTextBox1.AppendText(dbgMsg.Substring(index1 + 5, len) + "\r\n");
                      dbgMsg = "";
                      richTextBox1.ScrollToCaret();
                  }

        }
        */
            if (dbgMsg.Length>2000)
                dbgMsg = "";

        }
        private void Serialprocess(object sender, EventArgs e)
        {
            try
            {
                intBytes = serialPort.BytesToRead;
                bytes = new byte[intBytes];
                serialPort.Read(bytes, 0, intBytes);
                if (intBytes == 0)
                    return;
               
               this.Invoke(new EventHandler(debugprocess));
                for (int cnt = 0; cnt < intBytes; cnt++)
                {
                    if (flag_soi == 0)
                    {

                        if (cnt + 1 < intBytes)
                        {
                            if ((bytes[cnt] == 0xFF) && (bytes[cnt + 1] == 0xD8))
                            {
                                flag_soi = 1;
                                cnt_buffer_jpg = 0;
                            }
                            else
                            {
                                
                                 
                                
                                // dbgMsg += System.Text.Encoding.ASCII.GetString(new[] { bytes[cnt] });
                                //this.Invoke(new EventHandler(debugprocess));
                                //Thread.Sleep(1);
                            }
                            
                        }
                    }
                    if (flag_soi == 1)
                    {
                        serial_buffer_jpg[cnt_buffer_jpg] = bytes[cnt];
                        cnt_buffer_jpg++;
                        if (cnt > 1)
                        {
                            if ((bytes[cnt] == 0xD9) && (bytes[cnt - 1] == 0xFF))
                            {
                                flag_soi = 0;
                                Array.Copy(serial_buffer_jpg, buffer_jpg, cnt_buffer_jpg);
                                jpg_length = cnt_buffer_jpg;
                                this.Invoke(new EventHandler(DisplayPicture));
                                dbgMsg = "";
                            }
                        }
                    }
                } 
            }
            catch
            {
            }
            

        }
        private void debugprocess_2()
        {

        }
        private void DisplayPicture(object sender, EventArgs e)
        {
          try
          {
                Image newImage = Image.FromStream(new MemoryStream(buffer_jpg, 0, jpg_length));
                Size size = new Size(newImage.Width, newImage.Height);
                pictureBox1.Size = size;
                pictureBox1.Image = newImage;
                label4.Text = "OK";
                int pw = pictureBox1.Image.Width;
                int ph = pictureBox1.Image.Height;
                info_.Text =  pw.ToString()+"x"+ph.ToString();
            }
          catch (Exception ex)
          {
                label4.Text = "Invalid Data !!! Please check baudrate";
          }
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                e.Cancel = true;
                closeprogram = true;
                Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit));
                CloseDown.Start();
            }
        }

        private void baud_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                closeprogram = false;
                Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit));
                CloseDown.Start();
                label4.Text = "Disconnected";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.ScrollToCaret();
            //this.Size = new System.Drawing.Size(800, 800);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
