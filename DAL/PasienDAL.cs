using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BO;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace DAL
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
                /*SqlCommand cmd = new SqlCommand(strSql, conn);
                conn.Open();
                List<Pasien> listPasien = new List<Pasien>();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var newPasien = new Pasien
                        {
                            PasienID = Convert.ToInt32(dr["PasienID"]),
                            Nama = dr["Nama"].ToString(),
                            Alamat = dr["Alamat"].ToString(),
                            Telpon = dr["Telpon"].ToString(),
                            Umur = Convert.ToInt32(dr["Umur"].ToString())
                        };
                        listPasien.Add(newPasien);
                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();

                return listPasien;*/

                var results = conn.Query<Pasien>(strSql);

                //var queryresult = from p in results where p.Nama.Contains("erick") select p;

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