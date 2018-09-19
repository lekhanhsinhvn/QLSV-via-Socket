namespace Server
{
    partial class Form1
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
            this.r_sdt = new System.Windows.Forms.TextBox();
            this.r_ngaysinh = new System.Windows.Forms.TextBox();
            this.r_diachi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.r_nam = new System.Windows.Forms.RadioButton();
            this.r_nu = new System.Windows.Forms.RadioButton();
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
            // r_sdt
            // 
            this.r_sdt.Location = new System.Drawing.Point(134, 172);
            this.r_sdt.Name = "r_sdt";
            this.r_sdt.Size = new System.Drawing.Size(216, 20);
            this.r_sdt.TabIndex = 8;
            // 
            // r_ngaysinh
            // 
            this.r_ngaysinh.Location = new System.Drawing.Point(134, 213);
            this.r_ngaysinh.Name = "r_ngaysinh";
            this.r_ngaysinh.Size = new System.Drawing.Size(216, 20);
            this.r_ngaysinh.TabIndex = 9;
            // 
            // r_diachi
            // 
            this.r_diachi.Location = new System.Drawing.Point(134, 258);
            this.r_diachi.Multiline = true;
            this.r_diachi.Name = "r_diachi";
            this.r_diachi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.r_diachi.Size = new System.Drawing.Size(216, 71);
            this.r_diachi.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Tag = "";
            this.button1.Text = "&Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "&Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // r_nam
            // 
            this.r_nam.AutoSize = true;
            this.r_nam.Location = new System.Drawing.Point(134, 128);
            this.r_nam.Name = "r_nam";
            this.r_nam.Size = new System.Drawing.Size(47, 17);
            this.r_nam.TabIndex = 13;
            this.r_nam.TabStop = true;
            this.r_nam.Text = "Nam";
            this.r_nam.UseVisualStyleBackColor = true;
            // 
            // r_nu
            // 
            this.r_nu.AutoSize = true;
            this.r_nu.Location = new System.Drawing.Point(209, 128);
            this.r_nu.Name = "r_nu";
            this.r_nu.Size = new System.Drawing.Size(39, 17);
            this.r_nu.TabIndex = 14;
            this.r_nu.TabStop = true;
            this.r_nu.Text = "Nu";
            this.r_nu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 419);
            this.Controls.Add(this.r_nu);
            this.Controls.Add(this.r_nam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r_diachi);
            this.Controls.Add(this.r_ngaysinh);
            this.Controls.Add(this.r_sdt);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_hoten);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox r_sdt;
        private System.Windows.Forms.TextBox r_ngaysinh;
        private System.Windows.Forms.TextBox r_diachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton r_nam;
        private System.Windows.Forms.RadioButton r_nu;
    }
}