using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyWebServices.Models;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace MyWebServices.DAL
{
    public class PasienDAL
    {
        private string strConn = "";
        public PasienDAL()
        {
            strConn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }


        //select 
        public IEnumerable<Pasien> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(strConn))
            {
                string strSql = @"select * from Pasien order by Nama asc";
                var results = conn.Query<Pasien>(strSql);
                return results;
            }
        }
    }
}