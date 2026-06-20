using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.View;
using ProjekPbo.Controllers;
using System.Drawing.Drawing2D;

namespace ProjekPbo.View
{
    public partial class FrmRegister : Form
    {
        private C_Register controller;
        public FrmRegister()
        {
            InitializeComponent();
            controller = new C_Register();

            btnDaftar.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            btnDaftar.ForeColor = Color.White;
            btnDaftar.Text = "Register";

            btnDaftar.MouseEnter += (s, e) =>
            {
                btnDaftar.BackColor = ColorTranslator.FromHtml("#199255");
            };

            btnDaftar.MouseLeave += (s, e) =>
            {
                btnDaftar.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            };

            lblLogin.MouseEnter += (s, e) =>
            {
                lblLogin.LinkColor = ColorTranslator.FromHtml("#199255");
            };

            lblLogin.MouseLeave += (s, e) =>
            {
                lblLogin.LinkColor = ColorTranslator.FromHtml("#8E8E8E");
            };
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            SimpanDonatur();
        }

        private bool ValidasiInput()
        {
            if (txtNama.Text.Trim() == "") //trim buat menghapus spasi dan constains gak harus urut
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }
            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Format email tidak sesuai");
                return false;
            }
            if (txtSandi.Text.Trim() == "")
            {
                MessageBox.Show("Password tidak boleh kosong");
                return false;
            }
            if (txtNoHP.Text.Trim() == "")
            {
                MessageBox.Show("Nomor HP tidak boleh kosong");
                return false;
            }
            if (!long.TryParse(txtNoHP.Text, out _)) //ngecek apakah dia isinya hanya angka atau tidak, kalo selain angka bakal gagal
            {
                MessageBox.Show("Format nomor hp harus angka");
                return false;
            }
            if (txtNoHP.Text.Trim().Length > 12) //ngecek kalo nomor hp harus dibawah 12 digit
            {
                MessageBox.Show("Nomor Hp harus dibawah 12 angka");
                return false;
            }
            if (txtAlamat.Text.Trim() == "")
            {
                MessageBox.Show("Alamat tidak boleh kosong");
                return false;
            }
            if (txtSandi.Text != txtKonfirmasi.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak cocok");
                return false;
            }
            return true;
        }

        private void SimpanDonatur()
        {
            try
            {
                if (controller.cekemail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email sudah terdaftar, silakan gunakan email lain.");
                    txtEmail.Clear();
                    txtEmail.Focus();
                    return;
                }

                Donatur donatur = new Donatur()
                {
                    nama = txtNama.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    sandi = txtSandi.Text.Trim(),
                    nomorHp = txtNoHP.Text.Trim(),
                    Alamat = txtAlamat.Text.Trim()
                };

                controller.register(donatur);
                MessageBox.Show("Register Berhasil!");
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            txtNoHP.MaxLength = 12;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.FlatAppearance.BorderSize = 0;

            btnDaftar.Paint += (s, e) =>
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnDaftar.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnDaftar.Width - radius, btnDaftar.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnDaftar.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                btnDaftar.Region = new Region(path);
            };
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frmLogi = new FrmLogin();
            frmLogi.ShowDialog();
            this.Hide();
        }
    }
}
