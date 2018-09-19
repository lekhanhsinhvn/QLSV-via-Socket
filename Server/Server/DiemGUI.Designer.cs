namespace Server
{
    partial class DiemGUI
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
            this.b_reset = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.tb_idsinhvien = new System.Windows.Forms.TextBox();
            this.tb_idkhoahoc = new System.Windows.Forms.TextBox();
            this.tb_chuyencan = new System.Windows.Forms.TextBox();
            this.tb_giuaki = new System.Windows.Forms.TextBox();
            this.l_idsinhvien = new System.Windows.Forms.Label();
            this.l_idkhoahoc = new System.Windows.Forms.Label();
            this.l_chuyencan = new System.Windows.Forms.Label();
            this.l_giuaki = new System.Windows.Forms.Label();
            this.l_cuoiki = new System.Windows.Forms.Label();
            this.tb_cuoiki = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(128, 257);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 0;
            this.b_reset.Text = "&Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(235, 257);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 1;
            this.b_save.Text = "&Save";
            this.b_save.UseVisualStyleBackColor = true;
            // 
            // tb_idsinhvien
            // 
            this.tb_idsinhvien.Location = new System.Drawing.Point(128, 23);
            this.tb_idsinhvien.Name = "tb_idsinhvien";
            this.tb_idsinhvien.Size = new System.Drawing.Size(182, 20);
            this.tb_idsinhvien.TabIndex = 2;
            // 
            // tb_idkhoahoc
            // 
            this.tb_idkhoahoc.Location = new System.Drawing.Point(128, 65);
            this.tb_idkhoahoc.Name = "tb_idkhoahoc";
            this.tb_idkhoahoc.Size = new System.Drawing.Size(182, 20);
            this.tb_idkhoahoc.TabIndex = 3;
            // 
            // tb_chuyencan
            // 
            this.tb_chuyencan.Location = new System.Drawing.Point(128, 109);
            this.tb_chuyencan.Name = "tb_chuyencan";
            this.tb_chuyencan.Size = new System.Drawing.Size(182, 20);
            this.tb_chuyencan.TabIndex = 4;
            // 
            // tb_giuaki
            // 
            this.tb_giuaki.Location = new System.Drawing.Point(128, 158);
            this.tb_giuaki.Name = "tb_giuaki";
            this.tb_giuaki.Size = new System.Drawing.Size(182, 20);
            this.tb_giuaki.TabIndex = 5;
            // 
            // l_idsinhvien
            // 
            this.l_idsinhvien.AutoSize = true;
            this.l_idsinhvien.Location = new System.Drawing.Point(41, 26);
            this.l_idsinhvien.Name = "l_idsinhvien";
            this.l_idsinhvien.Size = new System.Drawing.Size(67, 13);
            this.l_idsinhvien.TabIndex = 6;
            this.l_idsinhvien.Text = "Id sinh vien :";
            // 
            // l_idkhoahoc
            // 
            this.l_idkhoahoc.AutoSize = true;
            this.l_idkhoahoc.Location = new System.Drawing.Point(41, 68);
            this.l_idkhoahoc.Name = "l_idkhoahoc";
            this.l_idkhoahoc.Size = new System.Drawing.Size(70, 13);
            this.l_idkhoahoc.TabIndex = 7;
            this.l_idkhoahoc.Text = "Id khoa hoc :";
            // 
            // l_chuyencan
            // 
            this.l_chuyencan.AutoSize = true;
            this.l_chuyencan.Location = new System.Drawing.Point(41, 116);
            this.l_chuyencan.Name = "l_chuyencan";
            this.l_chuyencan.Size = new System.Drawing.Size(70, 13);
            this.l_chuyencan.TabIndex = 8;
            this.l_chuyencan.Text = "Chuyen can :";
            // 
            // l_giuaki
            // 
            this.l_giuaki.AutoSize = true;
            this.l_giuaki.Location = new System.Drawing.Point(44, 165);
            this.l_giuaki.Name = "l_giuaki";
            this.l_giuaki.Size = new System.Drawing.Size(46, 13);
            this.l_giuaki.TabIndex = 9;
            this.l_giuaki.Text = "Giua ki :";
            // 
            // l_cuoiki
            // 
            this.l_cuoiki.AutoSize = true;
            this.l_cuoiki.Location = new System.Drawing.Point(44, 213);
            this.l_cuoiki.Name = "l_cuoiki";
            this.l_cuoiki.Size = new System.Drawing.Size(45, 13);
            this.l_cuoiki.TabIndex = 10;
            this.l_cuoiki.Text = "Cuoi ki :";
            // 
            // tb_cuoiki
            // 
            this.tb_cuoiki.Location = new System.Drawing.Point(128, 205);
            this.tb_cuoiki.Name = "tb_cuoiki";
            this.tb_cuoiki.Size = new System.Drawing.Size(182, 20);
            this.tb_cuoiki.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 318);
            this.Controls.Add(this.tb_cuoiki);
            this.Controls.Add(this.l_cuoiki);
            this.Controls.Add(this.l_giuaki);
            this.Controls.Add(this.l_chuyencan);
            this.Controls.Add(this.l_idkhoahoc);
            this.Controls.Add(this.l_idsinhvien);
            this.Controls.Add(this.tb_giuaki);
            this.Controls.Add(this.tb_chuyencan);
            this.Controls.Add(this.tb_idkhoahoc);
            this.Controls.Add(this.tb_idsinhvien);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_reset);
            this.Name = "Form2";
            this.Text = "Diem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.TextBox tb_idsinhvien;
        private System.Windows.Forms.TextBox tb_idkhoahoc;
        private System.Windows.Forms.TextBox tb_chuyencan;
        private System.Windows.Forms.TextBox tb_giuaki;
        private System.Windows.Forms.Label l_idsinhvien;
        private System.Windows.Forms.Label l_idkhoahoc;
        private System.Windows.Forms.Label l_chuyencan;
        private System.Windows.Forms.Label l_giuaki;
        private System.Windows.Forms.Label l_cuoiki;
        private System.Windows.Forms.TextBox tb_cuoiki;
    }
}