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
            this.l_chuyencan = new System.Windows.Forms.Label();
            this.tb_chuyencan = new System.Windows.Forms.TextBox();
            this.l_giuaki = new System.Windows.Forms.Label();
            this.tb_giuaki = new System.Windows.Forms.TextBox();
            this.l_cuoiki = new System.Windows.Forms.Label();
            this.tb_cuoiki = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.l_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_chuyencan
            // 
            this.l_chuyencan.AutoSize = true;
            this.l_chuyencan.Location = new System.Drawing.Point(12, 28);
            this.l_chuyencan.Name = "l_chuyencan";
            this.l_chuyencan.Size = new System.Drawing.Size(67, 13);
            this.l_chuyencan.TabIndex = 0;
            this.l_chuyencan.Text = "Chuyen can:";
            // 
            // tb_chuyencan
            // 
            this.tb_chuyencan.Location = new System.Drawing.Point(85, 25);
            this.tb_chuyencan.Name = "tb_chuyencan";
            this.tb_chuyencan.Size = new System.Drawing.Size(40, 20);
            this.tb_chuyencan.TabIndex = 1;
            // 
            // l_giuaki
            // 
            this.l_giuaki.AutoSize = true;
            this.l_giuaki.Location = new System.Drawing.Point(155, 28);
            this.l_giuaki.Name = "l_giuaki";
            this.l_giuaki.Size = new System.Drawing.Size(43, 13);
            this.l_giuaki.TabIndex = 2;
            this.l_giuaki.Text = "Giua ki:";
            // 
            // tb_giuaki
            // 
            this.tb_giuaki.Location = new System.Drawing.Point(204, 25);
            this.tb_giuaki.Name = "tb_giuaki";
            this.tb_giuaki.Size = new System.Drawing.Size(40, 20);
            this.tb_giuaki.TabIndex = 3;
            // 
            // l_cuoiki
            // 
            this.l_cuoiki.AutoSize = true;
            this.l_cuoiki.Location = new System.Drawing.Point(280, 28);
            this.l_cuoiki.Name = "l_cuoiki";
            this.l_cuoiki.Size = new System.Drawing.Size(42, 13);
            this.l_cuoiki.TabIndex = 4;
            this.l_cuoiki.Text = "Cuoi ki:";
            // 
            // tb_cuoiki
            // 
            this.tb_cuoiki.Location = new System.Drawing.Point(328, 25);
            this.tb_cuoiki.Name = "tb_cuoiki";
            this.tb_cuoiki.Size = new System.Drawing.Size(40, 20);
            this.tb_cuoiki.TabIndex = 5;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(308, 55);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 33);
            this.b_save.TabIndex = 6;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(227, 55);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 33);
            this.b_reset.TabIndex = 7;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(12, 71);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(12, 17);
            this.l_error.TabIndex = 8;
            this.l_error.Text = " ";
            // 
            // DiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 94);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.tb_cuoiki);
            this.Controls.Add(this.l_cuoiki);
            this.Controls.Add(this.tb_giuaki);
            this.Controls.Add(this.l_giuaki);
            this.Controls.Add(this.tb_chuyencan);
            this.Controls.Add(this.l_chuyencan);
            this.Name = "DiemGUI";
            this.Text = "Diem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_chuyencan;
        private System.Windows.Forms.TextBox tb_chuyencan;
        private System.Windows.Forms.Label l_giuaki;
        private System.Windows.Forms.TextBox tb_giuaki;
        private System.Windows.Forms.Label l_cuoiki;
        private System.Windows.Forms.TextBox tb_cuoiki;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Label l_error;
    }
}