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

namespace Bai03_Client
{
    public partial class Form1 : Form
    {
        IPEndPoint ipc = new IPEndPoint(IPAddress.Loopback, 1234);
        UdpClient client = new UdpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            
            byte[] rec = client.Receive(ref ipc);
            txtIP.Text = Encoding.ASCII.GetString(rec);
            byte[] sendRespone = Encoding.ASCII.GetBytes("Nhan thanh cong.");
            client.Send(sendRespone, sendRespone.Length); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
               
            client.Connect(ipc);
            byte[] sendRequest = Encoding.ASCII.GetBytes("Cap phat IP dong.");
            client.Send(sendRequest, sendRequest.Length);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
    }
}
