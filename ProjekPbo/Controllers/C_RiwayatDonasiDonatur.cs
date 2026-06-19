using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_RiwayatDonasiDonatur
    {
        public DataTable ambilRiwayat(int idDonatur, string status)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query =
                 @"SELECT" +
                        " b.id_barang," +
                        " b.nama_barang," +
                        " k.nama_kategori," +
                        " b.kondisi," +
                        " b.status," +
                        " b.tanggal_upload," +
                        " fb.foto_barang, " +
                        " COALESCE(v.catatan, 'Tidak ada Catatan') AS catatan " +
                 "FROM barang b " +
                 "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                 "LEFT JOIN verifikasi v ON b.id_barang = v.id_barang " +
                 "LEFT JOIN foto_barang fb ON b.id_barang = fb.id_barang " +
                 "WHERE b.id_donatur = @id ";

                if (!string.IsNullOrEmpty(status))
                {
                    query += " AND b.status = @status";
                }
                query += " ORDER BY b.tanggal_upload DESC";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idDonatur);
                if (!string.IsNullOrEmpty(status))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                }
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public bool HapusBarang(int idBarang)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                using (NpgsqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        string queryFoto = @"DELETE FROM foto_barang WHERE id_barang = @id";
                        using (NpgsqlCommand cmdFoto = new NpgsqlCommand(queryFoto, conn, trans))
                        {
                            cmdFoto.Parameters.AddWithValue("@id", idBarang);
                            cmdFoto.ExecuteNonQuery();
                        }

                        string queryVerifikasi = @"DELETE FROM verifikasi WHERE id_barang = @id";
                        using (NpgsqlCommand cmdVerifikasi = new NpgsqlCommand(queryVerifikasi, conn, trans))
                        {
                            cmdVerifikasi.Parameters.AddWithValue("@id", idBarang);
                            cmdVerifikasi.ExecuteNonQuery();
                        }

                        string queryBarang = @"DELETE FROM barang WHERE id_barang = @id";
                        using (NpgsqlCommand cmdBarang = new NpgsqlCommand(queryBarang, conn, trans))
                        {
                            cmdBarang.Parameters.AddWithValue("@id", idBarang);
                            cmdBarang.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
