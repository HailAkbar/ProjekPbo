using Npgsql;
using ProjekPbo.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_DaftarBarangPengelola
    {
        public DataTable AmbilBarang()
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT" +
                            " b.id_barang, " +
                            " b.nama_barang, " +
                            " b.kondisi, " +
                            " b.tanggal_upload, " +
                            " d.nama, " +
                            " k.nama_kategori, " +
                            " MIN(f.foto_barang) AS foto_barang " +
                        "FROM barang b " +
                        "JOIN donatur d ON b.id_donatur = d.id_donatur " +
                        "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                        "JOIN foto_barang f ON b.id_barang = f.id_barang " +
                        "WHERE b.status = 'Menunggu Verifikasi' " +
                        "GROUP BY b.id_barang, d.nama, k.nama_kategori " +
                        "ORDER BY b.tanggal_upload desc ";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable AmbilBarang(string namaKategoriBarang)
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT" +
                            " b.id_barang, " +
                            " b.nama_barang, " +
                            " b.kondisi, " +
                            " b.tanggal_upload, " +
                            " d.nama, " +
                            " k.nama_kategori, " +
                            " MIN(f.foto_barang) AS foto_barang " +
                        "FROM barang b " +
                        "JOIN donatur d ON b.id_donatur = d.id_donatur " +
                        "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                        "JOIN foto_barang f ON b.id_barang = f.id_barang " +
                        "WHERE b.status='Menunggu Verifikasi' AND LOWER(k.nama_kategori) LIKE LOWER(@nama_kategori) " +
                        "GROUP BY b.id_barang, d.nama, k.nama_kategori " +
                        "ORDER BY b.tanggal_upload desc ";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    {
                        cmd.Parameters.AddWithValue("@nama_kategori", "%" + namaKategoriBarang + "%");
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
