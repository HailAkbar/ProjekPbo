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

namespace ProjekPbo.View
{
    public partial class FrmGantiPassword : Form
    {
        private Pengelola pengelola;
        public FrmGantiPassword(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
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
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string cekPassword = @"SELECT * FROM pengelola WHERE id_pengelola = @id AND sandi = @sandi";

                    NpgsqlCommand cmd = new NpgsqlCommand(cekPassword, conn);
                    cmd.Parameters.AddWithValue("@id", pengelola.id);
                    cmd.Parameters.AddWithValue("@sandi", txtPasswordLama.Text);
                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    if (!dr.Read())
                    {
                        dr.Close();

                        MessageBox.Show("Password lama salah!");
                        return;
                    }

                    dr.Close();

                    string updatePassword = @"UPDATE pengelola SET sandi = @sandibaru WHERE id_pengelola = @id";

                    cmd = new NpgsqlCommand(updatePassword, conn);
                    cmd.Parameters.AddWithValue("@sandibaru", txtPasswordBaru.Text);
                    cmd.Parameters.AddWithValue("@id", pengelola.id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password Berhasil diubah!");

                    FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
                    frm.Show();
                    this.Close();
                }
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

        private void FrmGantiPassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordBaru_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
