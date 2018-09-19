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
    public partial class SinhvienGUI : Form
    {
        private SQL sql = new SQL();
        private GUI gui;
        public SinhvienGUI(GUI gui)
        {
            this.gui = gui;
            InitializeComponent();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_hoten.Text) || string.IsNullOrEmpty(tb_password.Text) || string.IsNullOrEmpty(tb_diachi.Text))
                {
                    throw new Exception();
                }
                string sex="nam";
                if (rb_nam.Checked)
                {
                    sex = "nam";
                }else if (rb_nu.Checked)
                {
                    sex = "nu";
                }
                Sinhvien sv = new Sinhvien(tb_hoten.Text, tb_password.Text, sex,int.Parse(tb_sdt.Text), tb_diachi.Text, DateTime.Parse(tb_ngaysinh.Text));
                sql.InsertSinhvien(sv);
                gui.updatebroad("Sinhvien");
                this.Dispose();
            }
            catch (Exception ex)
            {
                l_error.Text = "Error";
            }
            
            
        }
    }
}
