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
        private Client client;
        public GUI(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI(client);
            loginGUI.Show();
        }
    }
}
