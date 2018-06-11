using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL
{
    public partial class SuaTD : Form
    {
        String pass = "", user = "", maquyen = "";
        string MaThe,MaDG,TenDG,ngaydk,ngayhh,ViPham;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TroLai();
        }

        connect con = new connect();
        void TroLai()
        {
            this.Hide();
            frmQLTheDoc t = new frmQLTheDoc(user, pass, maquyen);
            t.ShowDialog();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult db= MessageBox.Show("bạn muốn lưu lại thông tin mình vừa nhập", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(db==DialogResult.Yes)
                {
                    try
                    {
                        string sql = "update TheDoc set NgayHH = '" + NgayHH.Text + "' where MaThe = '" + txtMa.Text + "'";
                        if (con.SetData(sql) == true)
                        {
                            MessageBox.Show("Gia hạn thẻ đọc thành công", "thông báo");
                            TroLai();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Gia hạn thẻ đọc không thành công", "thông báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy  ra lôi vui lòng kiểm tra lại", "thông báo");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMa.Text = this.MaThe;
            txtMaDocGia.Text = this.MaDG;
            txtTen.Text = this.TenDG;
            txtViPham.Text = this.ViPham;
            NgayDK.Text = this.ngaydk;
            NgayHH.Text = this.ngayhh;
        }

        public SuaTD()
        {
            InitializeComponent();
        }
        public SuaTD(string pass,string user,string maquyen,string MaThe,string MaDG,string TenDG,string ngaydk,string ngayhh,string ViPham)
        {
            InitializeComponent();
            this.pass = pass;
            this.user = user;
            this.maquyen = maquyen;
            txtMa.Text = MaThe;
            this.MaThe = MaThe;
            txtMaDocGia.Text = MaDG;
            this.MaDG = MaDG;
            txtTen.Text = TenDG;
            this.TenDG = TenDG;
            txtViPham.Text = ViPham;
            this.ViPham = ViPham;
            NgayDK.Text = ngaydk;
            this.ngaydk = ngaydk;
            NgayHH.Text = ngayhh;
            this.ngayhh = ngayhh;
        }
       
    }
}
