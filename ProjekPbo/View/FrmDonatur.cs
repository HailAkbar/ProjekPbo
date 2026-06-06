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

namespace ProjekPbo.View
{
    public partial class FrmDonatur : Form
    {
        private Donatur donatur;

        public FrmDonatur(Donatur d)
        {
            InitializeComponent();
            donatur = d;
        }

        private void FrmDonatur_Load(object sender, EventArgs e)
        {
            lblNama.Text = donatur.nama;

            StatistiknyaDonatur();
            TampilkanBarangTerbaru();
        }

        private int Hitungstatistik(string status)
        {
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM barang WHERE id_donatur = @id_donatur AND status = @status";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_donatur", donatur.id);
                        cmd.Parameters.AddWithValue("@status", status);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung statistik: " + ex.Message);
                return 0;
            }
        }

        private void StatistiknyaDonatur()
        {
            lblMenunggu.Text = "Menunggu: " + Hitungstatistik("Menunggu Verifikasi").ToString();
            lblDiterima.Text = "Diterima: " + Hitungstatistik("Diterima").ToString();
            lblDitolak.Text = "Ditolak: " + Hitungstatistik("Ditolak").ToString();
            lblSelesai.Text = "Selesai: " + Hitungstatistik("Selesai").ToString();
        }

        private void TampilkanBarangTerbaru()
        {
            try
            {
                flpBarang.Controls.Clear();

                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT nama_barang, status 
                                     FROM barang 
                                     WHERE id_donatur = @id_donatur 
                                     ORDER BY tanggal_upload DESC 
                                     LIMIT 1";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_donatur", donatur.id);

                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read()) 
                            {
                                Label lblBarang = new Label();
                                lblBarang.AutoSize = true;
                                lblBarang.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                                lblBarang.Text = $"{dr["nama_barang"]} - Status: {dr["status"]}";
                                lblBarang.ForeColor = Color.Black;

                                flpBarang.Controls.Add(lblBarang);
                            }
                            else
                            {
                                Label lblKosong = new Label();
                                lblKosong.AutoSize = true;
                                lblKosong.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                                lblKosong.Text = "Belum ada riwayat donasi barang.";
                                lblKosong.ForeColor = Color.Gray;

                                flpBarang.Controls.Add(lblKosong);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat barang terbaru: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            FrmUploadBarang frm = new FrmUploadBarang(donatur);
            frm.Show();
            this.Close();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FrmRiwayatDonasi frm = new FrmRiwayatDonasi(donatur);
            frm.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            // Tambahkan navigasi form profil Anda di sini jika diperlukan kelak
        }

        private void FrmDonatur_Load_1(object sender, EventArgs e)
        {
            lblNama.Text = donatur.nama;

            StatistiknyaDonatur();
            TampilkanBarangTerbaru();
        }
    }
}