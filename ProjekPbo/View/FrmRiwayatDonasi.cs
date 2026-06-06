using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using ProjekPbo.Database;

namespace ProjekPbo.View
{
    public partial class FrmRiwayatDonasi : Form
    {
        public Donatur donatur;

        public FrmRiwayatDonasi(Donatur d)
        {
            InitializeComponent();
            donatur = d;
        }

        private void FrmRiwayatDonasi_Load(object sender, EventArgs e)
        {
            TampilinRiwayatDonasi();
        }

        private void TampilinRiwayatDonasi()
        {
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    flpRiwayat.Controls.Clear();

                    string query =
                     @"SELECT" +
                            " b.id_barang," +
                            " b.nama_barang," +
                            " k.nama_kategori," +
                            " b.kondisi," +
                            " b.status," +
                            " b.tanggal_upload " +
                     "FROM barang b " +
                     "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                     "WHERE b.id_donatur = @id" +
                     " ORDER BY b.tanggal_upload DESC";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", donatur.id);

                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    bool adaData = false;

                    while (dr.Read())
                    {
                        adaData = true;

                        Nambah(
                            dr["nama_barang"].ToString(),
                            dr["nama_kategori"].ToString(),
                            dr["kondisi"].ToString(),
                            dr["status"].ToString(),
                            Convert.ToDateTime(dr["tanggal_upload"]).ToString("dd-MM-yyyy")
                        );
                    }

                    if (!adaData)
                    {
                        Label lblKosong = new Label();
                        lblKosong.Text = "Belum ada riwayat donasi.";
                        lblKosong.Font = new Font("Segoe UI", 11, FontStyle.Italic);
                        lblKosong.ForeColor = Color.Gray;
                        lblKosong.AutoSize = true;
                        lblKosong.Margin = new Padding(20, 20, 0, 0); 

                        flpRiwayat.Controls.Add(lblKosong);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil riwayat donasi: " + ex.Message);
            }
        }

        private void Nambah(string nama, string kategori, string kondisi, string status, string tanggal)
        {
            Panel card = new Panel();
            card.Width = 300;
            card.Height = 120;
            card.BorderStyle = BorderStyle.FixedSingle;

            Label lblNama = new Label();
            lblNama.Text = nama;
            lblNama.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNama.Location = new Point(10, 10);
            lblNama.AutoSize = true;

            Label lblKategori = new Label();
            lblKategori.Text = "Kategori : " + kategori;
            lblKategori.Location = new Point(10, 35);
            lblKategori.AutoSize = true;

            Label lblKondisi = new Label();
            lblKondisi.Text = "Kondisi : " + kondisi;
            lblKondisi.Location = new Point(10, 55);
            lblKondisi.AutoSize = true;

            Label lblStatus = new Label();
            lblStatus.Text = "Status : " + status;
            lblStatus.Location = new Point(10, 75);
            lblStatus.AutoSize = true;

            Label lblTanggal = new Label();
            lblTanggal.Text = tanggal;
            lblTanggal.Location = new Point(200, 90);
            lblTanggal.AutoSize = true;

            card.Controls.Add(lblNama);
            card.Controls.Add(lblKategori);
            card.Controls.Add(lblKondisi);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblTanggal);

            flpRiwayat.Controls.Add(card);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilinRiwayatDonasi();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmDonatur frmDonatur = new FrmDonatur(donatur);
            frmDonatur.Show();
            this.Close();
        }

        private void FrmRiwayatDonasi_Load_1(object sender, EventArgs e)
        {
            TampilinRiwayatDonasi();
        }
    }
}