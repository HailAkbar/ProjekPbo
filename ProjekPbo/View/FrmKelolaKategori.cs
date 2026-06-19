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
using ProjekPbo.Controllers;

namespace ProjekPbo.View
{
    public partial class FrmKelolaKategori : Form
    {
        private int idKategori = 0;
        private Pengelola pengelola;
        private C_KelolaKategoriPengelola controller;
        public FrmKelolaKategori(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
            controller = new C_KelolaKategoriPengelola();
        }

        private void FrmKelolaKategori_Load(object sender, EventArgs e)
        {
            TampilinKategori();
        }

        private void TampilinKategori()
        {
            try
            {
                DataTable dt = controller.ambilkategori();
                dgvKategori.DataSource = dt;
                dgvKategori.Columns[0].HeaderText = "ID";
                dgvKategori.Columns[1].HeaderText = "Nama Kategori";
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
                controller.TambahKategori(txtKategori.Text);
                MessageBox.Show("Kategori Baru Berhasil Ditambahkan!");
                txtKategori.Clear();
                TampilinKategori();
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
                controller.EditKategori(idKategori, txtKategori.Text);
                MessageBox.Show("Kategori berhasil diubah");
                txtKategori.Clear();
                idKategori = 0;
                TampilinKategori();
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
                controller.HapusKategori(idKategori);
                MessageBox.Show("Kategori berhasil dihapus");
                txtKategori.Clear();
                idKategori = 0;
                TampilinKategori();
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

        private void btnKeVerifikasi_Click(object sender, EventArgs e)
        {
            FrmDaftarBarangPengelola frm = new FrmDaftarBarangPengelola(pengelola);
            frm.Show();
            this.Close();
        }
        private void btnKeKelola_Click(object sender, EventArgs e)
        {
            FrmKelolaKategori frm = new FrmKelolaKategori(pengelola);
            frm.Show();
            this.Close();
        }

        private void btnKeStatistik_Click(object sender, EventArgs e)
        {
            FrmStatistikPengelola frm = new FrmStatistikPengelola(pengelola);
            frm.Show();
            this.Close();
        }

        private void btnKeProfil_Click(object sender, EventArgs e)
        {
            FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
            frm.Show();
            this.Close();
        }

        private void btnKeBeranda_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.Show();
            this.Close();
        }
    }
}
