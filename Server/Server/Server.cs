using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server
    {
        private IPAddress address = IPAddress.Parse("127.0.0.12");
        private const int PORT_NUMBER = 2222;
        public List<Client> client_list
        {
            get;
            set;
        }

        public void ServerStart()
        {
            client_list = new List<Client>();
            TcpListener listener = new TcpListener(address, PORT_NUMBER);
            listener.Start();
            Console.WriteLine("Server started on " + listener.LocalEndpoint);
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Connection received from " + socket.RemoteEndPoint);
                Client client = new Client(socket);
                client_list.Add(client);
            }
            
        }

        public void delClient(Socket socket)
        {
            foreach(Client cl in client_list)
            {
                if (SocketConnected(cl.socket))
                {
                    client_list.Remove(cl);
                }
            }
        }

        bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
    }
}
