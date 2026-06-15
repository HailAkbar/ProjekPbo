using Npgsql;
using ProjekPbo.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_KelolaKategoriPengelola
    {
        public DataTable ambilkategori()
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query =
                    @"SELECT id_kategori, nama_kategori " +
                     "FROM kategori " +
                     "ORDER BY id_kategori";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void TambahKategori(string nama)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO kategori (nama_kategori) VALUES (@nama)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditKategori(int id, string nama)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query =
                    @"UPDATE kategori " +
                     "SET nama_kategori = @nama " +
                     "WHERE id_kategori = @id ";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void HapusKategori(int id)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query =
                    @"DELETE FROM kategori " +
                     "WHERE id_kategori=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
