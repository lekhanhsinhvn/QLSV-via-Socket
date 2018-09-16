using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AddressGUI : Form
    {
        private LoginGUI loginGUI;
        public AddressGUI(LoginGUI loginGUI)
        {
            this.loginGUI = loginGUI;
            InitializeComponent();
        }

        private void l_address_Click(object sender, EventArgs e)
        {

        }

        private void b_start_Click(object sender, EventArgs e)
        {
                loginGUI.address = IPAddress.Parse(tb_address.Text);
                loginGUI.PORT_NUMBER = int.Parse(tb_port.Text);
                this.Dispose();
        }

        private void AddressGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
