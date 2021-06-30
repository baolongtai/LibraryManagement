using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLThuVien
{
    class ConnectionString
    {
        SqlConnection sqlConn;
        string strConn = @"Data Source=DESKTOP-2LKP1H4\BAOLONGSQL;Initial Catalog=LIBRARYMANGAE;Integrated Security=True";
        public DataTable dtTable;
        SqlDataAdapter sqlDtA = new SqlDataAdapter();
        SqlCommand sqlComm;
        DataSet dts;
        

        public SqlConnection OpenConnect()
        {
            sqlConn = new SqlConnection(strConn);
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            return sqlConn;
        }
        public SqlConnection CloseConnect()
        {
            sqlConn = new SqlConnection(strConn);
            if (sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
            return sqlConn;
        }
        
        public DataTable LoadData(string sql)
        {
            dtTable = new DataTable();
            try
            {
                OpenConnect(); 
                //sqlComm = sqlConn.CreateCommand();
                //sqlComm.CommandText = sql;
                sqlDtA = new SqlDataAdapter(sql, strConn);
                //sqlDtA.SelectCommand = sqlComm;
                dts = new DataSet();
                sqlDtA.Fill(dtTable);
            }
            catch (System.Exception)
            {
                dtTable = null;
            }
            finally
            {
                CloseConnect();
            }
            return dtTable;
        }
        
        public string Take1Value(string sql)
        {
            string result = "";
            try
            {
                OpenConnect();
                sqlComm = new SqlCommand(sql, sqlConn);
                SqlDataReader sqlDtReader = sqlComm.ExecuteReader();
                if(sqlDtReader.Read()){
                    result = sqlDtReader["total"].ToString();
                }
            }
            catch{}
            finally
            {
                CloseConnect();
            }
            return result;
        }

        public int DataProcessing(string strsql)
        {
            int result = 0;
            try
            {
                OpenConnect();
                sqlComm = new SqlCommand(strsql, sqlConn);
                result = sqlComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
                result = 0;
            }
            finally
            {
                CloseConnect();
            }
            return result;
        }
    }
}
