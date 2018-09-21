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

namespace Server
{
    public class Client
    {
        private SQL sql = new SQL();
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private Sinhvien sinhvien;
        public Socket socket
        {
            get;
            set;
        }


        public Client(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            writer = new StreamWriter(stream);
            writer.AutoFlush = true;
            reader = new StreamReader(stream);
            Thread t = new Thread(() => Readhanle());
            t.IsBackground = true;
            t.Start();
        }
        public void Readhanle()
        {
            string str;
            try
            {
                while ((str = reader.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                    string[] data = Regex.Split(str, "#@#");
                    if (data[0].Equals("Bang"))
                    {
                        if (data[1].Equals("Khoahoc"))
                        {
                            listKhoahoc(data[2]);
                        }
                        else if (data[1].Equals("Danghoc"))
                        {
                            listDanghoc(data[2]);
                        }
                        else if (data[1].Equals("Dahoc"))
                        {
                            listDahoc(data[2]);
                        }
                        else if (data[1].Equals("Dangki"))
                        {
                            listDangki(data[2]);
                        }
                        else if (data[1].Equals("Sinhvien"))
                        {
                            listSinhvien(data[2], data[3]);
                        }
                        else if (data[1].Equals("Diem"))
                        {
                            listDiem(data[2]);
                        }
                    }
                    else if (data[0].Equals("Dangky"))
                    {
                        int idkh = int.Parse(data[1]);
                        Console.WriteLine(sql.SelectDiem(sinhvien.id, idkh).Count);
                        if (sql.SelectDiem(sinhvien.id, idkh).Count > 0)
                        {
                            sql.DeleteDiem(sql.SelectDiem(sinhvien.id, idkh)[0]);
                            foreach (Khoahoc kh in sinhvien.dang_ki)
                            {
                                if (kh.id == idkh)
                                {
                                    if (kh.danh_sach.Count() < kh.max_danhsach)
                                    {
                                        kh.trang_thai = "OPEN";
                                    }
                                    sinhvien.dang_ki.Remove(kh);
                                    sql.UpdateSinhvien(sinhvien);
                                    kh.danh_sach.Remove(sinhvien);
                                    sql.UpdateKhoahoc(kh);
                                }
                            }

                        }
                        else
                        {
                            foreach (Khoahoc kh in sql.SearchKhoahoc(""))
                            {
                                if (kh.id == idkh && kh.trang_thai.Equals("OPEN"))
                                {
                                    Diem diem = new Diem(sinhvien.id, kh.id, 0, 0, 0, 0);
                                    sql.InsertDiem(diem);
                                    Console.WriteLine("**");
                                    kh.danh_sach.Add(sinhvien);
                                    if (kh.danh_sach.Count() >= kh.max_danhsach)
                                    {
                                        kh.trang_thai = "CLOSE";
                                    }
                                    sql.UpdateKhoahoc(kh);
                                    sinhvien.dang_ki.Add(kh);
                                    sql.UpdateSinhvien(sinhvien);
                                }
                                
                            }
                        }
                        listKhoahoc(data[2]);
                        updatesv();
                    }
                    else if (data[0].Equals("Login"))
                    {
                        bool t = false;
                        foreach (Sinhvien sv in sql.SearchSinhvien(""))
                        {

                            if (int.Parse(data[1]) == sv.id && sv.password.Equals(data[2]))
                            {
                                sinhvien = sv;
                                listKhoahoc("");
                                t = true;
                            }
                        }
                        if (t == false)
                        {
                            send("LoginFail");
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writer.Close();
                reader.Close();
                stream.Close();
                Console.WriteLine(ex);
                Clientclose();
            }

        }
        public void listKhoahoc(string str)
        {
                sendlist(sql.SearchKhoahoc(str));
            
            updatesv();
        }
        public void listSinhvien(string str, string str2)
        {
            int idkh = int.Parse(str);
            List<Sinhvien> temp = new List<Sinhvien>();
            foreach (Khoahoc kh in sql.SearchKhoahoc(""))
            {
                if (idkh == kh.id)
                {
                    foreach (Sinhvien sv in kh.danh_sach)
                    {
                        foreach (Sinhvien sv2 in sql.SearchSinhvien(str2))
                        {
                            if (sv == sv2)
                            {
                                sv.password = "";
                                temp.Add(sv);
                            }
                        }

                    }
                        sendlist(temp);

                }
            }
            updatesv();
        }
        public void listDiem(String str)
        {
            
            int idkh = int.Parse(str);
                sendlist(sql.SelectDiem(sinhvien.id, idkh));
            
            updatesv();
        }
        public void listDanghoc(string str)
        {
            
            
            List<Khoahoc> temp = new List<Khoahoc>();
            foreach (Khoahoc kh1 in sinhvien.dang_hoc)
            {
                foreach (Khoahoc kh2 in sql.SearchKhoahoc(str))
                {
                    if (kh1.id == kh2.id)
                    {
                        temp.Add(kh2);
                        
                    }
                }
            }
                sendlist(temp);
            updatesv();
        }
        public void listDahoc(string str)
        {
            List<Khoahoc> temp = new List<Khoahoc>();
            foreach (Khoahoc kh1 in sinhvien.da_hoc)
            {
                foreach (Khoahoc kh2 in sql.SearchKhoahoc(str))
                {
                    if (kh1.id == kh2.id)
                    {
                        temp.Add(kh2);
                        
                    }
                }
            }
                sendlist(temp);
            updatesv();
        }
        public void listDangki(string str)
        {
            
            
            List<Khoahoc> temp = new List<Khoahoc>();
            foreach (Khoahoc kh1 in sinhvien.dang_ki)
            {
                foreach (Khoahoc kh2 in sql.SearchKhoahoc(str))
                {
                    if (kh1.id == kh2.id)
                    {
                        temp.Add(kh2);
                        
                    }
                }
            }
                sendlist(temp);

            
            Console.WriteLine(sinhvien.id);
            updatesv();
        }
        public void updatesv()
        {
            foreach (Sinhvien sv in sql.SearchSinhvien(""))
            {
                if (sinhvien.id == sv.id)
                {
                    sinhvien = sv;
                }
            }
        }
        public void send(string str)
        {

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, str);
        }
        public void sendlist(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, obj);
        }
        public void Clientclose()
        {
            socket.Close();
        }

    }
}
