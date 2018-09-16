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
    public partial class LoginGUI : Form
    {
        private Client client;
        public IPAddress address
        {
            get;
            set;
        }
        public int PORT_NUMBER
        {
            get;
            set;
        }
        public LoginGUI(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void l_address_Click(object sender, EventArgs e)
        {

        }

        private void b_start_Click(object sender, EventArgs e)
        {      
                try
                {
                    TcpClient cl = new TcpClient();
                    cl.Connect(address, PORT_NUMBER);
                    client.ClientStart(cl);
                    if (!client.Login(int.Parse(tb_id.Text), tb_password.Text))
                    {
                        throw new Exception();
                    }
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    l_error.Text = "Error";
                Console.WriteLine(ex);
                }
        }

        private void b_server_Click(object sender, EventArgs e)
        {
            AddressGUI addressGUI = new AddressGUI(this);
            addressGUI.Show();

        }
    }
}
