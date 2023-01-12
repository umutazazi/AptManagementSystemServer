using Microsoft.VisualBasic;
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

namespace CinsAptServer
{
    public partial class TcpChatServer : Form
    {
        private byte[] data = new byte[1024];
        private int size = 1024;
        private Socket server;


        public TcpChatServer()
        {
            InitializeComponent();
            server = new Socket(AddressFamily.InterNetwork,
             SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9060);
            server.Bind(iep);
            server.Listen(5);
            server.BeginAccept(new AsyncCallback(AcceptConn), server);


















            void AcceptConn(IAsyncResult iar)
            {
                Socket oldserver = (Socket)iar.AsyncState;
                Socket client = oldserver.EndAccept(iar);
                textBox1.Text = "Connected to: " + client.RemoteEndPoint.ToString();
                string stringData = "Welcome to my server";
                server.BeginAccept(new AsyncCallback(AcceptConn), server);
                byte[] message1 = Encoding.ASCII.GetBytes(stringData);
                client.BeginSend(message1, 0, message1.Length, SocketFlags.None,
                new AsyncCallback(SendData), client);
            }
            void SendData(IAsyncResult iar)
            {
                Socket client = (Socket)iar.AsyncState;
                int sent = client.EndSend(iar);
                client.BeginReceive(data, 0, size, SocketFlags.None,
                new AsyncCallback(ReceiveData), client);
            }
            void ReceiveData(IAsyncResult iar)
            {
                Socket client = (Socket)iar.AsyncState;
                int recv = client.EndReceive(iar);

                string receivedData = Encoding.ASCII.GetString(data, 0, recv);
                listBox1.Items.Add(receivedData);
                byte[] message2 = Encoding.ASCII.GetBytes(receivedData);
                client.BeginSend(message2, 0, message2.Length, SocketFlags.None,
                new AsyncCallback(SendData), client);
            }







        }
    }
}






    

        
