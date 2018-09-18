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
        public GUI()
        {
            sql.updatelist();
            server = new Server();
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(GUI_FormClosing);
            dataGridView1.DataSource = ConvertToDataTable(sql.khoahoc_list);
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
                if (!prop.Name.Equals("password"))
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
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

        private void khoaHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.updatelist();
            dataGridView1.DataSource = ConvertToDataTable(sql.khoahoc_list);
            
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.updatelist();
            dataGridView1.DataSource = ConvertToDataTable(sql.sinhvien_list);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_add_Click(object sender, EventArgs e)
        {

        }
    }
}
