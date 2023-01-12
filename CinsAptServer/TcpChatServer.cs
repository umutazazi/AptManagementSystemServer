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
        List<Socket> clientSockets = new List<Socket>();
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
         

            void AcceptConn(IAsyncResult AR)
            {
                Socket socket = server.EndAccept(AR);
                


                textBox1.Text = "Connected to: " + socket.RemoteEndPoint.ToString();
                string stringData = "Welcome to chat server";
                server.BeginAccept(new AsyncCallback(AcceptConn), server);
                clientSockets.Add(socket);
                byte[] message1 = Encoding.ASCII.GetBytes(stringData);
               
                    socket.BeginSend(message1, 0, message1.Length, SocketFlags.None,
               new AsyncCallback(SendData), socket);
               
               
           
            }

            void SendData(IAsyncResult AR)
            {
                Socket client = (Socket)AR.AsyncState;
                int sent = client.EndSend(AR);
               
                    client.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), client);
                
                
                
            }

            void ReceiveData(IAsyncResult AR)
            {
                Socket client = (Socket)AR.AsyncState;
                int recv = client.EndReceive(AR);

                string receivedData = Encoding.ASCII.GetString(data, 0, recv);
                listBox1.Items.Add(receivedData);
                byte[] message2 = Encoding.ASCII.GetBytes(receivedData);
               
              
                    client.BeginSend(message2, 0, message2.Length, SocketFlags.None,
                new AsyncCallback(SendData), client);
                
                    
                
                
            }
























        }
    }
}






    

        
