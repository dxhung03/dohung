using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Baitaplon.Net
{
    internal class Database
    {
        private String cnstr = "Data Source=DESKTOP-QUKTEPT\\SQLEXPRESS;Initial Catalog=QLyThueSach; User ID=sa;Password=dohung123";
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;

        public Database()
        {
            try
            {
                conn = new SqlConnection(cnstr);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lstPara != null)
                {
                    foreach (var para in lstPara)
                    {
                        cmd.Parameters.AddWithValue(para.Name, para.Value);
                    }
                }
                
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int ExeCute(string sql, List<CustomParameter> lstPara = null)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lstPara != null)
                {
                    foreach (var p in lstPara)
                    {
                        cmd.Parameters.AddWithValue(p.Name, p.Value);
                    }
                }
                
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public class CustomParameter
        {
            public string Name { get; set; }

            public string Value { get; set; }
        }

        public class ComboboxItem
        {
            public string Name { get; set; }

            public string Value { get; set; }
        }
    }
}