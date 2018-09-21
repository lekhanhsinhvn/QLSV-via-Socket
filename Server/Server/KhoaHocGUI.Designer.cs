namespace Server
{
    partial class KhoahocGUI
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
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.l_ten = new System.Windows.Forms.Label();
            this.l_max = new System.Windows.Forms.Label();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.l_dangky = new System.Windows.Forms.Label();
            this.tb_dangky = new System.Windows.Forms.TextBox();
            this.l_ngayhoc = new System.Windows.Forms.Label();
            this.tb_hoc = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.l_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(119, 24);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(216, 20);
            this.tb_ten.TabIndex = 0;
            // 
            // l_ten
            // 
            this.l_ten.AutoSize = true;
            this.l_ten.Location = new System.Drawing.Point(40, 31);
            this.l_ten.Name = "l_ten";
            this.l_ten.Size = new System.Drawing.Size(29, 13);
            this.l_ten.TabIndex = 1;
            this.l_ten.Text = "Ten:";
            this.l_ten.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_max
            // 
            this.l_max.AutoSize = true;
            this.l_max.Location = new System.Drawing.Point(40, 61);
            this.l_max.Name = "l_max";
            this.l_max.Size = new System.Drawing.Size(40, 13);
            this.l_max.TabIndex = 3;
            this.l_max.Text = "Toi da:";
            // 
            // tb_max
            // 
            this.tb_max.Location = new System.Drawing.Point(119, 58);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(216, 20);
            this.tb_max.TabIndex = 2;
            // 
            // l_dangky
            // 
            this.l_dangky.AutoSize = true;
            this.l_dangky.Location = new System.Drawing.Point(40, 100);
            this.l_dangky.Name = "l_dangky";
            this.l_dangky.Size = new System.Drawing.Size(76, 13);
            this.l_dangky.TabIndex = 5;
            this.l_dangky.Text = "Ngay dang ky:";
            this.l_dangky.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_dangky
            // 
            this.tb_dangky.Location = new System.Drawing.Point(119, 97);
            this.tb_dangky.Name = "tb_dangky";
            this.tb_dangky.Size = new System.Drawing.Size(216, 20);
            this.tb_dangky.TabIndex = 4;
            // 
            // l_ngayhoc
            // 
            this.l_ngayhoc.AutoSize = true;
            this.l_ngayhoc.Location = new System.Drawing.Point(40, 140);
            this.l_ngayhoc.Name = "l_ngayhoc";
            this.l_ngayhoc.Size = new System.Drawing.Size(56, 13);
            this.l_ngayhoc.TabIndex = 7;
            this.l_ngayhoc.Text = "Ngay hoc:";
            // 
            // tb_hoc
            // 
            this.tb_hoc.Location = new System.Drawing.Point(119, 137);
            this.tb_hoc.Name = "tb_hoc";
            this.tb_hoc.Size = new System.Drawing.Size(216, 20);
            this.tb_hoc.TabIndex = 6;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(152, 195);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(260, 195);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(40, 205);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 17);
            this.l_error.TabIndex = 10;
            // 
            // KhoahocGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 237);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.l_ngayhoc);
            this.Controls.Add(this.tb_hoc);
            this.Controls.Add(this.l_dangky);
            this.Controls.Add(this.tb_dangky);
            this.Controls.Add(this.l_max);
            this.Controls.Add(this.tb_max);
            this.Controls.Add(this.l_ten);
            this.Controls.Add(this.tb_ten);
            this.Name = "KhoahocGUI";
            this.Text = "Khoa hoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label l_ten;
        private System.Windows.Forms.Label l_max;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.Label l_dangky;
        private System.Windows.Forms.TextBox tb_dangky;
        private System.Windows.Forms.Label l_ngayhoc;
        private System.Windows.Forms.TextBox tb_hoc;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label l_error;
    }
}