using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Models;
using ProjekPbo.Database;
using ProjekPbo.View;
using Npgsql;

namespace ProjekPbo.View
{
    public partial class FrmDaftarBarangPengelola : Form
    {
        private Pengelola pengelola;
        public FrmDaftarBarangPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
        }

        private void FrmDaftarBarangPengelola_Load(object sender, EventArgs e)
        {
            TampilkanBarang();
        }

        private void TampilkanBarang()
        {
            try
            {
                flpBarang.Controls.Clear();

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
                            " k.nama_kategori " +
                        "FROM barang b " +
                        "JOIN donatur d ON b.id_donatur = d.id_donatur " +
                        "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                        "WHERE b.status = 'Menunggu Verifikasi' " +
                        " ORDER BY b.tanggal_upload desc ";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Cardnya(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Cardnya(NpgsqlDataReader dr)
        {
            int idBarang = Convert.ToInt32(dr["id_barang"]);
            Panel card = new Panel();

            card.Width = 320;
            card.Height = 130;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);


            Label lblNama = new Label();
            lblNama.Text = dr["nama_barang"].ToString();
            lblNama.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNama.Location = new Point(10, 10);
            lblNama.AutoSize = true;

            Label lblDonatur = new Label();
            lblDonatur.Text = "Donatur : " + dr["nama"].ToString();
            lblDonatur.Location = new Point(10, 40);
            lblDonatur.AutoSize = true;

            Label lblKategori = new Label();
            lblKategori.Text = "Kategori : " + dr["nama_kategori"].ToString();
            lblKategori.Location = new Point(10, 65);
            lblKategori.AutoSize = true;

            Button btnDetail = new Button();
            btnDetail.Text = "Verifikasi";
            btnDetail.Width = 100;
            btnDetail.Height = 35;
            btnDetail.Location = new Point(200, 80);

            btnDetail.Click += (s, e) =>
            {
                FrmDetailVerifikasi frm = new FrmDetailVerifikasi(idBarang, pengelola);
                frm.ShowDialog();
                TampilkanBarang();
            };

            card.Controls.Add(lblNama);
            card.Controls.Add(lblDonatur);
            card.Controls.Add(lblKategori);
            card.Controls.Add(btnDetail);

            flpBarang.Controls.Add(card);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilkanBarang();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void CariBarang()
        {
            try
            {
                flpBarang.Controls.Clear();

                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT" +
                            " b.id_barang, " +
                            " b.nama_barang," +
                            " d.nama," +
                            " k.nama_kategori " +
                        "FROM barang b " +
                        "JOIN donatur d ON b.id_donatur=d.id_donatur " +
                        "JOIN kategori k ON b.id_kategori=k.id_kategori " +
                        "WHERE b.status='Menunggu Verifikasi' AND LOWER(b.nama_barang) LIKE LOWER(@nama) ";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nama", "%" + txtCari.Text + "%");

                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Cardnya(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.Show();
            this.Close();
        }
    }
}
