namespace Client
{
    partial class GUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rb_danghoc = new System.Windows.Forms.RadioButton();
            this.b_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.b_dangky = new System.Windows.Forms.Button();
            this.rb_dahoc = new System.Windows.Forms.RadioButton();
            this.rb_dangky = new System.Windows.Forms.RadioButton();
            this.rb_khoahoc = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // rb_danghoc
            // 
            this.rb_danghoc.AutoSize = true;
            this.rb_danghoc.Location = new System.Drawing.Point(105, 28);
            this.rb_danghoc.Name = "rb_danghoc";
            this.rb_danghoc.Size = new System.Drawing.Size(72, 17);
            this.rb_danghoc.TabIndex = 0;
            this.rb_danghoc.Text = "Dang hoc";
            this.rb_danghoc.UseVisualStyleBackColor = true;
            this.rb_danghoc.CheckedChanged += new System.EventHandler(this.rb_danghoc_CheckedChanged);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(775, 25);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(104, 23);
            this.b_search.TabIndex = 11;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(439, 25);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(330, 20);
            this.tb_search.TabIndex = 10;
            // 
            // dgv_main
            // 
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(19, 51);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(750, 296);
            this.dgv_main.TabIndex = 9;
            this.dgv_main.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_main_CellMouseClick);
            this.dgv_main.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_main_CellMouseDoubleClick);
            // 
            // b_dangky
            // 
            this.b_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.b_dangky.Location = new System.Drawing.Point(775, 305);
            this.b_dangky.Name = "b_dangky";
            this.b_dangky.Size = new System.Drawing.Size(104, 42);
            this.b_dangky.TabIndex = 3;
            this.b_dangky.Text = "Dang ky";
            this.b_dangky.UseVisualStyleBackColor = true;
            this.b_dangky.Click += new System.EventHandler(this.b_dangky_Click);
            // 
            // rb_dahoc
            // 
            this.rb_dahoc.AutoSize = true;
            this.rb_dahoc.Location = new System.Drawing.Point(183, 27);
            this.rb_dahoc.Name = "rb_dahoc";
            this.rb_dahoc.Size = new System.Drawing.Size(60, 17);
            this.rb_dahoc.TabIndex = 1;
            this.rb_dahoc.Text = "Da hoc";
            this.rb_dahoc.UseVisualStyleBackColor = true;
            this.rb_dahoc.CheckedChanged += new System.EventHandler(this.rb_dahoc_CheckedChanged);
            // 
            // rb_dangky
            // 
            this.rb_dangky.AutoSize = true;
            this.rb_dangky.Location = new System.Drawing.Point(249, 26);
            this.rb_dangky.Name = "rb_dangky";
            this.rb_dangky.Size = new System.Drawing.Size(65, 17);
            this.rb_dangky.TabIndex = 2;
            this.rb_dangky.Text = "Dang ky";
            this.rb_dangky.UseVisualStyleBackColor = true;
            this.rb_dangky.CheckedChanged += new System.EventHandler(this.rb_dangky_CheckedChanged);
            // 
            // rb_khoahoc
            // 
            this.rb_khoahoc.AutoSize = true;
            this.rb_khoahoc.Checked = true;
            this.rb_khoahoc.Location = new System.Drawing.Point(19, 28);
            this.rb_khoahoc.Name = "rb_khoahoc";
            this.rb_khoahoc.Size = new System.Drawing.Size(56, 17);
            this.rb_khoahoc.TabIndex = 5;
            this.rb_khoahoc.TabStop = true;
            this.rb_khoahoc.Text = "Tat ca";
            this.rb_khoahoc.UseVisualStyleBackColor = true;
            this.rb_khoahoc.CheckedChanged += new System.EventHandler(this.rb_khoahoc_CheckedChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.rb_dangky);
            this.Controls.Add(this.rb_khoahoc);
            this.Controls.Add(this.rb_dahoc);
            this.Controls.Add(this.b_dangky);
            this.Controls.Add(this.rb_danghoc);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.RadioButton rb_danghoc;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button b_dangky;
        private System.Windows.Forms.RadioButton rb_dahoc;
        private System.Windows.Forms.RadioButton rb_dangky;
        private System.Windows.Forms.RadioButton rb_khoahoc;
    }
}

