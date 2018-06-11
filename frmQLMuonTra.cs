using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TTCSDL
{
    public partial class frmQLMuonTra : Form
    {
        int ngay=0;
        decimal tien=0;
        connect con = new connect();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string user, pass, maquyen;
        public frmQLMuonTra()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain t = new frmMain(pass, user, maquyen);
            t.ShowDialog();
        }

        private void btnYCTra_Click(object sender, EventArgs e)
        {
            bool Mat=false;
            bool Muon=false;
            int k = dgv1.CurrentCell.RowIndex;
            int gia = 0;
            if(cb.Checked==true)
            {
                try
                {
                    con.Cmd = new SqlCommand("sp_GiaSach '" + dgv1.Rows[k].Cells[1].Value.ToString() + "'", con.Conn1);
                    con.Cmd.CommandType = CommandType.Text;
                    con.OpenConn();
                    gia = (int)con.Cmd.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("Báo lỗi");
                }
                con.CloseConn();
                Mat = true;
                Muon = false;
            }
            else
            {
                int n = 2,day1=0,day2=0;
                Mat = false;
                try
                {
                    string sql="sp_ChenhLech '" + dgv1.Rows[k].Cells[4].Value.ToString() + "','" + DateTime.Today.Month + "/"+DateTime.Today.Day+"/"+DateTime.Today.Year + "'";
                    con.Cmd = new SqlCommand(sql, con.Conn1);
                    con.Cmd.CommandType = CommandType.Text;
                    con.OpenConn();
                    n = (int)con.Cmd.ExecuteScalar();
                    //MessageBox.Show("" + n);
                    if (n == -1)
                    {
                        Muon = true;
                        string sql1 = "sp_SoNgay '" + dgv1.Rows[k].Cells[4].Value.ToString() + "'";
                        string sql2 = "sp_SoNgay '" + DateTime.Today.ToShortDateString() + "'";
                        con.Cmd = new SqlCommand(sql1, con.Conn1);
                        con.Cmd.CommandType = CommandType.Text;
                        con.OpenConn();
                        day1 = (int)con.Cmd.ExecuteScalar();
                        con.Cmd.CommandText = sql2;
                        day2 = (int)con.Cmd.ExecuteScalar();
                        gia = (day2 - day1) * 1000;
                        con.CloseConn();
                        
                    }
                    else
                    {
                        Muon = false;
                        gia = 0;
                    }
                    
                }
                catch
                {
                    MessageBox.Show("so sanh 2 ngày xảy ra bị lỗi","thông báo lỗi");
                }
            }
            dt1.Rows.Add(dgv1.Rows[k].Cells[0].Value.ToString(), dgv1.Rows[k].Cells[1].Value.ToString(), dgv1.Rows[k].Cells[2].Value.ToString(), dgv1.Rows[k].Cells[3].Value.ToString(), dgv1.Rows[k].Cells[4].Value.ToString(), DateTime.Today.ToShortDateString(), gia, Mat, Muon);
            dt.Rows.RemoveAt(k);
            dgv1.DataSource = dt;
            dgv1.Refresh();
            dgv2.DataSource = dt1;
            dgv2.Refresh();
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            int k = dgv2.CurrentCell.RowIndex;
            dt.Rows.Add(dgv2.Rows[k].Cells[0].Value.ToString(), dgv2.Rows[k].Cells[1].Value.ToString(), dgv2.Rows[k].Cells[2].Value.ToString(), dgv2.Rows[k].Cells[3].Value.ToString(), dgv2.Rows[k].Cells[4].Value.ToString());
            dt1.Rows.RemoveAt(k);
            dgv1.DataSource = dt;
            dgv1.Refresh();
            dgv2.DataSource = dt1;
            dgv2.Refresh();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            this.tien = (decimal)dt1.Compute("Sum([Tiền phạt])","");
            DialogResult dg = MessageBox.Show("người đọc có chấp nhận nộp "+this.tien+" tiền phạt không ?","thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dg==DialogResult.Yes)
            {
                foreach (DataRow row in dt1.Rows)
                {
                    if ((Boolean)row[7] == true)
                    {
                        try
                        {

                            if (con.SetData("sp_XoaSach '" + row[1].ToString() + "'") == true)
                            {
                                if (con.SetData("update PhieuMuon set TrangThai = N'đã trả',NgayTra='" + row[5].ToString() + "' where MaPhieu= '" + row[0].ToString() + "'") == true)
                                {
                                    MessageBox.Show("Trả sách thành công", "thông báo");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("thủ tục trả sách bị lỗi");
                        }

                    }
                    else
                    {
                        try
                        {
                            con.SetData("update Sach set TrangThai=N'vẫn còn' where MaSach='"+row[1].ToString()+"'");
                            con.SetData("update PhieuMuon set TrangThai = N'đã trả',NgayTra='" + row[5].ToString() + "' where MaPhieu= '" + row[0].ToString() + "'");
                                MessageBox.Show("Trả sách thành công", "thông báo");
                        }
                        catch
                        {
                            MessageBox.Show("thủ tục trả sách bị lỗi");
                        }
                    }
                }
            }
        }

        //private void butChuyen_Click(object sender, EventArgs e)
        //{
        //    int r = dgv1.CurrentCell.RowIndex;
        //    string sql4 = "update Sach set GhiChu=0 where MaSach= '"+ dgv1.Rows[r].Cells[1].Value.ToString()+"'";
        //    string sql3 = "sp_TraSach '" + dgv1.Rows[r].Cells[1].Value.ToString() + "','" + dgv1.Rows[r].Cells[0].Value.ToString() + "'";
        //    if (cb.Checked==true)
        //    {
        //        con.OpenConn();
        //        SqlCommand cm_d = new SqlCommand("sp_GiaSach N'" + dgv1.Rows[r].Cells[1].Value.ToString() + "'",con.Conn);
        //        tien += (decimal)cm_d.ExecuteScalar();
        //        con.SetData(sql4);
        //        cm_d.Dispose();
        //    }
        //    else
        //    {
        //        try
        //        {
        //            con.OpenConn();
        //            int n=0;
        //            DateTime d=DateTime.Now;
        //            string sql = "sp_ChenhLechDate '" + dgv1.Rows[r].Cells[4].Value.ToString() + "','"+dateTimePicker1.Text+"','"+n+" output'";
        //            string sql1 = "sp_SoNgay "+ dgv1.Rows[r].Cells[4].Value.ToString();
        //            string sql2 = "sp_SoNgay "+d.ToString();
        //            SqlCommand cmd1 = new SqlCommand(sql1, con.Conn);
        //            SqlCommand cmd2 = new SqlCommand(sql2, con.Conn);
        //            con.GetData(sql);
        //            if (n==-1)
        //            {
        //                ngay += (int)cmd2.ExecuteScalar() - (int)cmd1.ExecuteScalar();
        //            }
        //            cmd1.Dispose();
        //            cmd2.Dispose();
        //            dgv1.Rows.Remove(dgv1.Rows[r]);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Trả sách bị lỗi.","thông báo lỗi");
        //        }
        //        con.SetData(sql3);
        //        con.CloseConn();
        //    }
        //}

        public frmQLMuonTra(string user,string pass,string quyen)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
            this.maquyen = quyen;
            dt1.Columns.Add("Mã phiếu",typeof(string));
            dt1.Columns.Add("Mã sách", typeof(string));
            dt1.Columns.Add("Tên sách", typeof(string));
            dt1.Columns.Add("Ngày mượn", typeof(DateTime));
            dt1.Columns.Add("Ngày hẹn trả", typeof(DateTime));
            dt1.Columns.Add("Ngày trả", typeof(DateTime));
            dt1.Columns.Add("Tiền phạt", typeof(decimal));
            dt1.Columns.Add("Bị mất", typeof(Boolean));
            dt1.Columns.Add("Trả muộn", typeof(Boolean));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "sp_TTMuonSach N'"+txtMaThe.Text+"'";
                dt = con.GetData(sql);
                dgv1.DataSource = dt;
                dgv1.Refresh();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mã thẻ!","Thông báo");
            }
        }
    }
}
