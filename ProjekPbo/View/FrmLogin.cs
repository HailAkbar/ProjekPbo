using Npgsql;
using ProjekPbo.Models;
using ProjekPbo.Database;
using ProjekPbo.View;
using ProjekPbo.Controllers;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace ProjekPbo
{
    public partial class FrmLogin : Form
    {
        private C_Login controller;
        public FrmLogin()
        {
            InitializeComponent();
            controller = new C_Login();

            btnLogin.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            btnLogin.ForeColor = Color.White;
            btnLogin.Text = "Masuk";

            btnLogin.MouseEnter += (s, e) =>
            {
                btnLogin.BackColor = ColorTranslator.FromHtml("#199255");
            };

            btnLogin.MouseLeave += (s, e) =>
            {
                btnLogin.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            };

            lblDaftar.MouseEnter += (s, e) =>
            {
                lblDaftar.LinkColor = ColorTranslator.FromHtml("#199255");
            };

            lblDaftar.MouseLeave += (s, e) =>
            {
                lblDaftar.LinkColor = ColorTranslator.FromHtml("#8E8E8E");
            };

            lblLupaPassword.MouseEnter += (s, e) =>
            {
                lblLupaPassword.LinkColor = ColorTranslator.FromHtml("#199255");
            };

            lblLupaPassword.MouseLeave += (s, e) =>
            {
                lblLupaPassword.LinkColor = ColorTranslator.FromHtml("#8E8E8E");
            };
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
                    this.Close();
                }

                else if (user is Pengelola pengelola)
                {
                    MessageBox.Show("Login Berhasil! Selamat Datang, " + pengelola.GetRole());
                    FrmPengelola frm = new FrmPengelola(pengelola);
                    frm.ShowDialog();
                    this.Close();
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
            this.Close();
            return;
        }

        private void lblLupaPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLupaPassword frm = new FrmLupaPassword();
            frm.Show();
            this.Close();
            return;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            btnLogin.Paint += (s, e) =>
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnLogin.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnLogin.Width - radius, btnLogin.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnLogin.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                btnLogin.Region = new Region(path);
            };
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
