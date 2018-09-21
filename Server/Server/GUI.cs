using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class GUI : Form
    {
        private Server server;
        private SQL sql = new SQL();
        string bang;
        int idtemp;
        string a;
        public GUI()
        {
            server = new Server();
            InitializeComponent();
            updatebroad("Khoahoc");
            
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressGUI addressGUI = new AddressGUI(server);
            addressGUI.Show();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                try
                {
                    server.ServerStop();
                }
                catch (Exception ex)
                {

                }
                Environment.Exit(Environment.ExitCode);
            }
            else
            {
                e.Cancel = true;
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
                int idkh=0;
                foreach (PropertyDescriptor prop in properties) {
                    if (prop.Name.Equals("id"))
                    {
                        idkh = (Int32)prop.GetValue(item);
                    }
                    if (!prop.Name.Equals("password") && !prop.Name.Equals("dang_hoc") && !prop.Name.Equals("dang_ki") && !prop.Name.Equals("da_hoc"))
                    {
                        if (prop.Name.Equals("danh_sach"))
                        {
                            foreach(Khoahoc kh in sql.SearchKhoahoc(""))
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

        private void b_add_Click(object sender, EventArgs e)
        {
            if (bang.Equals("Khoahoc"))
            {
                KhoahocGUI khoahocGUI = new KhoahocGUI(this);
                khoahocGUI.Show();
            }
            else if (bang.Equals("Sinhvien"))
            {
                SinhvienGUI sinhvienGUI = new SinhvienGUI(this);
                sinhvienGUI.Show();
            }
        }

        private void rb_khoahoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_khoahoc.Checked)
            {
                updatebroad("Khoahoc");
            }
            
           
        }

        private void rb_sinhvien_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sinhvien.Checked)
            {
                updatebroad("Sinhvien");
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if (bang.Equals("Sinhvien"))
            {
                updatebroad("Sinhvien");
            }
            else if(bang.Equals("Khoahoc"))
            {
                updatebroad("Khoahoc");
            }
        }

        private void dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_main.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_main.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_main.Rows[selectedrowindex];

                a = Convert.ToString(selectedRow.Cells["id"].Value);
                if (bang.Equals("Khoahoc") && idtemp<=0)
                {
                    rb_sinhvien.Checked = true;
                    bang="Sinhvien";
                    foreach (Khoahoc kh in sql.SearchKhoahoc(tb_search.Text))
                    {
                        if (kh.id == int.Parse(a))
                        {
                            dgv_main.DataSource = ConvertToDataTable(kh.danh_sach);
                            idtemp = kh.id;
                        }
                    }
                   
                }
                else if (bang.Equals("Sinhvien") && idtemp<=0)
                {
                    rb_khoahoc.Checked = true;
                    bang = "Sinhvien";
                    groupBox2.Show();
                    foreach (Sinhvien sv in sql.SearchSinhvien(tb_search.Text))
                    {
                        if (sv.id == int.Parse(a))
                        {
                            dgv_main.DataSource = ConvertToDataTable(sv.dang_hoc);
                            idtemp = sv.id;
                        }
                    }
                }
                else if (bang.Equals("Khoahoc") && idtemp > 0)
                {
                    bang = "Diem";
                    dgv_main.DataSource= ConvertToDataTable(sql.SelectDiem(idtemp, int.Parse(a)));
                }
                else if (bang.Equals("Sinhvien") && idtemp > 0)
                {
                    dgv_main.DataSource = ConvertToDataTable(sql.SelectDiem(int.Parse(a), idtemp));
                }
            }
        }

        private void rb_danghoc_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Sinhvien sv in sql.SearchSinhvien(""))
            {
                if (sv.id == int.Parse(a))
                {
                    dgv_main.DataSource = ConvertToDataTable(sv.dang_hoc);
                }
            }
        }

        private void rb_dahoc_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Sinhvien sv in sql.SearchSinhvien(""))
            {
                if (sv.id == int.Parse(a))
                {
                    dgv_main.DataSource = ConvertToDataTable(sv.da_hoc);
                }
            }
        }

        private void rb_dangky_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Sinhvien sv in sql.SearchSinhvien(""))
            {
                if (sv.id == int.Parse(a))
                {
                    dgv_main.DataSource = ConvertToDataTable(sv.dang_ki);
                }
            }
        }
        public void updatebroad(string str)
        {
            if (str.Equals("Sinhvien"))
            {
                bang = "Sinhvien";
                rb_sinhvien.Checked = true;
                dgv_main.DataSource = ConvertToDataTable(sql.SearchSinhvien(tb_search.Text));
            }
            else if (str.Equals("Khoahoc"))
            {
                bang = "Khoahoc";
                rb_khoahoc.Checked = true;
                dgv_main.DataSource = ConvertToDataTable(sql.SearchKhoahoc(tb_search.Text));
            }
            idtemp = 0;
            groupBox2.Hide();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            if (dgv_main.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_main.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_main.Rows[selectedrowindex];

                a = Convert.ToString(selectedRow.Cells["id"].Value);
                if (bang.Equals("Khoahoc"))
                {
                    foreach (Khoahoc kh in sql.SearchKhoahoc(tb_search.Text))
                    {
                        if(kh.id == int.Parse(a))
                        {
                            KhoahocGUI khoahocGUI = new KhoahocGUI(this, kh);
                            khoahocGUI.Show();
                        }
                    }

                }
                else if (bang.Equals("Sinhvien"))
                {
                    
                    foreach (Sinhvien sv in sql.SearchSinhvien(tb_search.Text))
                    {
                        if (sv.id == int.Parse(a))
                        {
                            SinhvienGUI sinhvienGUI = new SinhvienGUI(this, sv);
                            sinhvienGUI.Show();
                        }
                    }
                }
                else if (bang.Equals("Diem"))
                {
                    foreach (Diem diem in sql.SearchDiem(""))
                    {
                        if (diem.id == int.Parse(a))
                        {
                            DiemGUI diemGUI = new DiemGUI(this, diem);
                            diemGUI.Show();
                        }
                    }
                    
                }

            }

        }

        private void b_del_Click(object sender, EventArgs e)
        {
            if (dgv_main.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_main.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_main.Rows[selectedrowindex];

                a = Convert.ToString(selectedRow.Cells["id"].Value);
                if (bang.Equals("Khoahoc"))
                {
                    foreach (Khoahoc kh in sql.SearchKhoahoc(tb_search.Text))
                    {
                        if (kh.id == int.Parse(a))
                        {
                            sql.DeleteKhoahoc(kh);
                        }
                    }
                    updatebroad("Khoahoc");

                }
                else if (bang.Equals("Sinhvien"))
                {
                    foreach (Sinhvien sv in sql.SearchSinhvien(tb_search.Text))
                    {
                        if (sv.id == int.Parse(a))
                        {
                            sql.DeleteSinhvien(sv);
                        }
                    }
                    updatebroad("Sinhvien");
                }
                
            }
            
        }
    }
}
