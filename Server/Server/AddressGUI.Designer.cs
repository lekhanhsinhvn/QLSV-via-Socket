namespace Server
{
    partial class AddressGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_address = new System.Windows.Forms.Label();
            this.l_port = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.l_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_address
            // 
            this.l_address.AutoSize = true;
            this.l_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.l_address.Location = new System.Drawing.Point(12, 9);
            this.l_address.Name = "l_address";
            this.l_address.Size = new System.Drawing.Size(76, 20);
            this.l_address.TabIndex = 0;
            this.l_address.Text = "Address:";
            this.l_address.Click += new System.EventHandler(this.l_address_Click);
            // 
            // l_port
            // 
            this.l_port.AutoSize = true;
            this.l_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.l_port.Location = new System.Drawing.Point(227, 7);
            this.l_port.Name = "l_port";
            this.l_port.Size = new System.Drawing.Size(45, 20);
            this.l_port.TabIndex = 1;
            this.l_port.Text = "Port:";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(101, 9);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(120, 20);
            this.tb_address.TabIndex = 2;
            this.tb_address.Text = "127.0.0.1";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(278, 7);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(70, 20);
            this.tb_port.TabIndex = 3;
            this.tb_port.Text = "2222";
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.b_start.Location = new System.Drawing.Point(231, 35);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(115, 48);
            this.b_start.TabIndex = 4;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.l_password.Location = new System.Drawing.Point(12, 35);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(88, 20);
            this.l_password.TabIndex = 6;
            this.l_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(101, 37);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(120, 20);
            this.tb_password.TabIndex = 7;
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(12, 65);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 17);
            this.l_error.TabIndex = 8;
            // 
            // AddressGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 91);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.l_port);
            this.Controls.Add(this.l_address);
            this.Name = "AddressGUI";
            this.Text = "Address/Port";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_address;
        private System.Windows.Forms.Label l_port;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_error;
    }
}