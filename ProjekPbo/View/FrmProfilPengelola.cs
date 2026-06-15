using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Models;
using Npgsql;
using System.Windows.Forms.VisualStyles;

namespace ProjekPbo.View
{
    public partial class FrmProfilPengelola : Form
    {
        private Pengelola pengelola;
        public FrmProfilPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
        }

        private void FrmProfilPengelola_Load(object sender, EventArgs e)
        {
            lblNamaAtas.Text = pengelola.nama.ToString();
            lblNama.Text = pengelola.nama.ToString();
            lblEmail.Text = pengelola.email.ToString();
            lblNoHp.Text = pengelola.nomorHp.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            FrmGantiPassword frm = new FrmGantiPassword(pengelola);
            frm.ShowDialog();
            this.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.ShowDialog();
            this.Close();
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
    }
}
