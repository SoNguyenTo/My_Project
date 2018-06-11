namespace TTCSDL
{
    partial class AddTD
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMDG = new System.Windows.Forms.ComboBox();
            this.NgayDK = new System.Windows.Forms.DateTimePicker();
            this.NgayHH = new System.Windows.Forms.DateTimePicker();
            this.butLuu = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm thẻ đọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đăng ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hết hạn";
            // 
            // cbMDG
            // 
            this.cbMDG.FormattingEnabled = true;
            this.cbMDG.Location = new System.Drawing.Point(141, 58);
            this.cbMDG.Name = "cbMDG";
            this.cbMDG.Size = new System.Drawing.Size(134, 21);
            this.cbMDG.TabIndex = 4;
            // 
            // NgayDK
            // 
            this.NgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayDK.Location = new System.Drawing.Point(141, 101);
            this.NgayDK.Name = "NgayDK";
            this.NgayDK.Size = new System.Drawing.Size(134, 20);
            this.NgayDK.TabIndex = 5;
            // 
            // NgayHH
            // 
            this.NgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayHH.Location = new System.Drawing.Point(141, 146);
            this.NgayHH.Name = "NgayHH";
            this.NgayHH.Size = new System.Drawing.Size(134, 20);
            this.NgayHH.TabIndex = 6;
            // 
            // butLuu
            // 
            this.butLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLuu.Location = new System.Drawing.Point(35, 187);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(75, 23);
            this.butLuu.TabIndex = 17;
            this.butLuu.Text = "Lưu lại";
            this.butLuu.UseVisualStyleBackColor = true;
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBack
            // 
            this.butBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.Location = new System.Drawing.Point(200, 187);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 18;
            this.butBack.Text = "Trở lại";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // AddTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 229);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.NgayHH);
            this.Controls.Add(this.NgayDK);
            this.Controls.Add(this.cbMDG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTD";
            this.Text = "AddTD";
            this.Load += new System.EventHandler(this.AddTD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMDG;
        private System.Windows.Forms.DateTimePicker NgayDK;
        private System.Windows.Forms.DateTimePicker NgayHH;
        private System.Windows.Forms.Button butLuu;
        private System.Windows.Forms.Button butBack;
    }
}