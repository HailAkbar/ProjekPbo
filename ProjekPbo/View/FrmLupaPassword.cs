using ProjekPbo.Database;
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
    public partial class FrmLupaPassword : Form
    {
        private C_LupaPasswordDonatur controller;
        public FrmLupaPassword()
        {
            InitializeComponent();
            controller = new C_LupaPasswordDonatur();
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!Validasi())
                return;

            ResetPassword();
        }

        private bool Validasi()
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email Wajib Diisi");
                return false;
            }

            if (txtPasswordBaru.Text.Trim() == "")
            {
                MessageBox.Show("Password Barunya Harus Diisi");
                return false;
            }

            if (txtKonfirmasi.Text.Trim() == "")
            {
                MessageBox.Show("Konfirmasi Password Harus Diisi");
                return false;
            }

            if (txtPasswordBaru.Text != txtPasswordBaru.Text.Trim())
            {
                MessageBox.Show("Konfirmasi Password Tidak Sama");
                return false;
            }
            return true;
        }

        private void ResetPassword()
        {
            try
            {
                bool berhasil = controller.LupaPassword(txtEmail.Text.Trim(), txtPasswordBaru.Text);
                if (!berhasil)
                {
                    MessageBox.Show("Email Tidak Ditemukan!");
                }

                MessageBox.Show("Password Berhasil Diubah!");
                FrmLogin frm = new FrmLogin();
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
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }
    }
}
