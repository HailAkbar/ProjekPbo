using Npgsql;
using ProjekPbo.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_StatistikPengelola
    {
        public int HitungJumlah(string status) // ngehitung jumlah barang donasi berdasarkan status dalam database, kayanya ini pake konsep oop 
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM barang WHERE status=@status";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int HitungTotal() //ngehitung total buat barang donasi yang ada di database
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM barang";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public DataTable StatistikKategori()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query =
                    @"SELECT " +
                        "k.nama_kategori, " +
                        "COUNT(*) AS jumlah " +
                        "FROM barang b " +
                        "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                        "GROUP BY k.nama_kategori " +
                        "ORDER BY k.nama_kategori DESC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
