using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TTCSDL
{
    class connect
    {
       public SqlConnection Conn;
        private SqlCommand _cmd;
        //private string username;
        //private string passqord;
        //private string quyen;
        private string StrCon = null;
        private string _error;

        //public string UserName
        //{
        //    get { return username; }
        //    set { username = value; }
        //}
        //public string PassWord
        //{
        //    get { return passqord; }
        //    set { passqord = value; }
        //}
        //public string Quyen
        //{
        //    get { return quyen; }
        //    set { quyen = value; }
        //}
        public SqlConnection Conn1
        {
            get
            {
                return Conn;
            }

            set
            {
                Conn = value;
            }
        }

        public SqlCommand Cmd
        {
            get
            {
                return _cmd;
            }

            set
            {
                _cmd = value;
            }
        }

        public string Error
        {
            get
            {
                return _error;
            }

            set
            {
                _error = value;
            }
        }

        public  connect()
        {
            StrCon = @"Data Source=DUNG-PC\SQLEXPRESS;Initial Catalog=HTThuVien;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
            
        }
      
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch(Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }catch(Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
       public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }catch(Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return dt;
        }
        public bool  SetData(string sql)
        {
            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return false;
        }
    }
}
