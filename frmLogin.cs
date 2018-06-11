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
    public partial class frmLogin : Form
    {

        connect con = new connect();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= con.GetData("select * from TaiKhoan where pass='"+ txtpass.Text + "' and users= '"+ txtuse.Text +"'");
            if (dt.Rows.Count != 0)
            {
                //    con.UserName = dt.Rows[0][0].ToString();
                //    con.PassWord = dt.Rows[0][1].ToString();
                //    con.Quyen = dt.Rows[0][2].ToString();
                frmMain t = new frmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                this.Hide();
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("khong thanh cong");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
