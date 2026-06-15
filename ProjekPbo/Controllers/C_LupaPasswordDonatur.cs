using Npgsql;
using ProjekPbo.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_LupaPasswordDonatur
    {
        public bool LupaPassword(string email, string passwordBaru)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string cekEmail = @"SELECT COUNT(*) FROM donatur WHERE email = @email";

                NpgsqlCommand cmd = new NpgsqlCommand(cekEmail, conn);

                cmd.Parameters.AddWithValue("@email", email);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());

                if (jumlah == 0)
                {
                    return false;
                }

                string updatepassword = @"UPDATE donatur SET sandi = @sandi WHERE email = @email";

                cmd = new NpgsqlCommand(updatepassword, conn);
                cmd.Parameters.AddWithValue("@sandi", passwordBaru);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }
}
