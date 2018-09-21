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
    public partial class KhoahocGUI : Form
    {
        private SQL sql = new SQL();
        private GUI gui;
        private Khoahoc kh=null;
        public KhoahocGUI(GUI gui)
        {
            this.gui = gui;
            InitializeComponent();
        }
        public KhoahocGUI(GUI gui,Khoahoc kh)
        {
            this.gui = gui;
            this.kh = kh;
            InitializeComponent();
            tb_ten.Text = kh.ten;
            tb_max.Text = kh.max_danhsach.ToString();
            tb_dangky.Text = kh.batdau_dangky.ToString("MM/dd/yyyy");
            tb_hoc.Text = kh.batdau_hoc.ToString("MM/dd/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_ten.Text))
                {
                    throw new Exception();
                }
                if (kh == null)
                {
                    kh = new Khoahoc(tb_ten.Text, int.Parse(tb_max.Text), DateTime.Parse(tb_dangky.Text), DateTime.Parse(tb_hoc.Text));
                    sql.InsertKhoahoc(kh);
                }
                else
                {
                    kh.ten = tb_ten.Text;
                    kh.max_danhsach = int.Parse(tb_max.Text);
                    kh.batdau_dangky = DateTime.Parse(tb_dangky.Text);
                    kh.batdau_hoc = DateTime.Parse(tb_hoc.Text);
                    sql.UpdateKhoahoc(kh);
                }
                gui.updatebroad("Khoahoc");
                this.Dispose();
            }
            catch (Exception ex)
            {
                l_error.Text = "Error";
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (kh == null)
            {
                tb_ten.Clear();
                tb_max.Clear();
                tb_dangky.Clear();
                tb_hoc.Clear();
            }
            else
            {
                tb_ten.Text = kh.ten;
                tb_max.Text = kh.max_danhsach.ToString();
                tb_dangky.Text = kh.batdau_dangky.ToString("MM/dd/yyyy");
                tb_hoc.Text = kh.batdau_hoc.ToString("MM/dd/yyyy");
            }
            
        }
    }
}
