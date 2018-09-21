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
        private Sinhvien sv=null;
        public SinhvienGUI(GUI gui)
        {
            this.gui = gui;
            InitializeComponent();
        }
        public SinhvienGUI(GUI gui, Sinhvien sv)
        {
            this.sv = sv;
            this.gui = gui;
            InitializeComponent();
            tb_hoten.Text = sv.ten;
            tb_password.Text = sv.password;
            tb_sdt.Text = sv.sdt.ToString();
            tb_ngaysinh.Text = sv.ngay_sinh.ToString("MM/dd/yyyy");
            tb_diachi.Text = sv.diachi;
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
                if (sv==null)
                {
                    sv = new Sinhvien(tb_hoten.Text, tb_password.Text, sex,int.Parse(tb_sdt.Text), tb_diachi.Text, DateTime.Parse(tb_ngaysinh.Text));
                    sql.InsertSinhvien(sv);
                }
                else
                {
                    sv.ten = tb_hoten.Text;
                    sv.password = tb_password.Text;
                    sv.gioi_tinh = sex;
                    sv.sdt = int.Parse(tb_sdt.Text);
                    sv.diachi = tb_diachi.Text;
                    sv.ngay_sinh = DateTime.Parse(tb_ngaysinh.Text);
                    sql.UpdateSinhvien(sv);
                }
                gui.updatebroad("Sinhvien");
                this.Dispose();
            }
            catch (Exception ex)
            {
                l_error.Text = "Error";
                Console.WriteLine(ex.Message);
            }
            
            
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            if(sv == null)
            {
                tb_hoten.Clear();
                tb_password.Clear();
                tb_sdt.Clear();
                rb_nam.Checked = true;
                tb_diachi.Clear();
                tb_ngaysinh.Clear();
            }
            else
            {
                tb_hoten.Text = sv.ten;
                tb_password.Text = sv.password;
                tb_sdt.Text = sv.sdt.ToString();
                tb_ngaysinh.Text = sv.ngay_sinh.ToString("MM/dd/yyyy");
                tb_diachi.Text = sv.diachi;
            }
            
        }
    }
}
