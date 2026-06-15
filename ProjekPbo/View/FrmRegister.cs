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

namespace ProjekPbo.View
{
    public partial class FrmRegister : Form
    {
        private C_Register controller;
        public FrmRegister()
        {
            InitializeComponent();
            controller = new C_Register();
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            txtNoHP.MaxLength = 12;
        }
    }
}
