using ProjekPbo.Database;
using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using ProjekPbo.Controllers;

namespace ProjekPbo.View
{
    public partial class FrmGantiPassword : Form
    {
        private Pengelola pengelola;
        private C_GantiPasswordPengelola controller;
        public FrmGantiPassword(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
            controller = new C_GantiPasswordPengelola();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!Validasi())
                return;

            GantiPassword();
        }

        private bool Validasi()
        {
            if (txtPasswordLama.Text.Trim() == "")
            {
                MessageBox.Show("Password lama harus diisi");
                return false;
            }

            if (txtPasswordBaru.Text.Trim() == "")
            {
                MessageBox.Show("Password baru tidak boleh kosong");
                return false;
            }

            if (txtKonfirmasi.Text.Trim() == "")
            {
                MessageBox.Show("Konfirmasi Password harus diisi");
                return false;
            }

            if (txtKonfirmasi.Text != txtPasswordBaru.Text)
            {
                MessageBox.Show("Konfirmasi Password harus sama");
                return false;
            }

            return true;
        }

        private void GantiPassword()
        {
            try
            {
                bool berhasil = controller.gantiPassword(pengelola, txtPasswordLama.Text, txtPasswordBaru.Text);
                if (!berhasil)
                {
                    MessageBox.Show("Password Lama Salah!");
                    return;
                }

                MessageBox.Show("Password Berhasil Diubah!");

                FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
                frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
            frm.Show();
            this.Close();
        }
    }
}
