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
        }

        private void FrmUploadBarang_Load(object sender, EventArgs e)
        {
            AmbilKategori();
        }

        private void AmbilKategori()
        {
            try
            {
                DataTable dt = new DataTable();
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
                FrmDonatur frmDonatur = new FrmDonatur(donatur);
                frmDonatur.Show();
                this.Close();
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

        private void btnKeProfil_Click(object sender, EventArgs e)
        {
            FrmProfilDonatur frm = new FrmProfilDonatur(donatur);
            frm.ShowDialog();
            this.Close();
        }

        private void btnKeberanda_Click(object sender, EventArgs e)
        {
            FrmDonatur frm = new FrmDonatur(donatur);
            frm.ShowDialog();
            this.Close();
        }

        private void btnKeUpload_Click(object sender, EventArgs e)
        {
            FrmUploadBarang frm = new FrmUploadBarang(donatur);
            frm.ShowDialog();
            this.Close();
        }

        private void btnKeRiwayat_Click(object sender, EventArgs e)
        {
            FrmRiwayatDonasi frm = new FrmRiwayatDonasi(donatur);
            frm.ShowDialog();
            this.Close();
        }
    }
}
