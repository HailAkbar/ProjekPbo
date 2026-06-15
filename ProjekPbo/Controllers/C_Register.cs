using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_Register
    {
        public void register(Donatur donatur)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO donatur " +
                    "( " +
                    "nama, " +
                    "email, " +
                    "sandi, " +
                    "nomor_hp, " +
                    "alamat" +
                    ")" +
                    "VALUES " +
                    "(" +
                    "@nama, " +
                    "@email, " +
                    "@sandi, " +
                    "@nomor_hp, " +
                    "@alamat" +
                    ")";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", donatur.nama);
                cmd.Parameters.AddWithValue("@email", donatur.email);
                cmd.Parameters.AddWithValue("@sandi", donatur.sandi);
                cmd.Parameters.AddWithValue("@nomor_hp", donatur.nomorHp);
                cmd.Parameters.AddWithValue("@alamat", donatur.Alamat);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
