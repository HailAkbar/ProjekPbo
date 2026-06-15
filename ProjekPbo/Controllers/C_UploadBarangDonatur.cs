using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPbo.Controllers
{
    public class C_UploadBarangDonatur
    {
        public DataTable AmbilKategori()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM kategori";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public void SimpanBarang(string nama, string kondisi, string deskripsi, int idDonatur, int idKategori, string foto)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                NpgsqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string querybarang = "INSERT INTO barang " +
                        "(" +
                        "nama_barang, " +
                        "kondisi, " +
                        "deskripsi, " +
                        "status, " +
                        "tanggal_upload, " +
                        "id_donatur, " +
                        "id_kategori" +
                        ") " +
                        "VALUES " +
                        "(" +
                        "@nama, " +
                        "@kondisi, " +
                        "@deskripsi, " +
                        "@status, " +
                        "NOW(), " +
                        "@id_donatur, " +
                        "@id_kategori" +
                        ") " +
                        "RETURNING id_barang";

                    NpgsqlCommand cmd = new NpgsqlCommand(querybarang, conn);
                    cmd.Transaction = transaction;

                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@kondisi", kondisi);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                    cmd.Parameters.AddWithValue("@status", "Menunggu Verifikasi");
                    cmd.Parameters.AddWithValue("@id_donatur", idDonatur);
                    cmd.Parameters.AddWithValue("@id_kategori", idKategori);

                    int idBarang = Convert.ToInt32(cmd.ExecuteScalar());


                    //nambah foto
                    byte[] fotoBytes = File.ReadAllBytes(foto);
                    string queryfoto_barang = "INSERT INTO foto_barang (id_barang, foto_barang) VALUES (@id_barang, @foto_barang)";

                    cmd = new NpgsqlCommand(queryfoto_barang, conn);
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@id_barang", idBarang);
                    cmd.Parameters.AddWithValue("@foto_barang", fotoBytes);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
