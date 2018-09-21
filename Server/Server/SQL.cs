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
        private List<Khoahoc> kh_list=new List<Khoahoc>();
        private List<Sinhvien> sv_list=new List<Sinhvien>();
        private List<Diem> d_list=new List<Diem>();
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

            update();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                
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
                Console.WriteLine(ex);
                return false;
            }
        }
        public void InsertSinhvien(Sinhvien sv)
        {
            string query = "INSERT INTO sinhvien (tensinhvien, passwords, gioitinh, namsinh, sdt, diachi) VALUES('"
                                                    + sv.ten + "','" + sv.password + "','" + sv.gioi_tinh + "','" + sv.ngay_sinh.ToString("MM/dd/yyyy") + "','" + sv.sdt + "','" + sv.diachi + "');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                    CloseConnection();
                update();
                
            }
        }
        public void UpdateSinhvien(Sinhvien sv)
        {
            string query = "UPDATE sinhvien SET tensinhvien = '" + sv.ten + "', passwords = '" + sv.password + "', gioitinh = '" + sv.gioi_tinh + "', namsinh = '" + sv.ngay_sinh.ToString("MM/dd/yyyy") + "', sdt = '" + sv.sdt + "', diachi = '" + sv.diachi + "', dahoc ='"+ khlisttoidstring(sv.da_hoc) +"', danghoc = '"+khlisttoidstring(sv.dang_hoc) + "', dangky = '" + khlisttoidstring(sv.dang_ki) + "' WHERE idsinhvien = '" + sv.id + "';";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                    CloseConnection();
                update();
            }
        }
        public void DeleteSinhvien(Sinhvien sv)
        {
            string query = "DELETE FROM sinhvien WHERE idsinhvien='" + sv.id.ToString() + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                CloseConnection();
                update();
            }
        }

        public List<Sinhvien> SearchSinhvien(string str)
        {
            string query;
            if (string.IsNullOrWhiteSpace(str))
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
                    Sinhvien sv = new Sinhvien(int.Parse(dataReader["idsinhvien"] + ""), dataReader["tensinhvien"] + "", dataReader["passwords"] + "", dataReader["gioitinh"] + "", int.Parse(dataReader["sdt"] + ""), dataReader["diachi"] + "", DateTime.Parse(dataReader["namsinh"] + ""), idstringtokhlist(dataReader["danghoc"] + ""), idstringtokhlist(dataReader["dangky"] + ""), idstringtokhlist(dataReader["dahoc"] + ""));
                    svsearch_list.Add(sv);
                }

                //close connection

                CloseConnection();

            }
            return svsearch_list;
        }
        public void InsertKhoahoc(Khoahoc kh)
        {
            string query = "INSERT INTO khoahoc (ten, trang_thai, max_danhsach, batdau_dangki, batdau_hoc) VALUES('"
                                       + kh.ten + "','" + kh.trang_thai + "','" + kh.max_danhsach + "','" + kh.batdau_dangky.ToString("MM/dd/yyyy") + "','" + kh.batdau_hoc.ToString("MM/dd/yyyy") + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection

                    CloseConnection();
                update();
            }
        }
        public void UpdateKhoahoc(Khoahoc kh)
        {
            string query = "UPDATE khoahoc SET ten = '" + kh.ten + "', trang_thai = '" + kh.trang_thai + "', max_danhsach = '" + kh.max_danhsach +"', danh_sach = '"+ svlisttoidstring(kh.danh_sach) + "', batdau_dangki = '" + kh.batdau_dangky.ToString("MM/dd/yyyy") + "', batdau_hoc = '" + kh.batdau_hoc.ToString("MM/dd/yyyy") + "' WHERE id = '" + kh.id + "';";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection

                    CloseConnection();
                update();
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
                }
                finally
                {

                        CloseConnection();
                    update();
                }
            }
        }

        public List<Khoahoc> SearchKhoahoc(string str)
        {
            string query;
            if (string.IsNullOrWhiteSpace(str))
            {
                query = "SELECT * from khoahoc";
            }
            else
            {
                query = "Select * from khoahoc WHERE ten like '%"+ str +"%' OR trang_thai like '%" + str + "%' OR batdau_dangki like '%" + str + "%' OR batdau_hoc like '%" + str + "%'";
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
                    Khoahoc kh = new Khoahoc(int.Parse(dataReader["id"] + ""), dataReader["ten"] + "", idstringtosvlist(dataReader["danh_sach"] + ""), dataReader["trang_thai"] + "", int.Parse(dataReader["max_danhsach"] + ""), DateTime.Parse(dataReader["batdau_dangki"] + ""), DateTime.Parse(dataReader["batdau_hoc"] + ""));
                    khsearch_list.Add(kh);
                }

                //close connection
                    CloseConnection();

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

                    CloseConnection();
                update();
            }
        }
        public void UpdateDiem(Diem d)
        {
            string query = "UPDATE diem SET idsinhvien = '" + d.idsinhvien + "', idkhoahoc = '" + d.idkhoahoc + "', chuyen_can = '" + d.chuyen_can + "', giua_ki = '" + d.giua_ki + "', cuoi_ki = '" + d.cuoi_ki + "', trung_binh = '" + d.trung_binh + "' WHERE id = '" + d.id + "';";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection

                    CloseConnection();
                update();
            }
        }
        public void DeleteDiem(Diem d)
        {
            string query = "DELETE FROM diem WHERE id='" + d.id.ToString() + "';";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                }
                finally
                {
                        CloseConnection();
                }
                update();
            }
        }

        public List<Diem> SearchDiem(string str)
        {
            string query;
            if (string.IsNullOrWhiteSpace(str))
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
                    CloseConnection();

            }
            return dsearch_list;
        }
        public List<Diem> SelectDiem(int idsinhvien, int idkhoahoc)
        {
            string query;
            
            query = "Select * from diem WHERE idsinhvien = '" + idsinhvien + "' AND idkhoahoc = '" + idkhoahoc + "';";
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
                    if (!string.IsNullOrWhiteSpace(dataReader["iddiem"]+""))
                    {
                        Diem d = new Diem(int.Parse(dataReader["iddiem"] + ""), int.Parse(dataReader["idsinhvien"] + ""), int.Parse(dataReader["idkhoahoc"] + ""), float.Parse(dataReader["chuyen_can"] + ""), float.Parse(dataReader["giua_ki"] + ""), float.Parse(dataReader["cuoi_ki"] + ""), float.Parse(dataReader["trung_binh"] + ""));
                        dsearch_list.Add(d);
                    }
                    
                }

                //close connection
                    CloseConnection();


            }
            return dsearch_list;
        }
        public List<Khoahoc> idstringtokhlist(string str )
        {
            List<Khoahoc> temp = new List<Khoahoc>();
            if (!string.IsNullOrWhiteSpace(str))
            {
                string[] data = Regex.Split(str, ",");

                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine(data[i]);
                    foreach (Khoahoc kh in kh_list)
                    {
                        if (!string.IsNullOrWhiteSpace(data[i]) && int.Parse(data[i]) == kh.id)
                        {
                            temp.Add(kh);
                        }
                    }
                }
            }
            return temp;
        }
        public List<Sinhvien> idstringtosvlist(string str)
        {
            List<Sinhvien> temp = new List<Sinhvien>();
            if (!string.IsNullOrWhiteSpace(str))
            {
                string[] data = Regex.Split(str, ",");
                for (int i = 0; i < data.Length; i++)
                {
                    foreach (Sinhvien sv in sv_list)
                    {
                        Console.WriteLine(data[i]);
                        if (!string.IsNullOrWhiteSpace(data[i]) && int.Parse(data[i]) == sv.id)
                        {
                            Console.WriteLine(data[i]);
                            temp.Add(sv);
                        }
                    }
                }
            }
            return temp;
        }
        public string khlisttoidstring(List<Khoahoc> kho_list)
        {
            string str = "";
            foreach(Khoahoc kh in kho_list)
            {
                str += kh.id.ToString() + ",";
            }
            return str;
        }
        public string svlisttoidstring(List<Sinhvien> svi_list)
        {
            string str = "";
            foreach (Sinhvien sv in svi_list)
            {
                str += sv.id.ToString() + ",";
            }
            return str;
        }
        public void update()
        {
            kh_list = SearchKhoahoc("");
            sv_list = SearchSinhvien("");
            d_list = SearchDiem("");
        }
    }

}
