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

namespace Server
{
    public partial class AddressGUI : Form
    {
        private Server server;
        public AddressGUI(Server server)
        {
            this.server = server;
            InitializeComponent();
        }

        private void l_address_Click(object sender, EventArgs e)
        {

        }

        private void b_start_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress address = IPAddress.Parse(tb_address.Text);
                int PORT_NUMBER = int.Parse(tb_port.Text);
                
                try
                {
                    
                }
                catch (Exception ex)
                {

                }
                server.ServerStart(address,PORT_NUMBER);
                
                this.Dispose();
            }
            catch (Exception ex)
            {
                l_error.Text = "Error";
                Console.WriteLine(ex);
            }
        }
    }
}
