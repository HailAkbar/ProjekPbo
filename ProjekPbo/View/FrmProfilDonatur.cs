using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekPbo.View
{
    public partial class FrmProfilDonatur : Form
    {
        private Donatur donatur;
        public FrmProfilDonatur(Donatur d)
        {
            InitializeComponent();
            donatur = d;
        }

        private void FrmProfilDonatur_Load(object sender, EventArgs e)
        {
            lblNama.ForeColor = ColorTranslator.FromHtml("#8E8E93");

            lblNama.Text = donatur.nama.ToString();
            lblEmail.Text = donatur.email.ToString();
            lblNoHP.Text = donatur.nomorHp.ToString();
            lblAlamat.Text = donatur.Alamat.ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Yakin Mau Logout? ", "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmRiwayatDonasi frm = new FrmRiwayatDonasi(donatur);
            frm.Show();
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
            FrmUploadBarang frm = new FrmUploadBarang(donatur);
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
