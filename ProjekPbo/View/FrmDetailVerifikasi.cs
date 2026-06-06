using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Models;
using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.View;
using System.Runtime.Intrinsics.Arm;

namespace ProjekPbo.View
{
    public partial class FrmDetailVerifikasi : Form
    {
        private int idBarang;
        private Pengelola pengelola;
        public FrmDetailVerifikasi(int barangId, Pengelola p)
        {
            InitializeComponent();
            idBarang = barangId;
            pengelola = p;
        }

        private void FrmVerivikasi_Load(object sender, EventArgs e)
        {
            TampilkanBarangnya();
        }

        private void TampilkanBarangnya()
        {
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT " +
                                      "b.nama_barang, " +
                                      "b.kondisi, " +
                                      "k.nama_kategori, " +
                                      "b.deskripsi, " +
                                      "b.tanggal_upload, "+
                                      "d.nama AS donatur, " +
                                      "f.foto_barang " +
                                      "FROM barang b " +
                                      "JOIN donatur d ON b.id_donatur = d.id_donatur " +
                                      "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                                      "LEFT JOIN foto_barang f ON b.id_barang = f.id_barang " +
                                      "WHERE b.id_barang = @id_barang";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id_barang", idBarang);

                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        lblNamaBarang.Text = "Nama Barang: " + dr["nama_barang"].ToString();
                        lblNamaDonatur.Text = "Nama Donatur: " + dr["donatur"].ToString();
                        lblKategori.Text = "Kategori: " + dr["nama_kategori"].ToString();
                        lblKondisi.Text = "kondisi: " + dr["kondisi"].ToString();
                        lblTanggal.Text = "Tanggal Upload: " + Convert.ToDateTime(dr["tanggal_upload"]).ToString("dd/MM/yyyy");
                        rtbDeskripsi.Text = "Deskripsi: " + dr["deskripsi"].ToString();

                        if (dr["foto_barang"] != DBNull.Value)
                        {
                            byte[] fotoBytes = (byte[])dr["foto_barang"];
                            using (var ms = new System.IO.MemoryStream(fotoBytes))
                            {
                                picBarang.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    dr.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data barang: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpanVerif("Diterima");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimpanVerif("Ditolak");
        }

        private void SimpanVerif(string status)
        {
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    NpgsqlTransaction transaction = conn.BeginTransaction();

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
                    cmd.Parameters.AddWithValue("@catatan", txtCatatan.Text.Trim());

                    cmd.ExecuteNonQuery();

                    string queryUpdateStatus = "UPDATE barang SET status = @status WHERE id_barang = @id";

                    cmd = new NpgsqlCommand(queryUpdateStatus, conn);
                    cmd.Transaction = transaction;

                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", idBarang);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Verifikasi Berhasil");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data verifikasi: " + ex.Message);
            }
        }
    }
}
