namespace Server
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
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_add = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.b_search = new System.Windows.Forms.Button();
            this.rb_khoahoc = new System.Windows.Forms.RadioButton();
            this.rb_sinhvien = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_dangky = new System.Windows.Forms.RadioButton();
            this.rb_dahoc = new System.Windows.Forms.RadioButton();
            this.rb_danghoc = new System.Windows.Forms.RadioButton();
            this.b_del = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(12, 53);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(750, 296);
            this.dgv_main.TabIndex = 0;
            this.dgv_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startConnectToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // startConnectToolStripMenuItem
            // 
            this.startConnectToolStripMenuItem.Name = "startConnectToolStripMenuItem";
            this.startConnectToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.startConnectToolStripMenuItem.Text = "Start/Connect";
            this.startConnectToolStripMenuItem.Click += new System.EventHandler(this.startConnectToolStripMenuItem_Click);
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.b_add.Location = new System.Drawing.Point(768, 211);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(104, 42);
            this.b_add.TabIndex = 2;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(432, 27);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(330, 20);
            this.tb_search.TabIndex = 3;
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(768, 27);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(104, 23);
            this.b_search.TabIndex = 4;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // rb_khoahoc
            // 
            this.rb_khoahoc.AutoSize = true;
            this.rb_khoahoc.Checked = true;
            this.rb_khoahoc.Location = new System.Drawing.Point(0, 2);
            this.rb_khoahoc.Name = "rb_khoahoc";
            this.rb_khoahoc.Size = new System.Drawing.Size(73, 17);
            this.rb_khoahoc.TabIndex = 5;
            this.rb_khoahoc.TabStop = true;
            this.rb_khoahoc.Text = "Khoa Hoc";
            this.rb_khoahoc.UseVisualStyleBackColor = true;
            this.rb_khoahoc.CheckedChanged += new System.EventHandler(this.rb_khoahoc_CheckedChanged);
            // 
            // rb_sinhvien
            // 
            this.rb_sinhvien.AutoSize = true;
            this.rb_sinhvien.Location = new System.Drawing.Point(88, 0);
            this.rb_sinhvien.Name = "rb_sinhvien";
            this.rb_sinhvien.Size = new System.Drawing.Size(70, 17);
            this.rb_sinhvien.TabIndex = 6;
            this.rb_sinhvien.TabStop = true;
            this.rb_sinhvien.Text = "Sinh Vien";
            this.rb_sinhvien.UseVisualStyleBackColor = true;
            this.rb_sinhvien.CheckedChanged += new System.EventHandler(this.rb_sinhvien_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_sinhvien);
            this.groupBox1.Controls.Add(this.rb_khoahoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 22);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_dangky);
            this.groupBox2.Controls.Add(this.rb_dahoc);
            this.groupBox2.Controls.Add(this.rb_danghoc);
            this.groupBox2.Location = new System.Drawing.Point(176, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 17);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rb_dangky
            // 
            this.rb_dangky.AutoSize = true;
            this.rb_dangky.Location = new System.Drawing.Point(151, 0);
            this.rb_dangky.Name = "rb_dangky";
            this.rb_dangky.Size = new System.Drawing.Size(65, 17);
            this.rb_dangky.TabIndex = 2;
            this.rb_dangky.Text = "Dang ky";
            this.rb_dangky.UseVisualStyleBackColor = true;
            this.rb_dangky.CheckedChanged += new System.EventHandler(this.rb_dangky_CheckedChanged);
            // 
            // rb_dahoc
            // 
            this.rb_dahoc.AutoSize = true;
            this.rb_dahoc.Location = new System.Drawing.Point(78, 0);
            this.rb_dahoc.Name = "rb_dahoc";
            this.rb_dahoc.Size = new System.Drawing.Size(60, 17);
            this.rb_dahoc.TabIndex = 1;
            this.rb_dahoc.Text = "Da hoc";
            this.rb_dahoc.UseVisualStyleBackColor = true;
            this.rb_dahoc.CheckedChanged += new System.EventHandler(this.rb_dahoc_CheckedChanged);
            // 
            // rb_danghoc
            // 
            this.rb_danghoc.AutoSize = true;
            this.rb_danghoc.Checked = true;
            this.rb_danghoc.Location = new System.Drawing.Point(0, 0);
            this.rb_danghoc.Name = "rb_danghoc";
            this.rb_danghoc.Size = new System.Drawing.Size(72, 17);
            this.rb_danghoc.TabIndex = 0;
            this.rb_danghoc.TabStop = true;
            this.rb_danghoc.Text = "Dang hoc";
            this.rb_danghoc.UseVisualStyleBackColor = true;
            this.rb_danghoc.CheckedChanged += new System.EventHandler(this.rb_danghoc_CheckedChanged);
            // 
            // b_del
            // 
            this.b_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.b_del.Location = new System.Drawing.Point(768, 307);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(104, 42);
            this.b_del.TabIndex = 9;
            this.b_del.Text = "Del";
            this.b_del.UseVisualStyleBackColor = true;
            this.b_del.Click += new System.EventHandler(this.b_del_Click);
            // 
            // b_edit
            // 
            this.b_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.b_edit.Location = new System.Drawing.Point(768, 259);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(104, 42);
            this.b_edit.TabIndex = 10;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startConnectToolStripMenuItem;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.RadioButton rb_khoahoc;
        private System.Windows.Forms.RadioButton rb_sinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_danghoc;
        private System.Windows.Forms.RadioButton rb_dangky;
        private System.Windows.Forms.RadioButton rb_dahoc;
        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Button b_edit;
    }
}

