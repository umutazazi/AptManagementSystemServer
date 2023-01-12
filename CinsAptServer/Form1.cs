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
            getWeatherAndCurrency(weather1.getWeather() + currency1.getCurrency());
            StartServer();
            
        }


        void getWeatherAndCurrency(string data)
        {
            string degree;
            string city;
            string weather;
            string usd;
            string eur;

            string[] dataReceived = data.Split("\n");
            degree = dataReceived[0];
            city = dataReceived[1];
            weather = dataReceived[2];
            usd = dataReceived[3];
            eur = dataReceived[4];

            degreeLabel.Text = degree;
            cityLabel.Text = city;
            weatherLabel.Text = weather;
            usdLabel.Text = usd;
            eurLabel.Text = eur;










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
            server.BeginAccept(new AsyncCallback(AcceptCallBack), null);
            clientsListBox.Items.Add("Connected to: " + socket.RemoteEndPoint.ToString());
           SendWeatherandCurrencyData(socket);

        }

        private void SendWeatherandCurrencyData(Socket socket)
        {
            
            byte[] bytesToSend = Encoding.ASCII.GetBytes(weather1.getWeather()+currency1.getCurrency());
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

        private void button1_Click(object sender, EventArgs e)
        {
            TcpChatServer server = new TcpChatServer();
            server.Show();
        }
    }
}