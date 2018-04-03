using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bai03_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[10];
            string rawIP = "192.168.10.";
            //Server co 10ip dong
            for(int i = 0;i<a.Length;i++)
                a[i] = rawIP + i.ToString() ;
            IPEndPoint ips = new IPEndPoint(IPAddress.Any, 1234);
            IPEndPoint ipc = new IPEndPoint(IPAddress.Any, 0);
            UdpClient server = new UdpClient(ips);
            while (true)
            {
                byte[] rec = server.Receive(ref ipc);
                string recieveText = Encoding.ASCII.GetString(rec);
                Console.WriteLine(recieveText);
                string s = randomIP(a);
                byte[] send = Encoding.UTF8.GetBytes(s);
                server.Send(send, send.Length, ipc);
                byte[] recRespone = server.Receive(ref ipc);
                Console.WriteLine(Encoding.ASCII.GetString(recRespone));
            }
            //server.Close();


        }
        static string randomIP(string[] a)
        {
            Random r = new Random();
            string s = a[r.Next(0, 11)];
            return s;
        }
    }
}
