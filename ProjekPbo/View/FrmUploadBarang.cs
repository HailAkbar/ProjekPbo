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
using ProjekPbo.Controllers;
using System.Drawing.Drawing2D;

namespace ProjekPbo.View
{
    public partial class FrmUploadBarang : Form
    {
        private Donatur donatur;
        private string fotoPath = "";
        private C_UploadBarangDonatur controller;
        public FrmUploadBarang(Donatur d)
        {
            InitializeComponent();
            donatur = d;
            controller = new C_UploadBarangDonatur();

            btnSimpan.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Text = "Masuk";

            btnSimpan.MouseEnter += (s, e) => {
                btnSimpan.BackColor = ColorTranslator.FromHtml("#199255");
            };

            btnSimpan.MouseLeave += (s, e) => {
                btnSimpan.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            };
        }

        private void FrmUploadBarang_Load(object sender, EventArgs e)
        {
            AmbilKategorinya();

            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.FlatAppearance.BorderSize = 0;

            btnSimpan.Paint += (s, e) =>
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnSimpan.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnSimpan.Width - radius, btnSimpan.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnSimpan.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btnSimpan.Region = new Region(path);
            };
        }

        private void AmbilKategorinya()
        {
            try
            {
                DataTable dt = controller.AmbilKategori();
                cbKategori.DisplayMember = "nama_kategori";
                cbKategori.ValueMember = "id_kategori";
                cbKategori.DataSource = dt;
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
                return "Sedikit Rusak";
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
                controller.SimpanBarang(txtNamaBarang.Text.Trim(), ambilKondisi(), txtDeskripsi.Text.Trim(), donatur.id, Convert.ToInt32(cbKategori.SelectedValue), fotoPath);
                MessageBox.Show("Barang berhasil diupload!");
                FrmRiwayatDonasi frm = new FrmRiwayatDonasi(donatur);
                frm.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan barang: " + ex.Message);
            }
        }
        private void btnKembaliKeHome_Click(object sender, EventArgs e)
        {
            FrmUploadBarang frm = new FrmUploadBarang(donatur);
            frm.ShowDialog();
            this.Hide();
        }

        private void btnKeProfil_Click(object sender, EventArgs e)
        {
            FrmProfilDonatur frm = new FrmProfilDonatur(donatur);
            frm.ShowDialog();
            this.Hide();
        }

        private void btnKeUpload_Click(object sender, EventArgs e)
        {
            FrmUploadBarang frm = new FrmUploadBarang(donatur);
            frm.ShowDialog();
            this.Hide();
        }

        private void btnKeRiwayat_Click(object sender, EventArgs e)
        {
            FrmRiwayatDonasi frm = new FrmRiwayatDonasi(donatur);
            frm.ShowDialog();
            this.Hide();
        }
    }
}
