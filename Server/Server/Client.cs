using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace Server
{
    class Client
    {
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        public Socket socket
        {
            get;
            set;
        }


        public Client(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            writer.AutoFlush=true;
            Thread t3 = new Thread(() => Readhanle());
            t3.Start();
            
        }
        public void Readhanle()
        {
            string str;
            while ((str=reader.ReadLine())!=null)
            {
                string[] data = Regex.Split(str, "#@#");
                if (data[0].Equals(" "))
                {

                }
            }
        }
        public void Clientclose()
        {
            socket.Close();
        }
    }
}
