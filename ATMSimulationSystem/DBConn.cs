using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

//

namespace ATMManager
{
    class DBConn
    {
        
        #region sqlserver connection and operation


        public static string serverIP = "";
        public static string dataBaseName = "";
        public static string dataLoginName = "";
        public static string dataLoinPassword = "";

        public static SqlConnection con = null;
        /// <summary>
        ///define sql connection SqlConnection
        /// </summary>
        /// <returns></returns>
        public static SqlConnection SqlGetCon()
        {
            if (con != null) return con;
            con = new SqlConnection();
         //   System.Configuration.AppSettingsReader asr = new System.Configuration.AppSettingsReader();

            con.ConnectionString = "Server=.;Database=ATMData;Persist Security Info=True;User ID=yinfei;Password=yinf0913";
            try
            {  
                con.Open();
            }
            catch
            {
                DBConn.MessageOk("cannot connect to server,please check the database configuratin and setting....");
                return null;
            }
            return con;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="SqlStr"></param>
        /// <returns></returns>
        public static string SqlExecSqlScalar(string sql)
        {
            SqlGetCon();
            if (con == null)
                return "0";
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            try
            {
                object obj = com.ExecuteScalar();
                if (obj == null || obj == DBNull.Value)
                    return "0";
                return obj.ToString();
            }
            catch
            {
                return "0";
            }
        }

        /// <summary>
        /// sql command returns dataTable
        /// </summary>
        /// <param name="SqlStr"></param>
        /// <returns></returns>
        public static DataTable SqlExecSqlReturnDataTable(string sql)
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            SqlGetCon();
            if (con == null)
                return null;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "Table");
                table = ds.Tables["Table"];
                return table;
            }
            catch
            {
                table = null;
                return table;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SqlStr"></param>
        /// <returns></returns>
        public static bool SqlExecSqlReturn(string sql)
        {
            SqlGetCon();
            if (con == null)
                return false;
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            try
            {
                Console.Write("track3");
                if (com.ExecuteNonQuery() > 0)
                    return true;
                else
                    Console.Write("track4");
                    return false;
            }
            catch
            {
                Console.Write("track4");
                return false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="SqlStr"></param>
        /// <param name="ParaPic"></param>
        /// <param name="Pic"></param>
        /// <returns></returns>
        public static bool SqlExecSqlReturn(string sql, string ParaPic, byte[] Pic)
        {
            SqlGetCon();
            if (con == null)
                return false;
            SqlCommand com = new SqlCommand();
            com.Parameters.Add(ParaPic, SqlDbType.Image);
            com.Parameters[0].Value = Pic;
            com.Connection = con;
            com.CommandText = sql;
            try
            {
                com.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region return dialog box
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DialogResult MessageOk(string value)
        {
            return MessageBox.Show(value, "System Remind", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// The alarm dialog
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DialogResult MessageWarning(string value)
        {
            return MessageBox.Show(value, "System Remind", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DialogResult MessageYesNo(string value)
        {
            return MessageBox.Show(value, "System Remind", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool confirmButtonYes()
        {
            DialogResult result = MessageBox.Show("Delete information selected？", "System Remind", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool confirmAllRecordButtonYes()
        {
            DialogResult result = MessageBox.Show("Delete all the information？", "System Remind", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool confirmAdd()
        {
            DialogResult result = MessageBox.Show("Successful add，continue to add？", "System Remind", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        #endregion
        #region exchange between image and byte[]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image imageIn)
        {
            byte[] content = null;
            try
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, imageIn.RawFormat);
                content = ms.ToArray();
            }
            catch
            {
                content = null;
            }
            return content;
        }

        /// <summary>
        /// from byte[] to image
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        #endregion
       
       
       
      
    }
}