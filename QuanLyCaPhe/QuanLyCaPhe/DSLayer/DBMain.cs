﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DBLayer
{
    class DBMain
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter dt = null;

        //string strConnection = "Data Source=DESKTOP-9O7TSTT\\SQLEXPRESS;" + "Initial Catalog=QuanLyCaPhe;" + "Integrated Security=True";
        string strConnection = "Data Source=./;" + "Initial Catalog=QuanLyCaPhe;" + "Integrated Security=True";
        public DBMain()
        {
            conn = new SqlConnection(strConnection);
            cmd = conn.CreateCommand();
        }

        /// <summary>
        /// Lấy dữ liệu đổ lên dataset
        /// </summary>
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            //Kiểm tra xem csdl đang kết nối, để đóng lại
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            cmd.CommandType = ct;
            cmd.CommandText = strSQL;

            dt = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            dt.Fill(ds);

            return ds;
        }

        /// <summary>
        /// Thực hiện câu truy vấn, dùng để cập nhật, xóa, thêm.
        /// </summary>
        /// <returns></returns>
        public bool MyExecuteNonQuery(string strSQL, CommandType ct,ref string error)
        {
            bool f = false;

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();

                cmd.CommandText = strSQL;
                cmd.CommandType = ct;

                cmd.ExecuteNonQuery();

                f = true;
            }
            catch (SqlException sqlEx)
            {
                error = sqlEx.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        /// <summary>
        /// Lấy dữ liệu dòng đầu tiên của câu truy vấn.
        /// </summary>
        public object FirstRowQuery(string strSQL, CommandType ct, string error)
        {
            object obj = null;

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();

                cmd.CommandText = strSQL;
                cmd.CommandType = ct;

                obj = cmd.ExecuteScalar();
            }
            catch (SqlException sqlEx)
            {
                error = sqlEx.Message;
            }
            finally
            {
                conn.Close();
            }

            return obj;
        }

        /// <summary>
        /// Kiểm tra thông tin tài khoản.
        /// </summary>
        /// 
        public bool CheckThongTin(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
               
              
                cmd.CommandText = strSQL;
                cmd.CommandType = ct;
                int k = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (k > 0)                
                    f = true;                                    
            }
            catch (SqlException sqlEx)
            {
                error = sqlEx.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public void LayMa(string strSQL,CommandType ct,ref string MaNV)
        {
            
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();

                cmd.CommandText = strSQL;
                cmd.CommandType = ct;
                MaNV = (String)cmd.ExecuteScalar().ToString();                
            }
            catch (SqlException )
            {
               
            }
            finally
            {
                conn.Close();
            }           

        }
     

    }
}
