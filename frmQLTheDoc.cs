using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTCSDL
{
    public partial class frmQLTheDoc : Form
    {
        bool kt;
        String pass = "", user = "", maquyen = "";
        int k;
        public frmQLTheDoc()
        {
            InitializeComponent();
        }
        public frmQLTheDoc(string user, string pass, string MaQuyen)
        {
            InitializeComponent();
            this.pass = pass;
            this.user = user;
            this.maquyen = MaQuyen;
        }
        connect con = new connect();
   
        private void hienthi()
        {
            try
            {
                DataTable tb = new DataTable();
                tb = con.GetData("sp_ThongTinTheDoc");
                dataGridView1.DataSource = tb;
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Lỗi không hiển thị được","Thông báo");
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain t = new frmMain(pass, user, maquyen);
            t.ShowDialog();
        }


        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            hienthi();
            //showMaDG();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTD td = new AddTD(this.pass, this.user, this.maquyen);
            td.ShowDialog();
            //DataTable dt = new DataTable();
            //dt = con.GetData("sp_HienThiDG");
            //cbMaDocGia.DataSource = dt;
            //cbMaDocGia.ValueMember = "MaDocGia";

            //lbTen.Visible = false;
            //txtTen.Visible = false;
            //lbViPham.Visible = false;
            //txtViPham.Visible = false;
            //lbMa.Visible = false;
            //txtMa.Visible = false;
            //butSua.Enabled = false;
            //butxoa.Enabled = false;

            //groupBox1.Enabled = true;
            //kt = true;
            //cbMaDocGia.Focus();

        }

        private void butSua_Click(object sender, EventArgs e)
        {
            this.Hide();
            int r = dataGridView1.CurrentCell.RowIndex;
            SuaTD td = new SuaTD(this.pass,this.user,this.maquyen, dataGridView1.Rows[r].Cells[0].Value.ToString(), dataGridView1.Rows[r].Cells[1].Value.ToString(), dataGridView1.Rows[r].Cells[2].Value.ToString(), dataGridView1.Rows[r].Cells[7].Value.ToString(), dataGridView1.Rows[r].Cells[8].Value.ToString(), dataGridView1.Rows[r].Cells[9].Value.ToString());
            td.ShowDialog();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            //a.MaThe,a.MaDocGia,b.TenDocGia,b.NgaySinh,b.GioiTinh,b.DiaChi,b.SDT,a.NgayDK,a.NgayHH ,c.TenViPham
            if(dataGridView1.Rows[r].Cells[9].Value.ToString()!="không vi phạm")
            {
                MessageBox.Show("không thể xóa thẻ trong khi còn đang mượn sách","thông báo");
            }
            else
            {
                try
                {
                    DialogResult dg = new DialogResult();
                    dg = MessageBox.Show("bạn có muốn xóa thẻ đọc này không?","thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dg==DialogResult.Yes)
                    {
                        if(con.SetData("sp_XoaTheDoc N'"+dataGridView1.Rows[r].Cells[0].Value.ToString()+"'") ==true)
                        {
                            MessageBox.Show("bạn đã xóa thành công thẻ đọc","thông báo");
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("bạn xóa không thành công.","thông báo");
                }
                hienthi();
            }
        }
    }
}
