namespace Server
{
    partial class KhoaHocGUI
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
            this.tx_ten = new System.Windows.Forms.TextBox();
            this.l_ten = new System.Windows.Forms.Label();
            this.l_max = new System.Windows.Forms.Label();
            this.tx_max = new System.Windows.Forms.TextBox();
            this.l_dangky = new System.Windows.Forms.Label();
            this.tx_dangky = new System.Windows.Forms.TextBox();
            this.l_ngayhoc = new System.Windows.Forms.Label();
            this.tx_ngayhoc = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_ten
            // 
            this.tx_ten.Location = new System.Drawing.Point(205, 114);
            this.tx_ten.Name = "tx_ten";
            this.tx_ten.Size = new System.Drawing.Size(322, 20);
            this.tx_ten.TabIndex = 0;
            // 
            // l_ten
            // 
            this.l_ten.AutoSize = true;
            this.l_ten.Location = new System.Drawing.Point(40, 121);
            this.l_ten.Name = "l_ten";
            this.l_ten.Size = new System.Drawing.Size(77, 13);
            this.l_ten.TabIndex = 1;
            this.l_ten.Text = "Ten Khoa Hoc";
            this.l_ten.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_max
            // 
            this.l_max.AutoSize = true;
            this.l_max.Location = new System.Drawing.Point(40, 174);
            this.l_max.Name = "l_max";
            this.l_max.Size = new System.Drawing.Size(50, 13);
            this.l_max.TabIndex = 3;
            this.l_max.Text = "SV toi da";
            // 
            // tx_max
            // 
            this.tx_max.Location = new System.Drawing.Point(205, 167);
            this.tx_max.Name = "tx_max";
            this.tx_max.Size = new System.Drawing.Size(322, 20);
            this.tx_max.TabIndex = 2;
            // 
            // l_dangky
            // 
            this.l_dangky.AutoSize = true;
            this.l_dangky.Location = new System.Drawing.Point(40, 239);
            this.l_dangky.Name = "l_dangky";
            this.l_dangky.Size = new System.Drawing.Size(73, 13);
            this.l_dangky.TabIndex = 5;
            this.l_dangky.Text = "Ngay dang ky";
            this.l_dangky.Click += new System.EventHandler(this.label2_Click);
            // 
            // tx_dangky
            // 
            this.tx_dangky.Location = new System.Drawing.Point(205, 232);
            this.tx_dangky.Name = "tx_dangky";
            this.tx_dangky.Size = new System.Drawing.Size(322, 20);
            this.tx_dangky.TabIndex = 4;
            // 
            // l_ngayhoc
            // 
            this.l_ngayhoc.AutoSize = true;
            this.l_ngayhoc.Location = new System.Drawing.Point(40, 295);
            this.l_ngayhoc.Name = "l_ngayhoc";
            this.l_ngayhoc.Size = new System.Drawing.Size(53, 13);
            this.l_ngayhoc.TabIndex = 7;
            this.l_ngayhoc.Text = "Ngay hoc";
            // 
            // tx_ngayhoc
            // 
            this.tx_ngayhoc.Location = new System.Drawing.Point(205, 288);
            this.tx_ngayhoc.Name = "tx_ngayhoc";
            this.tx_ngayhoc.Size = new System.Drawing.Size(322, 20);
            this.tx_ngayhoc.TabIndex = 6;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(249, 348);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(381, 348);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // KhoaHocGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 441);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.l_ngayhoc);
            this.Controls.Add(this.tx_ngayhoc);
            this.Controls.Add(this.l_dangky);
            this.Controls.Add(this.tx_dangky);
            this.Controls.Add(this.l_max);
            this.Controls.Add(this.tx_max);
            this.Controls.Add(this.l_ten);
            this.Controls.Add(this.tx_ten);
            this.Name = "KhoaHocGUI";
            this.Text = "KhoaHocGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_ten;
        private System.Windows.Forms.Label l_ten;
        private System.Windows.Forms.Label l_max;
        private System.Windows.Forms.TextBox tx_max;
        private System.Windows.Forms.Label l_dangky;
        private System.Windows.Forms.TextBox tx_dangky;
        private System.Windows.Forms.Label l_ngayhoc;
        private System.Windows.Forms.TextBox tx_ngayhoc;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
    }
}