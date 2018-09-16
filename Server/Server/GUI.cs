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
        public GUI()
        {
            server = new Server();
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(GUI_FormClosing);

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
                server.ServerStop();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
