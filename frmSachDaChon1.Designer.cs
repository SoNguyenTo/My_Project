namespace TTCSDL
{
    partial class frmSachDaChon1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btTroLai = new System.Windows.Forms.Button();
            this.btXinDuyet = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tín sách đã chọn";
            // 
            // btTroLai
            // 
            this.btTroLai.Location = new System.Drawing.Point(713, 302);
            this.btTroLai.Name = "btTroLai";
            this.btTroLai.Size = new System.Drawing.Size(78, 23);
            this.btTroLai.TabIndex = 1;
            this.btTroLai.Text = "Trở lại";
            this.btTroLai.UseVisualStyleBackColor = true;
            // 
            // btXinDuyet
            // 
            this.btXinDuyet.Location = new System.Drawing.Point(612, 302);
            this.btXinDuyet.Name = "btXinDuyet";
            this.btXinDuyet.Size = new System.Drawing.Size(81, 23);
            this.btXinDuyet.TabIndex = 2;
            this.btXinDuyet.Text = "Xin duyệt";
            this.btXinDuyet.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 19);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(795, 182);
            this.dgv.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // frmSachDaChon1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TTCSDL.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(832, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btXinDuyet);
            this.Controls.Add(this.btTroLai);
            this.Controls.Add(this.label1);
            this.Name = "frmSachDaChon1";
            this.Text = "frmSachDaChon1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTroLai;
        private System.Windows.Forms.Button btXinDuyet;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}