using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GUI : Form
    {
        string bang;
        int idtemp=0;
        string a;
        private Client client;
        
        public GUI()
        {
            client = new Client(this);
            InitializeComponent();
            bang = "Khoahoc";
            update();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }
        private delegate void Updatedgv_main();
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI(client);
            loginGUI.Show();
        }

        private void b_dangky_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(a))
            {
                idtemp = int.Parse(a);
            }
            
            foreach(Khoahoc kh in client.kh_list)
            {
                if (idtemp == kh.id)
                {
                    client.send("Dangky#@#" + kh.id + "#@#" + tb_search.Text);
                    bang = "Khoahoc";
                }
            }
        }

        private void dgv_main_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_main.SelectedCells.Count > 0)
            {
                if (bang.Equals("Khoahoc"))
                {
                    client.send("Bang#@#Sinhvien#@#" + a + "#@#" + tb_search.Text);
                    bang = "Sinhvien";
                }
            }
        }
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                if (!prop.Name.Equals("password") && !prop.Name.Equals("dang_hoc") && !prop.Name.Equals("dang_ki") && !prop.Name.Equals("da_hoc"))
                {
                    if (prop.Name.Equals("danh_sach"))
                    {
                        table.Columns.Add("so_sv", typeof(string));
                    }
                    else
                    {
                        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                    }

                }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                int idkh = 0;
                foreach (PropertyDescriptor prop in properties)
                {
                    if (prop.Name.Equals("id"))
                    {
                        idkh = (Int32)prop.GetValue(item);
                    }
                    if (!prop.Name.Equals("password") && !prop.Name.Equals("dang_hoc") && !prop.Name.Equals("dang_ki") && !prop.Name.Equals("da_hoc"))
                    {
                        if (prop.Name.Equals("danh_sach"))
                        {
                            foreach (Khoahoc kh in client.kh_list)
                            {
                                if (idkh == kh.id)
                                {
                                    row["so_sv"] = kh.danh_sach.Count();
                                }
                            }

                        }
                        else
                        {
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                        }

                    }
                    
                }table.Rows.Add(row);
            }
            return table;

        }

        private void dgv_main_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedrowindex = dgv_main.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgv_main.Rows[selectedrowindex];

            a = Convert.ToString(selectedRow.Cells["id"].Value);

            if (!string.IsNullOrWhiteSpace(a))
            {
                idtemp = int.Parse(a);
            }
            
            bool t = false;
            foreach (Khoahoc kh in client.kh_list)
            {
                if (idtemp == kh.id)
                {
                    foreach(Sinhvien sinhvien in kh.danh_sach)
                    {
                        if (client.id == sinhvien.id)
                        {
                            b_dangky.Text = "HUY";
                            t = true;
                        }
                    }
                }
            }
            if(t == false)
            {
                b_dangky.Text = "Dang ky";
            }
        }

        private void rb_khoahoc_CheckedChanged(object sender, EventArgs e)
        {
            client.send("Bang#@#Khoahoc#@#" + tb_search.Text);
            bang = "Khoahoc";
        }

        private void rb_danghoc_CheckedChanged(object sender, EventArgs e)
        {
            client.send("Bang#@#Danghoc#@#" + tb_search.Text);
            bang = "Khoahoc";
        }

        private void rb_dahoc_CheckedChanged(object sender, EventArgs e)
        {
            client.send("Bang#@#Dahoc#@#" + tb_search.Text);
            bang = "Khoahoc";
        }

        private void rb_dangky_CheckedChanged(object sender, EventArgs e)
        {
            client.send("Bang#@#Dangki#@#" + tb_search.Text);
            bang = "Khoahoc";
        }

        public void update()
        {
            if (dgv_main.InvokeRequired)
            {
                Updatedgv_main u = new Updatedgv_main(update);
                dgv_main.BeginInvoke(u);
            }
            else
            {
                if (bang.Equals("Khoahoc"))
                {
                    dgv_main.DataSource = ConvertToDataTable(client.kh_list);
                }
                else if (bang.Equals("Sinhvien"))
                {
                    dgv_main.DataSource = ConvertToDataTable(client.sv_list);
                }
                else if (bang.Equals("Diem"))
                {
                    dgv_main.DataSource = ConvertToDataTable(client.d_list);
                }
            }
            
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if (bang.Equals("Khoahoc"))
            {
                if (rb_dahoc.Checked)
                {
                    client.send("Bang#@#Dahoc#@#" + tb_search.Text);
                    bang = "Khoahoc";
                }
                else if(rb_danghoc.Checked)
                {
                    client.send("Bang#@#Danghoc#@#" + tb_search.Text);
                    bang = "Khoahoc";
                }
                else if (rb_khoahoc.Checked)
                {
                    client.send("Bang#@#Khoahoc#@#" + tb_search.Text);
                    bang = "Khoahoc";
                }
                else if(rb_dangky.Checked)
                {
                    client.send("Bang#@#Dangki#@#" + tb_search.Text);
                    bang = "Khoahoc";
                }
                
            }
            else if (bang.Equals("Sinhvien"))
            {
                dgv_main.DataSource = ConvertToDataTable(client.sv_list);
            }
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }   
}
