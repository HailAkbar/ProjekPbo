using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using ProjekPbo.View;
using ProjekPbo.Database;
using ProjekPbo.Controllers;

namespace ProjekPbo.View
{
    public partial class FrmPengelola : Form
    {
        private Pengelola pengelola;
        private C_Pengelola controller;
        public FrmPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
            controller = new C_Pengelola();
        }

        private void FrmPengelola_Load(object sender, EventArgs e)
        {
            lblMenunggu.BackColor = ColorTranslator.FromHtml("#FFE9C7");
            lblDiterima.BackColor = ColorTranslator.FromHtml("#C9E4FF");
            lblDitolak.BackColor = ColorTranslator.FromHtml("#FFB3B3");
            lblNama.Text = pengelola.nama;

            TampilkanBarangnya();
        }

        private void TampilkanBarangnya()
        {
            try
            {
                lblMenunggu.Text = controller.HitungStatusnyaa("Menunggu Verifikasi").ToString();
                lblDiterima.Text = controller.HitungStatusnyaa("Diterima").ToString();
                lblDitolak.Text = controller.HitungStatusnyaa("Ditolak").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerifikasi_Click(object sender, EventArgs e)
        {
            FrmDaftarBarangPengelola frm = new FrmDaftarBarangPengelola(pengelola);
            frm.ShowDialog();
            this.Close();
            TampilkanBarangnya();
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            FrmStatistikPengelola frm = new FrmStatistikPengelola(pengelola);
            frm.ShowDialog();
            this.Close();
            return;
        }

        private void btnkelola_Click(object sender, EventArgs e)
        {
            FrmKelolaKategori frm = new FrmKelolaKategori(pengelola);
            frm.Show();
            this.Close();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
            frm.Show();
            this.Close(); 
            return;
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

        private void btnkeBeranda_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.Show();
            this.Close();
        }
    }
}
