namespace Client
{
    partial class LoginGUI
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.l_error = new System.Windows.Forms.Label();
            this.b_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_address
            // 
            this.l_address.AutoSize = true;
            this.l_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.l_address.Location = new System.Drawing.Point(12, 9);
            this.l_address.Name = "l_address";
            this.l_address.Size = new System.Drawing.Size(31, 20);
            this.l_address.TabIndex = 0;
            this.l_address.Text = "ID:";
            this.l_address.Click += new System.EventHandler(this.l_address_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(101, 9);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(120, 20);
            this.tb_id.TabIndex = 2;
            // 
            // b_login
            // 
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.b_login.Location = new System.Drawing.Point(231, 35);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(115, 48);
            this.b_login.TabIndex = 4;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_start_Click);
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
            this.tb_password.PasswordChar = '*';
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
            // b_server
            // 
            this.b_server.Location = new System.Drawing.Point(231, 6);
            this.b_server.Name = "b_server";
            this.b_server.Size = new System.Drawing.Size(115, 23);
            this.b_server.TabIndex = 9;
            this.b_server.Text = "Server";
            this.b_server.UseVisualStyleBackColor = true;
            this.b_server.Click += new System.EventHandler(this.b_server_Click);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 91);
            this.Controls.Add(this.b_server);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.l_address);
            this.Name = "LoginGUI";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_address;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.Button b_server;
    }
}