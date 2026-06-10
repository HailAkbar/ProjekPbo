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

namespace ProjekPbo.View
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
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
            if ((txtNoHP.Text.Trim().Length > 12)) //ngecek kalo nomor hp harus dibawah 12 digit
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
                Donatur donatur = new Donatur();
                donatur.nama = txtNama.Text.Trim();
                donatur.email = txtEmail.Text.Trim();
                donatur.sandi = txtSandi.Text.Trim();
                donatur.nomorHp = txtNoHP.Text.Trim();
                donatur.Alamat = txtAlamat.Text.Trim();

                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO donatur " +
                        "( " +
                        "nama, " +
                        "email, " +
                        "sandi, " +
                        "nomor_hp, " +
                        "alamat" +
                        ")" +
                        "VALUES " +
                        "(@nama, " +
                        "@email, " +
                        "@sandi, " +
                        "@nomor_hp, " +
                        "@alamat)";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("nama", donatur.nama);
                    cmd.Parameters.AddWithValue("email", donatur.email);
                    cmd.Parameters.AddWithValue("sandi", donatur.sandi);
                    cmd.Parameters.AddWithValue("nomor_hp", donatur.nomorHp);
                    cmd.Parameters.AddWithValue("alamat", donatur.Alamat);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pendaftaran berhasil!");
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    this.Close();
                }
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
