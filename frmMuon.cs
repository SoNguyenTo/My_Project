using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL
{

    public partial class frmMuon : Form
    {


        string user, pass, maquyen;
        string MaSach="";
        string TenSach="";
        string TenNhaXB="";
        string TieuDe="";
        string TenTG="";
        string SCN="";
        string NhomSach="";
        string Gia="";
        connect con = new connect();
        public frmMuon()
        {
            InitializeComponent();
        }
        public frmMuon(string user,string pass,string maquyen,string MaSach,string TenSach,string TenNhaXB,string TieuDe,string TenTG,string SCN,string NhomSach,string Gia)
        {
            InitializeComponent();
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.TenNhaXB = TenNhaXB;
            this.TieuDe = TieuDe;
            this.TenTG = TenTG;
            this.SCN = SCN;
            this.NhomSach = NhomSach;
            this.Gia = Gia;
            this.user = user;
            this.pass = pass;
            this.maquyen = maquyen;
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain t = new frmMain(pass, user, maquyen);
            t.ShowDialog();
        }

        private void frmMuon_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = this.MaSach;
            txtCN.Text = this.SCN;
            txtGia.Text = this.Gia;
            txtKe.Text = this.TieuDe;
            txtNhom.Text = this.NhomSach;
            TxtNXB.Text = this.TenNhaXB;
            txtTG.Text = this.TenTG;
            txtTenSach.Text = this.TenSach;
        }

        private void btMuon_Click(object sender, EventArgs e)
        {
            con.OpenConn();
            string sql;
            if(this.maquyen=="Quyen1")
                sql= "select MaTD from TaiKhoan where users like N'"+this.user+"'";
            else
                sql = "select MaNV from TaiKhoan where users like N'" + this.user + "'";
            string MaTD ;
            con.Cmd = new SqlCommand(sql,con.Conn);
            con.Cmd.CommandType = CommandType.Text;
            MaTD = con.Cmd.ExecuteScalar().ToString();
            string sql1 = "sp_KiemTraTD '" + MaTD + "'";
            string sql2;
            if (this.maquyen == "Quyen1")
                sql2 = "sp_TaoPhieu '" + MaTD + "',1,N'"+txtMaSach.Text+"'";
            else
                sql2 = "sp_TaoPhieu '" + MaTD + "',0,N'" + txtMaSach.Text + "'";
            if(this.maquyen!="Quyen1")
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn mượn quyển sách này không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        con.SetData(sql2);
                        con.SetData("sp_TaoTTMuonSach_NV '" + txtMaSach.Text + "','" + MaTD + "'");
                        con.SetData("update Sach set TrangThai=N'đang mượn' where MaSach = '"+txtMaSach.Text+"'");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi không mượn được sách.", "thông báo");
                    }
                }
                
            }
            else
            {
                try
                {
                    con.Cmd.CommandText = sql1;
                    if ((int)con.Cmd.ExecuteScalar() == 1)
                    {
                        DialogResult dg = MessageBox.Show("Bạn có muốn mượn quyển sách này không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            con.Cmd.CommandText = sql2;
                            con.Cmd.ExecuteNonQuery();
                            MessageBox.Show("sách đã được thêm vào giỏ chờ nhân viên phê duyệt.", "thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn còn nợ sách hoặc thẻ của bạn đã hết hạn.", "thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi không mượn được sách.", "thông báo");
                }
            }
            con.CloseConn();
        }
    }
}
