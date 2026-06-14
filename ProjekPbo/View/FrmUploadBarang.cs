using Npgsql;
using ProjekPbo.Models;
using ProjekPbo.Database;
using System.IO;
using ProjekPbo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekPbo.View
{
    public partial class FrmUploadBarang : Form
    {
        private Donatur donatur;
        private string fotoPath = "";
        public FrmUploadBarang(Donatur d)
        {
            InitializeComponent();
            donatur = d;
        }

        private void FrmUploadBarang_Load(object sender, EventArgs e)
        {
            AmbilKategori();
        }

        private void AmbilKategori()
        {
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM kategori";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbKategori.DisplayMember = "nama_kategori";
                    cbKategori.ValueMember = "id_kategori";

                    cbKategori.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil kategori: " + ex.Message);
            }
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPath =
                    openFileDialog1.FileName;

                picFotoBarang.Image =
                    Image.FromFile(fotoPath);
            }
        }

        private string ambilKondisi()
        {
            if (rbBaik.Checked)
                return "Baik";
            else if (rbCukup.Checked)
                return "Cukup";
            else if (rbRusak.Checked)
                return "Rusak";
            else
                return "";
        }

        private bool ValidasiInput()
        {
            if (txtNamaBarang.Text.Trim() == "")
            {
                MessageBox.Show("Nama barang tidak boleh kosong.");
                return false;
            }

            if (cbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kategori barang.");
                return false;
            }

            if (ambilKondisi() == "")
            {
                MessageBox.Show("Pilih kondisi barang.");
                return false;
            }

            if (fotoPath == "")
            {
                MessageBox.Show("Pilih foto barang.");
                return false;
            }
            return true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;
            SimpanBarang();
        }

        private void SimpanBarang()
        {
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    NpgsqlTransaction transaction = conn.BeginTransaction();

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

                    cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text);
                    cmd.Parameters.AddWithValue("@kondisi", ambilKondisi());
                    cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                    cmd.Parameters.AddWithValue("@status", "Menunggu Verifikasi");
                    cmd.Parameters.AddWithValue("@id_donatur", donatur.id);
                    cmd.Parameters.AddWithValue("@id_kategori", Convert.ToInt32(cbKategori.SelectedValue));

                    int idBarang = Convert.ToInt32(cmd.ExecuteScalar());


                    //nambah foto
                    byte[] fotoBytes = File.ReadAllBytes(fotoPath);
                    string queryfoto_barang = "INSERT INTO foto_barang (id_barang, foto_barang) VALUES (@id_barang, @foto_barang)";

                    cmd = new NpgsqlCommand(queryfoto_barang, conn);
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@id_barang", idBarang);
                    cmd.Parameters.AddWithValue("@foto_barang", fotoBytes);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Barang berhasil diupload!");

                    FrmDonatur frmDonatur = new FrmDonatur(donatur);
                    frmDonatur.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan barang: " + ex.Message);
            }
        }
        private void btnKembaliKeHome_Click(object sender, EventArgs e)
        {
            FrmDonatur frmDonatur = new FrmDonatur(donatur);
            frmDonatur.Show();
            this.Close();
        }

        private void txtNamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
