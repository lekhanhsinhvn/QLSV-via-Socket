using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Server
{
    class SQL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public List<Sinhvien> sinhvien_list
        {
            get;
            set;
        }
        public List<Khoahoc> khoahoc_list
        {
            get;
            set;
        }
        public SQL()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "localhost";
            database = "qlsv";
            uid = "root";
            password = "gzrrapbblievm";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void InsertSinhvien(Sinhvien sv)
        {
            string query = "INSERT INTO sinhvien (tensinhvien, passwords, gioitinh, namsinh, sdt, diachi) VALUES('"
                                                    + sv.ten + "','" + sv.password + "','" + sv.gioi_tinh + "','" + sv.ngay_sinh.ToString() + "','" + sv.sdt + "','" + sv.diachi + "');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                try
                {
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        public void DeleteSinhvien(Sinhvien sv)
        {
            string query = "DELETE FROM sinhvien WHERE idsinhvien='" + sv.id.ToString() + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                try
                {
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public List<Sinhvien> SearchSinhvien(string str)
        {
            string query;
            if (string.IsNullOrEmpty(str))
            {
                query = "SELECT * from sinhvien";
            }
            else
            {
                query = "Select * from sinhvien WHERE tensinhvien like '%" + str + "%' OR namsinh like '%" + str + "%' OR sdt like '%" + str + "%' OR diachi like '%" + str + "%'";
            }
            List<Sinhvien> svsearch_list = new List<Sinhvien>();
            //Open connection
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string danghocstr = dataReader["danghoc"] + "";
                    List<Khoahoc> dang_hoc = new List<Khoahoc>();
                    if (!string.IsNullOrWhiteSpace(danghocstr))
                    {
                        string[] datadanghoc = Regex.Split(str, ",");
                        
                        for (int i = 0; i < datadanghoc.Length; i++)
                        {
                            foreach (Khoahoc kh in khoahoc_list)
                            {
                                if (int.Parse(datadanghoc[i]) == kh.id)
                                {
                                    dang_hoc.Add(kh);
                                }
                            }
                        }
                    }
                    
                    string dahocstr = dataReader["dahoc"] + "";
                    List<Khoahoc> da_hoc = new List<Khoahoc>();
                    if (!string.IsNullOrWhiteSpace(dahocstr))
                    {
                        string[] datadahoc = Regex.Split(str, ",");
                        
                        for (int i = 0; i < datadahoc.Length; i++)
                        {
                            foreach (Khoahoc kh in khoahoc_list)
                            {
                                if (int.Parse(datadahoc[i]) == kh.id)
                                {
                                    da_hoc.Add(kh);
                                }
                            }
                        }
                    }
                    
                    string dangkistr = dataReader["danghoc"] + "";
                    List<Khoahoc> dang_ki = new List<Khoahoc>();
                    if (!string.IsNullOrWhiteSpace(dangkistr))
                    {
                        string[] datadangki = Regex.Split(str, ",");

                        for (int i = 0; i < datadangki.Length; i++)
                        {
                            foreach (Khoahoc kh in khoahoc_list)
                            {
                                if (int.Parse(datadangki[i]) == kh.id)
                                {
                                    dang_ki.Add(kh);
                                }
                            }
                        }
                    }
                    
                    Sinhvien sv = new Sinhvien(int.Parse(dataReader["idsinhvien"] + ""), dataReader["tensinhvien"] + "", dataReader["passwords"] + "", dataReader["gioitinh"] + "", int.Parse(dataReader["sdt"] + ""), dataReader["diachi"] + "", DateTime.Parse(dataReader["namsinh"] + ""), dang_hoc, dang_ki, da_hoc);
                    svsearch_list.Add(sv);
                }

                //close connection
                try
                {
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return svsearch_list;
        }
        public void InsertKhoahoc(Khoahoc kh)
        {
            string query = "INSERT INTO khoahoc (ten, trang_thai, max_danhsach, batdau_dangky, bat_dau_hoc) VALUES('"
                                       + kh.ten + "','" + kh.trang_thai + "','" + kh.max_danhsach + "','" + kh.batdau_dangky + "','" + kh.batdau_hoc + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                try
                {
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void DeleteKhoahoc(Khoahoc kh)
        {
            string query = "DELETE FROM khoahoc WHERE id='" + kh.id.ToString() + "'";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    try
                    {
                        this.CloseConnection();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public List<Khoahoc> SearchKhoahoc(string str)
        {
            string query;
            if (string.IsNullOrEmpty(str))
            {
                query = "SELECT * from khoahoc";
            }
            else
            {
                query = "Select * from khoahoc WHERE ten like '%" + str + "%' OR danh_sach like '%" + str + "%' OR chuyen_can like '%" + str + "%' OR giua_ki like '%" + str + "%' OR cuoi_ki like '%" + str + "%' OR trung_binh like '%" + str + "%' OR trang_thai like '%" + str + "%' OR batdau_dangki like '%" + str + "%' OR batdau_hoc like '%" + str + "%'";
            }
            List<Khoahoc> khsearch_list = new List<Khoahoc>();
            //Open connection
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    string dangsachstr = dataReader["danh_sach"] + "";
                    string[] datadanhsach = Regex.Split(str, ",");
                    List<Sinhvien> danh_sach = new List<Sinhvien>();
                    for (int i = 0; i < datadanhsach.Length; i++)
                    {
                        foreach (Sinhvien sv in sinhvien_list)
                        {
                            if (int.Parse(datadanhsach[i]) == sv.id)
                            {
                                danh_sach.Add(sv);
                            }
                        }
                    }
                    Khoahoc kh = new Khoahoc(int.Parse(dataReader["id"] + ""), dataReader["ten"] + "", danh_sach, int.Parse(dataReader["max_danhsach"] + ""), DateTime.Parse(dataReader["batdau_dangki"] + ""), DateTime.Parse(dataReader["batdau_hoc"] + ""));
                    khsearch_list.Add(kh);
                }

                //close connection
                try
                {
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return khsearch_list;
        }
        public void InsertDiem(Diem d)
        {
            string query = "INSERT INTO diem (idsinhvien, idkhoahoc, chuyen_can, giua_ki, cuoi_ki, trung_binh) VALUES('"
                                       + d.idsinhvien + "','" + d.idkhoahoc + "','" + d.chuyen_can + "','" + d.giua_ki + "','" + d.cuoi_ki + "','" + d.trung_binh + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                try
                {
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void DeleteDiem(Diem d)
        {
            string query = "DELETE FROM diem WHERE id='" + d.id.ToString() + "'";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    try
                    {
                        this.CloseConnection();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public List<Diem> SearchDiem(string str)
        {
            string query;
            if (string.IsNullOrEmpty(str))
            {
                query = "SELECT * from diem";
            }
            else
            {
                query = "Select * from diem WHERE idsinhvien like '%" + str + "%' OR idkhoahoc like '%" + str + "%' OR chuyen_can like '%" + str + "%' OR giua_ki like '%" + str + "%' OR cuoi_ki like '%" + str + "%' OR trung_binh like '%" + str + "%'";
            }
            List<Diem> dsearch_list = new List<Diem>();
            //Open connection
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Diem d = new Diem(int.Parse(dataReader["iddiem"] + ""), int.Parse(dataReader["idsinhvien"] + ""), int.Parse(dataReader["idkhoahoc"] + ""), float.Parse(dataReader["chuyen_can"] + ""), float.Parse(dataReader["giua_ki"] + ""), float.Parse(dataReader["cuoi_ki"] + ""), float.Parse(dataReader["trung_binh"] + ""));
                    dsearch_list.Add(d);
                }

                //close connection
                try
                {
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return dsearch_list;
        }
    }

}
