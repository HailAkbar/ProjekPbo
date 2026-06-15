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
using ProjekPbo.Controllers;

namespace ProjekPbo.View
{
    public partial class FrmRiwayatDonasi : Form
    {
        public Donatur donatur;
        private string filterStatus = "";
        private C_RiwayatDonasiDonatur controller;

        public FrmRiwayatDonasi(Donatur d)
        {
            InitializeComponent();
            donatur = d;
            controller = new C_RiwayatDonasiDonatur();
        }

        private void FrmRiwayatDonasi_Load(object sender, EventArgs e)
        {
            TampilinRiwayatDonasi();
        }

        private void TampilinRiwayatDonasi()
        {
            try
            {
                flpRiwayat.Controls.Clear();
                DataTable dt = controller.ambilRiwayat(donatur.id, filterStatus);
                if(dt.Rows.Count == 0)
                {
                    Label lblKosong = new Label();
                    lblKosong.Text = "Belum ada riwayat donasi.";
                    lblKosong.Font = new Font("Segoe UI", 11, FontStyle.Italic);
                    lblKosong.ForeColor = Color.Gray;
                    lblKosong.AutoSize = true;
                    lblKosong.Margin = new Padding(20, 20, 0, 0);

                    flpRiwayat.Controls.Add(lblKosong);
                    return;
                }

                foreach (DataRow dr in dt.Rows)
                {
                    Nambah(
                            Convert.ToInt32(dr["id_barang"]),
                            dr["nama_barang"].ToString(),
                            dr["nama_kategori"].ToString(),
                            dr["kondisi"].ToString(),
                            dr["status"].ToString(),
                            dr["catatan"].ToString(),
                            Convert.ToDateTime(dr["tanggal_upload"]).ToString("dd-MM-yyyy")
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil riwayat donasi: " + ex.Message);
            }
        }

        private void Nambah(int idBarang, string nama, string kategori, string kondisi, string status, string catatan, string tanggal)
        {
            Panel card = new Panel();
            card.Width = 300;
            card.Height = 180;
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
            lblTanggal.Location = new Point(210, 120);
            lblTanggal.AutoSize = true;

            if (String.IsNullOrEmpty(catatan))
            {
                catatan = "Tidak ada Catatan";
            }
            Label lblCatatan = new Label();
            lblCatatan.Text = "Catatan : " + catatan;
            lblCatatan.MaximumSize = new Size(270, 0);
            lblCatatan.AutoSize = true;
            lblCatatan.Location = new Point(10, 95);

            Button btnHapus = new Button();
            btnHapus.Text = "Hapus";
            btnHapus.Width = 80;
            btnHapus.Height = 30;
            btnHapus.Location = new Point(200, 130);
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = Color.White;
            if (status != "Menunggu Verifikasi")
                if (status != "Menunggu Verifikasi")
                {
                    btnHapus.Visible = false;
                }

            btnHapus.Click += (s, e) =>
            {
                HapusBarang(idBarang, status);
            };

            card.Controls.Add(lblNama);
            card.Controls.Add(lblKategori);
            card.Controls.Add(lblKondisi);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblTanggal);
            card.Controls.Add(lblCatatan);
            card.Controls.Add(btnHapus);

            flpRiwayat.Controls.Add(card);
        }

        private void HapusBarang(int idBarang, string status)
        {
            if (status != "Menunggu Verifikasi")
            {
                MessageBox.Show("Barang yang sudah diverifikasi tidak bisa dihapus");
                return;
            }

            DialogResult hasil = MessageBox.Show("Yakin ingin menghapus barang ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.No)
                return;

            try
            {
                bool berhasil = controller.HapusBarang(idBarang);
                if (berhasil)
                {
                    MessageBox.Show("Barang berhasil dihapus.");
                    TampilinRiwayatDonasi();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus barang.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilinRiwayatDonasi();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmRiwayatDonasi frmDonatur = new FrmRiwayatDonasi(donatur);
            frmDonatur.Show();
            this.Close();
        }

        private void FrmRiwayatDonasi_Load_1(object sender, EventArgs e)
        {
            TampilinRiwayatDonasi();
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            filterStatus = "";
            TampilinRiwayatDonasi();
        }

        private void btnDiterima_Click(object sender, EventArgs e)
        {
            filterStatus = "Diterima";
            TampilinRiwayatDonasi();
        }

        private void btnDitolak_Click(object sender, EventArgs e)
        {
            filterStatus = "Ditolak";
            TampilinRiwayatDonasi();
        }

        private void btnMenunggu_Click(object sender, EventArgs e)
        {
            filterStatus = "Menunggu Verifikasi";
            TampilinRiwayatDonasi();
        }
    }
}