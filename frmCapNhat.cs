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
    public partial class frmCapNhat : Form
    {
        connect con = new connect();
        String pass = "", user = "", maquyen = "";
        bool KT = true;

        public frmCapNhat()
        {
            InitializeComponent();
        }

        public frmCapNhat(string user, string pass, string MaQuyen)
        {
            InitializeComponent();
            this.pass = pass;
            this.user = user;
            this.maquyen = MaQuyen;
        }
        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            hienthi();
            this.showmake();
            this.showtennhom();
            this.showchuyennganh();
        }
        private void hienthi()
        {
            DataTable tb = new DataTable();
            try
            {
                tb = con.GetData("sp_ThongTinSach");
                dataGridView1.DataSource = tb;
                dataGridView1.Refresh();
            }
            catch 
            {
                MessageBox.Show("fail");
            }  
            

        }
        private void showmake()
        {
            //con.OpenConn();
            //string tk = "select TieuDe from KeSach";
            //SqlDataAdapter da = new SqlDataAdapter(tk, con.Conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //cbmake.DataSource = ds.Tables[0];
            //cbmake.ValueMember = "TieuDe";
            //con.CloseConn();

            DataTable tb = new DataTable();
            tb = con.GetData("select TieuDe from KeSach");
            cbmake.DataSource = tb;
            cbmake.ValueMember = "TieuDe";
        }
        private void showchuyennganh()
        {
            //con.OpenConn();
            //string tk = "select TenChuyenNganh from SachChuyenNganh";
            //SqlDataAdapter da = new SqlDataAdapter(tk, con.Conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //cbcn.DataSource = ds.Tables[0];
            //cbcn.ValueMember = "TenChuyenNganh";
            //con.CloseConn();
            DataTable tb = new DataTable();
            tb = con.GetData("select TenChuyenNganh from SachChuyenNganh");
            cbcn.DataSource = tb;
            cbcn.ValueMember = "TenChuyenNganh";

        }
        private void showtennhom()
        {
            //con.OpenConn();
            //string tk = "select TenNhom from NhomSach";
            //SqlDataAdapter da = new SqlDataAdapter(tk, con.Conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //cbtennhom.DataSource = ds.Tables[0];
            //cbtennhom.ValueMember = "TenNhom";
            //con.CloseConn();

            DataTable tb = new DataTable();
            tb = con.GetData("select TenNhom from NhomSach");
            cbtennhom.DataSource =tb;
            cbtennhom.ValueMember = "TenNhom";
        }


        private void butthem_Click(object sender, EventArgs e)
        {
            gbTT.Enabled = true;
            gbDuLieu.Enabled = false;
            butsua.Enabled = false;
            butxoa.Enabled = false;

            lbMa.Visible = false;
            txtMaSach.Visible = false;
            butLuu.Enabled = true;
            butReset.Enabled = true;
            butTrolai.Enabled = true;

            txtMaSach.Focus();
            KT = true;
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            if(KT==true)
            {
                try
                {
                    DialogResult dg = new DialogResult();
                    dg = MessageBox.Show("Bạn có muốn thêm sách này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        if(con.SetData("sp_ThemSach N'" + txtTenSach.Text + "',N'" + txtTG.Text + "',N'" + cbcn.Text + "',N'" + cbmake.Text + "',N'" + cbtennhom.Text + "',N'" + txtNXB.Text + "',N'" + txtGia.Text + "'")==true)
                            MessageBox.Show("Bạn đã thêm vào thành công.", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn thêm vào không thành công.", "Kiểm tra lại");
                }
                hienthi();
            }
            else
            {
                try
                {
                    DialogResult dg = new DialogResult();
                    dg = MessageBox.Show("Bạn có muốn thay đổi thông tin sách này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                                                                       
                        if (con.SetData("sp_SuaSach N'" +txtMaSach.Text+"',N'"+ txtTenSach.Text + "',N'" + cbmake.Text + "',N'" + txtTG.Text + "',N'" + txtNXB.Text + "',N'" + cbtennhom.Text + "',N'" + cbcn.Text + "',N'" +  txtGia.Text + "'") == true)
                            MessageBox.Show("Bạn đã thay đổi thành công.", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn sửa vào không thành công.", "Kiểm tra lại");
                }
                hienthi();
            }
        }

        int k;
        private void butsua_Click(object sender, EventArgs e)
        {
            gbTT.Enabled = true;

            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                k = r;
                txtMaSach.Text=dataGridView1.Rows[r].Cells[0].Value.ToString();
                txtTenSach.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                cbmake.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
                txtTG.Text= dataGridView1.Rows[r].Cells[3].Value.ToString();
                cbcn.Text= dataGridView1.Rows[r].Cells[4].Value.ToString();
                txtNXB.Text= dataGridView1.Rows[r].Cells[5].Value.ToString();
                cbtennhom.Text= dataGridView1.Rows[r].Cells[6].Value.ToString();
                txtGia.Text= dataGridView1.Rows[r].Cells[7].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("không thể hiển thị ra được", "đã có lỗi xảy ra");
            }

            butLuu.Enabled = true;
            butReset.Enabled = true;
            butTrolai.Enabled = true;

            lbMa.Enabled = true;
            txtMaSach.Enabled = true;

            butxoa.Enabled = false;
            butthem.Enabled = false;

            txtTenSach.Focus();
            KT = false;
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            if(dataGridView1.Rows[r].Cells[8].Value.ToString()=="đang mượn")
            {
                MessageBox.Show("Không thể xóa sách khi nó đang được mượn!","Thông báo");
            }
            else
            {
                try
                {
                    DialogResult dg = new DialogResult();
                    dg = MessageBox.Show("Bạn có muốn xóa sách này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dg==DialogResult.Yes)
                    {
                        if(con.SetData("sp_XoaSach '" + dataGridView1.Rows[r].Cells[0].Value.ToString() + "'")==true)
                            MessageBox.Show("Bạn đã xóa thành công.","Thông báo");
                    }
                }
               catch(Exception)
                {
                    MessageBox.Show("Bạn xóa không thành công.", "Kiểm tra lại");
                }
                hienthi();
            }
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            int r = k;

            txtMaSach.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenSach.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            cbmake.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtTG.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            cbcn.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            txtNXB.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            cbtennhom.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            txtGia.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
        }

        private void butTrolai_Click(object sender, EventArgs e)
        {
            gbTT.Enabled = false;
            gbDuLieu.Enabled = true;
            if(KT==true)
            {
                butsua.Enabled = true;
                butxoa.Enabled = true;
            }
            else
            {
                butxoa.Enabled = true;
                butthem.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMain t = new frmMain(pass,user,maquyen);
            t.ShowDialog();
        }
    }
}
