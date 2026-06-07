using ProjekPbo.Database;
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
    public partial class FrmLupaPassword : Form
    {
        public FrmLupaPassword()
        {
            InitializeComponent();
        }

        private void FrmLupaPassword_Load(object sender, EventArgs e)
        {

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
                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string cekEmail = @"SELECT COUNT(*) FROM donatur WHERE email = @email";

                    NpgsqlCommand cmd = new NpgsqlCommand(cekEmail, conn);

                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    int jumlah = Convert.ToInt32(cmd.ExecuteScalar());

                    if (jumlah == 0)
                    {
                        MessageBox.Show("Email tidak Ditemukan!");
                        return;
                    }

                    string updatepassword = @"UPDATE donatur SET sandi = @sandi WHERE email = @email";

                    cmd = new NpgsqlCommand(updatepassword, conn);
                    cmd.Parameters.AddWithValue("@sandi", txtPasswordBaru.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password berhasil diubah!");

                    FrmLogin frm = new FrmLogin();
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
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }
    }
}
