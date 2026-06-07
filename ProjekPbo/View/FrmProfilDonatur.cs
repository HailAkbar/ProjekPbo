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
            lblNamaAtas.Text = "Nama Anda: " + donatur.nama.ToString();
            lblNama.Text = "Nama Anda: " + donatur.nama.ToString();
            lblEmail.Text = "Email: " + donatur.email.ToString();
            lblNoHP.Text = "Nomor HP: " + donatur.nomorHp.ToString();
            lblAlamat.Text = "Alamat: " + donatur.Alamat.ToString();

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
            FrmDonatur frm = new FrmDonatur(donatur);
            frm.Show();
            this.Close();
        }
    }
}
