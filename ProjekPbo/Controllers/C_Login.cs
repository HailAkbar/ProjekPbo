using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.Models;
using ProjekPbo.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_Login
    {
        public object LoginUser(string email, string password)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                //login donatur
                string queryDonatur = "SELECT * FROM donatur WHERE email = @Email AND sandi = @Sandi"; //inisialisasi
                NpgsqlCommand cmd = new NpgsqlCommand(queryDonatur, conn);
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sandi", password);

                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Donatur donatur = new Donatur();
                        donatur.id = Convert.ToInt32(dr["id_donatur"]);
                        donatur.nama = dr["nama"].ToString();
                        donatur.email = dr["email"].ToString();
                        donatur.sandi = dr["sandi"].ToString();
                        donatur.nomorHp = dr["nomor_hp"].ToString();
                        donatur.Alamat = dr["alamat"].ToString();

                        dr.Close();
                        return donatur;
                    }

                    dr.Close();

                    //login pengelola

                    string queryPengelola = "SELECT * FROM pengelola WHERE email = @Email AND sandi = @Sandi";
                    cmd = new NpgsqlCommand(queryPengelola, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sandi", password);

                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Pengelola pengelola = new Pengelola();
                        pengelola.id = Convert.ToInt32(dr["id_pengelola"]);
                        pengelola.nama = dr["nama"].ToString();
                        pengelola.email = dr["email"].ToString();
                        pengelola.sandi = dr["sandi"].ToString();
                        pengelola.nomorHp = dr["nomor_hp"].ToString();

                        dr.Close();
                        return pengelola;
                    }
                    dr.Close();
                    return null;
                }
            }
        }
    }
}
