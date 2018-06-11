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
    public partial class AddTD : Form
    {
        String pass = "", user = "", maquyen = "";
        connect con =new connect();
        private void AddTD_Load(object sender, EventArgs e)
        {
            NgayDK.Text = DateTime.Now.ToShortDateString();
            string sql = "sp_HienThiDG";
            DataTable dt = new DataTable();
            try
            {
                dt = con.GetData(sql);
                cbMDG.DataSource = dt;
                cbMDG.ValueMember = "MaDocGia";
            }
            catch
            {
                MessageBox.Show("hiển thị bị lỗi","thông báo");
            }
        }
        void TroLai()
        {
            this.Hide();
            frmQLTheDoc t = new frmQLTheDoc(user, pass, maquyen);
            t.ShowDialog();
        }
        private void butBack_Click(object sender, EventArgs e)
        {
            TroLai();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            int n=1;
            string sql = "sp_KTTheDoc '"+cbMDG.Text+"'";
            con.Cmd = new System.Data.SqlClient.SqlCommand(sql,con.Conn1);
            try
            {
                if ((int)con.Cmd.ExecuteScalar()==1)
                {
                         MessageBox.Show("không tồn tại độc giả này","thông báo");
                }
                else
                {
                    string sql1 = "sp_ThemTheDoc '" + NgayDK.Text + "','" + NgayHH.Text + "','" + cbMDG.Text + "'";
                    if (con.SetData(sql1) == true)
                    {
                        MessageBox.Show("Thêm thẻ đọc thành công", "thông báo");
                        TroLai();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thẻ đọc không thành công.vui lòng kiểm tra lại", "thông báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi vui lòng kiểm tra lại", "thông báo");
            }
        }

        public AddTD()
        {
            InitializeComponent();
        }
        public AddTD(string Pass,string User,string Maquyen)
        {
            InitializeComponent();
            this.pass = Pass;
            this.user = User;
            this.maquyen = Maquyen;
        }
    }
}
