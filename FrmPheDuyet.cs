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
    public partial class FrmPheDuyet : Form
    {
        string user, pass, maquyen;
        connect con = new connect();

        public FrmPheDuyet()
        {
            InitializeComponent();
        }

        private void butDuyet_Click(object sender, EventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            string sql= "sp_NVPheDuyet '"+dgv.Rows[r].Cells[0].Value.ToString()+"','"+this.user+"'";
            try
            {
                if(con.SetData(sql)==true)
                {
                    con.SetData("sp_TaoTTMuonSach '"+dgv.Rows[r].Cells[2].Value.ToString()+"','"+dgv.Rows[r].Cells[1].Value.ToString()+"'");
                    con.SetData("update Sach set TrangThai=N'đang mượn' where MaSach = '" + dgv.Rows[r].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("Phê duyệt thành công", "thông báo");
                }
                    
            }
            catch
            {
                MessageBox.Show("Lỗi không phê duyệt được","thông báo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain t = new frmMain(pass, user, maquyen);
            t.ShowDialog();
        }

        public FrmPheDuyet(string user,string pass,string quyen)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
            this.maquyen = quyen;
        }
        private void FrmPheDuyet_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "sp_TTPhieuMuon";
            try
            {
                dt = con.GetData(sql);
                dgv.DataSource = dt;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.Refresh();
            }
            catch
            {
                MessageBox.Show("Hiển thị thông tin bị lỗi","thông báo");
            }
        }
    }
}
