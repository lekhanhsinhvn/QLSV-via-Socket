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
    public partial class DiemGUI : Form
    {
        private SQL sql = new SQL();
        private GUI gui;
        private Diem diem;
        public DiemGUI(GUI gui)
        {
            this.gui = gui;
            InitializeComponent();
        }
        public DiemGUI(GUI gui, Diem diem)
        {
            this.diem = diem;
            this.gui = gui;
            InitializeComponent();
            tb_chuyencan.Text = diem.chuyen_can.ToString();
            tb_giuaki.Text = diem.giua_ki.ToString();
            tb_cuoiki.Text = diem.cuoi_ki.ToString();
        }
        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                diem.chuyen_can = float.Parse(tb_chuyencan.Text);
                diem.giua_ki = float.Parse(tb_giuaki.Text);
                diem.cuoi_ki = float.Parse(tb_cuoiki.Text);
                sql.UpdateDiem(diem);
                gui.updatebroad("Diem");
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
            tb_chuyencan.Text = diem.chuyen_can.ToString();
            tb_giuaki.Text = diem.giua_ki.ToString();
            tb_cuoiki.Text = diem.cuoi_ki.ToString();
        }
    }
}
