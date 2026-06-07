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
            lblNama.Text = "Nama Anda: " + pengelola.nama.ToString();
            lblEmail.Text = "Email: " + pengelola.email.ToString();
            lblNoHp.Text = "Nomor HP: " + pengelola.nomorHp.ToString();
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
    }
}
