using ProjekPbo.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Net.Http.Headers;
using ProjekPbo.Models;

namespace ProjekPbo.View
{
    public partial class FrmKelolaKategori : Form
    {
        private int idKategori = 0;
        private Pengelola pengelola;
        public FrmKelolaKategori(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
        }

        private void FrmKelolaKategori_Load(object sender, EventArgs e)
        {
            TampilinKategori();
        }

        private void TampilinKategori()
        {
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT id_kategori, nama_kategori " +
                         "FROM kategori " +
                         "ORDER BY id_kategori";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKategori.DataSource = dt;
                    dgvKategori.Columns[0].HeaderText = "ID";
                    dgvKategori.Columns[1].HeaderText = "Nama Kategori";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idKategori = Convert.ToInt32(dgvKategori.Rows[e.RowIndex].Cells[0].Value);
                txtKategori.Text = dgvKategori.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtKategori.Text.Trim() == "")
            {
                MessageBox.Show("Kategori Tidak Boleh Kosong");
                return;
            }
            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO kategori (nama_kategori) VALUES (@nama)";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtKategori.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori Baru Berhasil Ditambahkan!");
                    txtKategori.Clear();
                    TampilinKategori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idKategori == 0)
            {
                MessageBox.Show("Pilih kategorinya dulu");
                return;
            }

            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"UPDATE kategori " +
                         "SET nama_kategori = @nama " +
                         "WHERE id_kategori = @id ";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nama", txtKategori.Text);
                    cmd.Parameters.AddWithValue("@id", idKategori);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kategori berhasil diubah");
                    txtKategori.Clear();
                    idKategori = 0;
                    TampilinKategori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idKategori == 0)
            {
                MessageBox.Show("Pilih kategori terlebih dahulu");
                return;
            }

            DialogResult hasil = MessageBox.Show("Yakin ingin menghapus kategori ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (hasil == DialogResult.No)
                return;

            try
            {
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"DELETE FROM kategori " +
                         "WHERE id_kategori=@id";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", idKategori);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kategori berhasil dihapus");
                    txtKategori.Clear();
                    idKategori = 0;

                    TampilinKategori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKategori.Clear();
            idKategori = 0;
            TampilinKategori();
        }
    }
}
