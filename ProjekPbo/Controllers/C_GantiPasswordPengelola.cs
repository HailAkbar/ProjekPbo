using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using ProjekPbo.Models;
using ProjekPbo.Database;

namespace ProjekPbo.Controllers
{
    public class C_GantiPasswordPengelola
    {
        public bool gantiPassword(Pengelola pengelola, string passLama, string passBaru)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string cekPassword = @"SELECT * FROM pengelola WHERE id_pengelola = @id AND sandi = @sandi";

                NpgsqlCommand cmd = new NpgsqlCommand(cekPassword, conn);
                cmd.Parameters.AddWithValue("@id", pengelola.id);
                cmd.Parameters.AddWithValue("@sandi", passLama);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    dr.Close();
                    return false;
                }

                dr.Close();

                string updatePassword = @"UPDATE pengelola SET sandi = @sandibaru WHERE id_pengelola = @id";

                cmd = new NpgsqlCommand(updatePassword, conn);
                cmd.Parameters.AddWithValue("@sandibaru", passBaru);
                cmd.Parameters.AddWithValue("@id", pengelola.id);
                cmd.ExecuteNonQuery();

                return true;
            }
            }
    }
}
