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
    public partial class frmMain : Form
    {
       
        connect con = new connect();
        String pass="", user="", maquyen="";
        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin t = new frmLogin();
            t.Show();
        }
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (maquyen == "Quyen2" || maquyen == "Quyen3")
            {
                this.Hide();
                frmCapNhat t = new frmCapNhat(user,pass, maquyen) ;
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }

        }



        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( maquyen == "Quyen2" || maquyen == "Quyen3")
            {
                this.Hide();
                frmQLTheDoc t = new frmQLTheDoc(user, pass, maquyen);
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (maquyen == "Quyen2" || maquyen == "Quyen3")
            {
                this.Hide();
                frmQLMuonTra t = new frmQLMuonTra(user, pass, maquyen);            
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( maquyen == "Quyen3")
            {
                this.Hide();
                frmQLNhanVien t = new frmQLNhanVien(user, pass, maquyen);
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
        }
        private void timkiem()
        {
            DataTable dt = new DataTable();
            if (comboBox1.Text == "Tên sách")
            {
                dt = con.GetData("sp_ThongTinSach_theoTenSach N'" + txttimkiem.Text + "'");
    
            }
            if(comboBox1.Text == "Tên nhà sản xuất")
            {
                dt = con.GetData("sp_ThongTinSach_theoTenNhaXB N'" + txttimkiem.Text + "'");
            }
            if (comboBox1.Text == "Sách chuyên ngành")
            {
                dt = con.GetData("sp_ThongTinSach_theoSachChuyenNganh N'" + txttimkiem.Text + "'");
            }
            if (comboBox1.Text == "Tên tác giả")
            {
                dt = con.GetData("sp_ThongTinSach_theoTenTacGia N'" + txttimkiem.Text + "'");
            }
            if (comboBox1.Text == "Nhóm sách")
            {
                dt = con.GetData("sp_ThongTinSach_theoTenNhom N'" + txttimkiem.Text + "'");
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void hienthi()
        {
            DataTable dt = new DataTable();
            dt = con.GetData("sp_Main");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            hienthi();
            string sql = "sp_CapNhat";
            try
            {
                if (con.SetData(sql) == true)
                    MessageBox.Show("Cập nhật thành công","thông báo");
            }
            catch
            {
                MessageBox.Show("cập nhật thẻ đọc bị lỗi","thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTaiKhoan t = new frmQLTaiKhoan(user,pass,maquyen);
            t.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            this.Hide();
            frmMuon t = new frmMuon(user, pass, maquyen,dataGridView1.Rows[r].Cells[0].Value.ToString(), dataGridView1.Rows[r].Cells[1].Value.ToString(), dataGridView1.Rows[r].Cells[3].Value.ToString(), dataGridView1.Rows[r].Cells[4].Value.ToString(), dataGridView1.Rows[r].Cells[5].Value.ToString(), dataGridView1.Rows[r].Cells[6].Value.ToString(), dataGridView1.Rows[r].Cells[7].Value.ToString(), dataGridView1.Rows[r].Cells[8].Value.ToString());
            t.ShowDialog();
        }

        //private void phêDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (maquyen != "Quyen1")
        //    {
        //        this.Hide();
        //        FrmPheDuyet t = new FrmPheDuyet(user, pass, maquyen);
        //        t.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Bạn không có quyền");
        //    }
        //}

        private void phêDuyệtSáchMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (maquyen != "Quyen1")
            {
                this.Hide();
                FrmPheDuyet t = new FrmPheDuyet(user, pass, maquyen);
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (maquyen == "Quyen2" || maquyen == "Quyen3")
            {
                this.Hide();
                frmCapNhat t = new frmCapNhat(user, pass, maquyen);
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string pass, string user, string maquyen)
        {
            InitializeComponent();
            this.pass = pass;
            this.user = user;
            this.maquyen = maquyen;
        }       
    }
}
