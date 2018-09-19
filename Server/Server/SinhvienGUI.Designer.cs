namespace Server
{
    partial class SinhvienGUI
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
            this.l_hoten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_ngaysinh = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.l_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_hoten
            // 
            this.l_hoten.AutoSize = true;
            this.l_hoten.Location = new System.Drawing.Point(30, 48);
            this.l_hoten.Name = "l_hoten";
            this.l_hoten.Size = new System.Drawing.Size(45, 13);
            this.l_hoten.TabIndex = 0;
            this.l_hoten.Text = "Ho ten :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gioi tinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "So dien thoai :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngay sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dia chi :";
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(134, 41);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(216, 20);
            this.tb_hoten.TabIndex = 6;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(134, 81);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(216, 20);
            this.tb_password.TabIndex = 7;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(134, 172);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(216, 20);
            this.tb_sdt.TabIndex = 8;
            // 
            // tb_ngaysinh
            // 
            this.tb_ngaysinh.Location = new System.Drawing.Point(134, 213);
            this.tb_ngaysinh.Name = "tb_ngaysinh";
            this.tb_ngaysinh.Size = new System.Drawing.Size(216, 20);
            this.tb_ngaysinh.TabIndex = 9;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(134, 258);
            this.tb_diachi.Multiline = true;
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_diachi.Size = new System.Drawing.Size(216, 71);
            this.tb_diachi.TabIndex = 10;
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(134, 361);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 11;
            this.b_reset.Tag = "";
            this.b_reset.Text = "&Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(275, 361);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 12;
            this.b_save.Text = "&Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Checked = true;
            this.rb_nam.Location = new System.Drawing.Point(134, 128);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(47, 17);
            this.rb_nam.TabIndex = 13;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(209, 128);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(39, 17);
            this.rb_nu.TabIndex = 14;
            this.rb_nu.Text = "Nu";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(30, 367);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(12, 17);
            this.l_error.TabIndex = 15;
            this.l_error.Text = " ";
            // 
            // SinhvienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 419);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.rb_nu);
            this.Controls.Add(this.rb_nam);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_ngaysinh);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_hoten);
            this.Name = "SinhvienGUI";
            this.Text = "Them sinh vien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_ngaysinh;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.Label l_error;
    }
}