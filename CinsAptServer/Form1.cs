using Microsoft.VisualBasic;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace CinsAptServer
{
    public partial class Form1 : Form
    {
        List<Socket> clientSockets = new List<Socket>();
        Socket server;
        byte[] buffer = new byte[1024];
        Weather weather1 = new Weather();
        Currency currency1 = new Currency();
      




        public Form1()
        {
          


            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            currentWeatherText.Text = weather1.getWeather();
            currencyText.Text = currency1.getCurrency();
            StartServer();
            
        }

       

     

       
       

       
        private void StartServer()
        {
           
            server= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            server.Bind(iep);
            server.Listen(5);
            server.BeginAccept(new AsyncCallback(AcceptCallBack), null);
           

           
        
        }
        private void AcceptCallBack(IAsyncResult AR)
        {
            Socket socket = server.EndAccept(AR);
            clientSockets.Add(socket);
            clientsListBox.Items.Add("Connected to: " + socket.RemoteEndPoint.ToString());
            SendWeatherData(socket);

        }

        private void SendWeatherData(Socket socket)
        {
            
            byte[] bytesToSend = Encoding.ASCII.GetBytes(weather1.getWeather());
            socket.BeginSend(bytesToSend, 0, bytesToSend.Length, SocketFlags.None, new AsyncCallback(SendData), socket);
           
        }
        void SendData(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int sent = socket.EndSend(AR);
            
        }


        private void clientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      

       
       


    }
}