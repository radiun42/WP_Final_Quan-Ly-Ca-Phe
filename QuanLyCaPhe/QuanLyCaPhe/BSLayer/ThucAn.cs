﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DBLayer;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyCaPhe.BSLayer
{
    class ThucAn
    {


        DBMain dbMain = null;
        public ThucAn()
        {
            dbMain = new DBMain();
        }
        public DataSet LayThucAn()
        {
            return dbMain.ExecuteQueryDataSet("select *from ThucAn", CommandType.Text);
        }
        public bool ThemThucAn(string MaThucAn, string DanhMuc, string Gia, string TenMon, ref string error)
        {
            string sqlString;
            try
            {
                sqlString = $"Insert into ThucAn values('{MaThucAn.Trim()}', N'{DanhMuc.Trim()}', N'{Gia.Trim()}',  N'{TenMon.ToString()}')";
            }
            catch (SqlException)
            {
                error = "Thêm không được";
                return false;
            }
            error = "Thêm thành công";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool SuaThucAn(string MaThucAn, string DanhMuc, string Gia, string TenMon, ref string error)
        {
            string sqlString;
            try
            {
                sqlString = "Update ThucAn Set MaThucAn=N'" + MaThucAn + "',DanhMuc=N'" + DanhMuc +
                "',Gia='" + Gia+ "',TenMon='" + TenMon + "'";
            }
            catch (SqlException)
            {
                error = "Sửa không được";
                return false;
            }
            error = "Sửa thành công";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool XoaThucAn(string MaThucAn, ref string error)
        {
            string sqlString = $"delete from ThucAn where MaThucAn = '{MaThucAn}'";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

    }
}
