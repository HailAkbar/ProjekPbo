using Npgsql;
using ProjekPbo.Models;
using ProjekPbo.Database;
using ProjekPbo.View;
using ProjekPbo.Controllers;

namespace ProjekPbo
{
    public partial class FrmLogin : Form
    {
        private C_Login controller;
        public FrmLogin()
        {
            InitializeComponent();
            controller = new C_Login();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email tidak boleh kosong");
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password tidak boleh kosong");
                return;
            }
            LoginUser();
        }

        private void LoginUser()
        {
            try
            {
                object user = controller.LoginUser(txtEmail.Text.Trim(), txtPassword.Text.Trim());

                if (user is Donatur donatur)
                {
                    MessageBox.Show("Login Berhasil! Selamat Datang, " + donatur.GetRole());
                    FrmUploadBarang frm = new FrmUploadBarang(donatur);
                    frm.ShowDialog();
                    this.Hide();
                }

                else if (user is Pengelola pengelola)
                {
                    MessageBox.Show("Login Berhasil! Selamat Datang, " + pengelola.GetRole());
                    FrmPengelola frm = new FrmPengelola(pengelola);
                    frm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login gagal! Pastikan Email dan Password Benar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
        private void lblDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.Show();
            this.Hide();
            return;
        }

        private void lblLupaPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLupaPassword frm = new FrmLupaPassword();
            frm.Show();
            this.Hide();
            return;
        }
    }
}
