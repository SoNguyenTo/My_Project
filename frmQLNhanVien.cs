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
    public partial class frmQLNhanVien : Form
    {
        connect con = new connect();
        String pass = "", user = "", maquyen = "";
        bool kt;
        int k;
        public frmQLNhanVien()
        {
            InitializeComponent();
        }
        public frmQLNhanVien(string user,string pass,string maquyen)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
            this.maquyen = maquyen;
        }
        private void hienthi()
        {
            try
            {
                DataTable tb = new DataTable();
                tb = con.GetData("sp_ThongTinNhanVien");
                dataGridView1.DataSource = tb;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("fail");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain t = new frmMain(pass, user, maquyen);
            t.ShowDialog();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            butsua.Enabled = false;
            butxoa.Enabled = false;

            txtMaNV.Visible = false;
            lbMaNV.Visible = false;
            txtMaNV.Focus();
            kt = true;
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            txtMaNV.ReadOnly = true;
            butthem.Enabled = false;
            butxoa.Enabled = false;

            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                k = r;
                //a.MaNV,a.TenNV,a.GioiTinh,a.NgaySinh,a.SDT,a.DiaChi,q.TenQuyen
                txtMaNV.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
                txtQuyen.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
                txtTenNV.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                if (dataGridView1.Rows[r].Cells[2].Value.ToString() == "Nam")
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
                dateNS.Text= dataGridView1.Rows[r].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Hiển thị bị lỗi!","Báo lỗi");
            }
            txtTenNV.Focus();
            kt = false;
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muỗn xóa nhân viên này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dg==DialogResult.Yes)
                {
                    if(con.SetData("sp_XoaNV N'"+dataGridView1.Rows[r].Cells[0].Value.ToString()+"'")==true)
                    {
                        MessageBox.Show("Bạn đã xóa thành công.","Thông báo");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công.","Vui lòng kiểm tra lại");
            }
            hienthi();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (kt == true)
            {
                try
                {
                    DialogResult dg = new DialogResult();
                    dg = MessageBox.Show("Bạn có muốn thêm nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        //(@Ten ,@GioiTinh , @NgaySinh @DiaChi  @SDT  @MaQuyen
                        string name;
                        if (rbNam.Checked == true) name = "Nam";
                        else name = "Nữ";
                        con.Cmd = new SqlCommand("sp_TonTaiNV N'" + txtTenNV.Text + "',N'" + name + "',N'" + dateNS.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "'",con.Conn);
                        int n = (int)con.Cmd.ExecuteScalar();
                        if(n==1)
                        {
                            MessageBox.Show("Nhân viên này đang làm việc ở đây rồi","thông báo");
                        }
                        else
                        {
                            if (con.SetData("sp_ThemNV N'" + txtTenNV.Text + "',N'" + name + "',N'" + dateNS.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "',N'" + txtQuyen.Text + "'") == true)
                                MessageBox.Show("Bạn đã thêm vào thành công.", "Thông báo");
                        }
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
                    dg = MessageBox.Show("Bạn có muốn thay đổi thông tin nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        //@MaNV  @Ten ,@GioiTinh ,@NgaySinh @DiaChi @SDT @Quyen 
                        string name;
                        if (rbNam.Checked == true) name = "Nam";
                        else name = "Nữ";
                        if (con.SetData("sp_SuaNV N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + name + "',N'" + dateNS.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "',N'" + txtQuyen.Text + "'") == true)
                            MessageBox.Show("Bạn đã sửa thành công.", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn sửa vào không thành công.", "Kiểm tra lại");
                }
                hienthi();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            int r = k;
            txtMaNV.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            txtQuyen.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            if (dataGridView1.Rows[r].Cells[2].Value.ToString() == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            dateNS.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            if(kt==true)
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
    }
}
