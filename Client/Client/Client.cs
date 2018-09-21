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
using System.Runtime.Serialization.Formatters.Binary;
using Server;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Client
{
    public class Client
    {
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private TcpClient cl;
        private BinaryFormatter bf = new BinaryFormatter();
        
        public int id
        {
            get;
            set;
        }
        public List<Khoahoc> kh_list
        {
            get;
            set;
        }
        public List<Sinhvien> sv_list
        {
            get;
            set;
        }
        public List<Diem> d_list
        {
            get;
            set;
        }
        private GUI gui;
        private string str="";
        public Client(GUI gui) { 
            this.gui=gui;
            sv_list = new List<Sinhvien>();
            kh_list = new List<Khoahoc>();
            d_list = new List<Diem>();
        }

        public void ClientStart(TcpClient cl)
        {
            this.cl = cl;
            stream = cl.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            writer.AutoFlush=true;
        }
        public void Readhandle()
        {
            string str;
            try
            {
                while (true)
                {
                    Listhandle(bf.Deserialize(stream));
                }  
            }
            
            catch(Exception ex)
            {
                writer.Close();
                reader.Close();
                stream.Close();
                Console.WriteLine(ex);
                Clientclose();
            }
            
        }

        public bool Login(int id, string password)
        {
            writer.WriteLine("Login#@#"+id+"#@#"+password);
            Listhandle(bf.Deserialize(stream));
            Console.WriteLine(str);
            if (str.Equals("LoginFail"))
            {
                    Clientclose();
                    return false;
            }
            else
            {
                Thread t = new Thread(() => Readhandle());
                t.IsBackground = true;
                t.Start();
                return true;
            }

        }
        public void Listhandle(object obj)
        {
            kh_list = new List<Khoahoc>();
            sv_list = new List<Sinhvien>();
            d_list = new List<Diem>();
            if (obj is List<Khoahoc>)
            {
                kh_list = (List<Khoahoc>)obj;
            }
            else if (obj is List<Sinhvien>)
            {
                sv_list = (List<Sinhvien>)obj;
            }
            else if (obj is List<Diem>)
            {
                d_list = (List<Diem>)obj;
            }
            else if(obj is string)
            {
                str = (string)obj;
            }
            gui.update();
        }
        public void send(string str)
        {
            try
            {
                writer.WriteLine(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        
        public void clear()
        {
            //while(stream.Read())
        }
        public void Clientclose()
        {
            cl.Close();
        }
    }
}
