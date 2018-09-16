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

namespace Client
{
    public class Client
    {
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private TcpClient cl;

        public Client()
        {
        }

        public void ClientStart(TcpClient cl)
        {
            this.cl = cl;
            stream = cl.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            writer.AutoFlush=true;
            
        }
        public void Readhanle()
        {
            string str;
            while ((str=reader.ReadLine())!=null)
            {
                string[] data = Regex.Split(str, "#@#");
                if (data[0].Equals("Sign"))
                {

                }
            }
        }

        public bool Login(int id, string password)
        {
            writer.WriteLine("Login#@#"+id+"#@#"+password);
            string str;
            if((str = reader.ReadLine()) != null)
            {
                if (str.Equals("LoginFail"))
                {
                    Clientclose();
                    return false;
                }
                else if (str.Equals("LoginSuccess"))
                {
                    Thread t = new Thread(() => Readhanle());
                    t.Start();
                    return true;
                }
            }
            return false;
        }
        public void Clientclose()
        {
            cl.Close();
        }
    }
}
