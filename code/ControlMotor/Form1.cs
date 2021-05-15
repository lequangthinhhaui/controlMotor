using System;
using System.Windows.Forms;

namespace ControlMotor
{
    public partial class Form1 : Form
    {
        string serialDataIn;
        sbyte indexOfA, indexOfB, indexOfC;
        string dataSpeed;
        string dataDirect;
        string temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmScanTime.Enabled = true;
            serialPort1.Open();

        }

        private void tmScanTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void mainTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbDirection.SelectedIndex.ToString() == "0")
            {
                serialPort1.Write("forward");
            }
            else
                serialPort1.Write("reverse");*/
        }

        private void cbDirection_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            serialPort1.Write(temp + "W" + cbDirection.SelectedIndex.ToString()+ "W" + "0");
        }

        private void txtSetSpeed_TextChanged(object sender, EventArgs e)
        {
            if(txtSetSpeed.Text != "")
            {
                int numval = int.Parse(txtSetSpeed.Text);
                if(numval < 1000 && numval > 99)
                {
                    temp = "0" + txtSetSpeed.Text;
                }
                else if (numval < 100 && numval > 9)
                {
                    temp = "00" + txtSetSpeed.Text;
                }
                else
                    temp = txtSetSpeed.Text;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0000" + "W" + "0" +"W" + "0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0000" + "W" + "0" + "W" + "1");
            panel2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0000" + "W" + "0" + "W" + "0");
            panel2.Enabled = true;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProceessData));
        }

        private void ProceessData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                indexOfB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                indexOfC = Convert.ToSByte(serialDataIn.IndexOf("C"));
                dataSpeed = serialDataIn.Substring(indexOfA + 1, indexOfB - 1);
                dataDirect = serialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                lblCurrentSpeedDisplay.Text = dataSpeed;
                if(dataDirect == "T")
                    lblMotorDirection.Text = "Foward";
                if (dataDirect == "N")
                    lblMotorDirection.Text = "Reverse";
                //textBox2.Text = dataSensor2;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
