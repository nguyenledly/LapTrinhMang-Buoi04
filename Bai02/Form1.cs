using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            int startPort = Convert.ToInt32(txtFrom.Text);
            int endPoint = Convert.ToInt32(txtTo.Text);

            progressBar1.Value = 0;

            progressBar1.Maximum = endPoint - startPort + 1;

            Cursor.Current = Cursors.WaitCursor;

            for (int currPort = startPort; currPort<=endPoint;currPort++)
            {
                TcpClient tcpPortScan = new TcpClient();
                try
                {
                    tcpPortScan.Connect(txtIPAddress.Text, currPort);
                    txtDisplay.AppendText("Port " + currPort + " open.\n");
                }
                catch
                {
                    txtDisplay.AppendText("Port " + currPort + " closed.\n");
                }
                progressBar1.PerformStep();
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void btnUDPScan_Click(object sender, EventArgs e)
        {
            byte[] send = Encoding.ASCII.GetBytes("hello");
            IPEndPoint ipe;
            int startPort = Convert.ToInt32(txtFrom.Text);
            int endPoint = Convert.ToInt32(txtTo.Text);

            progressBar1.Value = 0;

            progressBar1.Maximum = endPoint - startPort + 1;

            Cursor.Current = Cursors.WaitCursor;

            for (int currPort = startPort; currPort <= endPoint; currPort++)
            {
                ipe = new IPEndPoint(IPAddress.Parse(txtIPAddress.Text), currPort);
                UdpClient udpPortScan = new UdpClient();
                udpPortScan.Connect(ipe);
                udpPortScan.Send(send, send.Length);
                try
                {
                    udpPortScan.Receive(ref ipe);
                    
                    txtDisplay.AppendText("Port " + currPort + " open.\n");
                }
                catch
                {
                    txtDisplay.AppendText("Port " + currPort + " closed.\n");
                }
                progressBar1.PerformStep();
            }
            Cursor.Current = Cursors.Arrow;
        }
    }
}
