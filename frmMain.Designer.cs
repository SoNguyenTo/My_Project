namespace TTCSDL
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phêDuyệtSáchMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::TTCSDL.Properties.Resources.Search2;
            this.button1.Location = new System.Drawing.Point(899, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sách chuyên ngành",
            "Tên sách",
            "Tên tác giả",
            "Tên nhà sản xuất",
            "Nhóm sách",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(448, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Tìm kiếm theo";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(614, 123);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(268, 30);
            this.txttimkiem.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Azure;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(857, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Logout";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.BackgroundImage = global::TTCSDL.Properties.Resources._1;
            this.groupBox5.Controls.Add(this.menuStrip3);
            this.groupBox5.Location = new System.Drawing.Point(0, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(941, 48);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackgroundImage = global::TTCSDL.Properties.Resources._1;
            this.menuStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem1,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(3, 16);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(935, 30);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.phêDuyệtSáchMượnToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem});
            this.bToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.bToolStripMenuItem.Text = "Danh mục";
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.Image = global::TTCSDL.Properties.Resources.IconDocGia;
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quảnToolStripMenuItem.Text = "Quản lý thẻ đọc";
            this.quảnToolStripMenuItem.Click += new System.EventHandler(this.quảnToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.Image = global::TTCSDL.Properties.Resources.mho;
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            this.quảnLýMượnTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::TTCSDL.Properties.Resources._123;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // phêDuyệtSáchMượnToolStripMenuItem
            // 
            this.phêDuyệtSáchMượnToolStripMenuItem.Name = "phêDuyệtSáchMượnToolStripMenuItem";
            this.phêDuyệtSáchMượnToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.phêDuyệtSáchMượnToolStripMenuItem.Text = "Phê duyệt sách mượn";
            this.phêDuyệtSáchMượnToolStripMenuItem.Click += new System.EventHandler(this.phêDuyệtSáchMượnToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem1
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTàiKhoảnToolStripMenuItem1.Image = global::TTCSDL.Properties.Resources.tải_xuống;
            this.quảnLýTàiKhoảnToolStripMenuItem1.Name = "quảnLýTàiKhoảnToolStripMenuItem1";
            this.quảnLýTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem1.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem1_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.Image = global::TTCSDL.Properties.Resources.FAQ_icon;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thư Viện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 264);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tìm kiếm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cập nhật lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TTCSDL.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(957, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem quảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem phêDuyệtSáchMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}