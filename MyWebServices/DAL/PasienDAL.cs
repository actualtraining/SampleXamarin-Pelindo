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

        public Pasien GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSql = @"select * from Pasien where PasienID=@PasienID";
                var result = conn.QuerySingleOrDefault<Pasien>(strSql, new { PasienID = id });
                return result;
            }
        }

        public void Insert(Pasien pasien)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSql = @"insert into Pasien(Nama,Alamat,Telpon,Umur) 
                                  values(@Nama,@Alamat,@Telpon,@Umur)";
                try
                {
                    var param = new { Nama = pasien.Nama, Alamat = pasien.Alamat,
                        Telpon = pasien.Telpon, Umur = pasien.Umur };
                    conn.Execute(strSql,param);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void Update(Pasien pasien)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSql = @"update Pasien set Nama=@Nama,Alamat=@Alamat,Telpon=@Telpon,Umur=@Umur 
                                  where PasienID=@PasienID";
                try
                {
                    var param = new
                    {
                        Nama = pasien.Nama,
                        Alamat = pasien.Alamat,
                        Telpon = pasien.Telpon,
                        Umur = pasien.Umur,
                        PasienID = pasien.PasienID
                    };
                    conn.Execute(strSql, param);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSql = @"delete from Pasien where PasienID=@PasienID";
                try
                {
                    var param = new
                    {
                        PasienID = id
                    };
                    conn.Execute(strSql, param);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}