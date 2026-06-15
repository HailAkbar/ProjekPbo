using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.Models;

namespace ProjekPbo.Controllers
{
    public class C_DetailVerifikasiPengelola
    {
        public DataTable DetailBarang(int idBarang)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query = @"SELECT " +
                                  "b.nama_barang, " +
                                  "b.kondisi, " +
                                  "k.nama_kategori, " +
                                  "b.deskripsi, " +
                                  "b.tanggal_upload, " +
                                  "d.nama AS donatur, " +
                                  "f.foto_barang " +
                                  "FROM barang b " +
                                  "JOIN donatur d ON b.id_donatur = d.id_donatur " +
                                  "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                                  "LEFT JOIN foto_barang f ON b.id_barang = f.id_barang " +
                                  "WHERE b.id_barang = @id_barang";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_barang", idBarang);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public bool NyimpenVerif(int idBarang, Pengelola pengelola, string catatan, string status)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string queryverif = "INSERT INTO verifikasi " +
                                            "(" +
                                            "id_barang, " +
                                            "id_pengelola," +
                                            "tanggal_verifikasi," +
                                            "catatan" +
                                            ") " +
                                            "VALUES " +
                                            "(" +
                                            "@barang, " +
                                            "@pengelola, " +
                                            "NOW()," +
                                            "@catatan" +
                                            ")";

                        NpgsqlCommand cmd = new NpgsqlCommand(queryverif, conn);
                        cmd.Transaction = transaction;

                        cmd.Parameters.AddWithValue("@barang", idBarang);
                        cmd.Parameters.AddWithValue("@pengelola", pengelola.id);
                        cmd.Parameters.AddWithValue("@catatan", catatan);

                        cmd.ExecuteNonQuery();

                        string queryUpdateStatus = "UPDATE barang SET status = @status WHERE id_barang = @id";

                        cmd = new NpgsqlCommand(queryUpdateStatus, conn);
                        cmd.Transaction = transaction;

                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", idBarang);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Verifikasi Berhasil");
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }   
    }
}
