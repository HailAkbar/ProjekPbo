using Npgsql;
using ProjekPbo.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_Pengelola
    {
        public int HitungStatusnyaa(string status)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM barang WHERE status = @status";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
