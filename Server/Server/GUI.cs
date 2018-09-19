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
        public List<Sinhvien> sinhvien_list;
        public List<Khoahoc> khoahoc_list;
        public GUI()
        {
            server = new Server();
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(GUI_FormClosing);
            dgv_main.DataSource = ConvertToDataTable(sql.SearchKhoahoc(""));
            bang = "Khoahoc";
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
                if (!prop.Name.Equals("password") && !prop.Name.Equals("danh_sach") && !prop.Name.Equals("dang_hoc") && !prop.Name.Equals("dang_ki") && !prop.Name.Equals("da_hoc"))
                {
                    if (typeof(T).IsValueType is Diem)
                    {
                        if (!prop.Name.Equals("idsinhvien") && !prop.Name.Equals("idkhoahoc"))
                        {
                            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                        }
                    }
                    else
                    {
                        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                    }
                    
                }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if (bang.Equals("Khoahoc"))
            {

            }
            else if (bang.Equals("Sinhvien"))
            {

            }
            else if (bang.Equals("Diem"))
            {

            }
        }

        private void rb_khoahoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_khoahoc.Checked)
            {
                bang = "Khoahoc";
                khoahoc_list = sql.SearchKhoahoc(tb_search.Text);
                dgv_main.DataSource = ConvertToDataTable(khoahoc_list);
            }
            
           
        }

        private void rb_sinhvien_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sinhvien.Checked)
            {
                bang = "Sinhvien";
                sinhvien_list = sql.SearchSinhvien(tb_search.Text);
                dgv_main.DataSource = ConvertToDataTable(sinhvien_list);
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if (bang.Equals("Sinhvien"))
            {
                dgv_main.DataSource = ConvertToDataTable(sql.SearchSinhvien(tb_search.Text));
            }
            else if(bang.Equals("Khoahoc"))
            {
                dgv_main.DataSource = ConvertToDataTable(sql.SearchKhoahoc(tb_search.Text));
            }
        }

        private void dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_main.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_main.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_main.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["id"].Value);
                if (bang.Equals("Khoahoc"))
                {
                    rb_sinhvien.Checked = true;
                    bang="Sinhvien";
                    foreach (Khoahoc kh in khoahoc_list)
                    {
                        if (kh.id == int.Parse(a))
                        {
                            ConvertToDataTable(kh.danh_sach);
                        }
                    }
                   
                }

            }
        }
    }
}
