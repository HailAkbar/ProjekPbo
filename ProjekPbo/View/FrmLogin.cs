using Npgsql;
using ProjekPbo.Models;
using ProjekPbo.Database;
using ProjekPbo.View;

namespace ProjekPbo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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
                using (var conn = Database.Koneksi.GetConnection())
                {
                    conn.Open();

                    //login donatur
                    string queryDonatur = "SELECT * FROM donatur WHERE email = @Email AND sandi = @Sandi";
                    NpgsqlCommand cmd = new NpgsqlCommand(queryDonatur, conn);
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Sandi", txtPassword.Text);

                        NpgsqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Donatur donatur = new Donatur();
                            donatur.id = Convert.ToInt32(dr["id_donatur"]);

                            donatur.nama = dr["nama"].ToString();
                            donatur.email = dr["email"].ToString();
                            donatur.sandi = dr["sandi"].ToString();
                            donatur.nomorHp = dr["nomor_hp"].ToString();
                            donatur.Alamat = dr["alamat"].ToString();

                            dr.Close();
                            MessageBox.Show("Login berhasil! Selamat datang, " + donatur.GetRole());

                            FrmDonatur frm = new FrmDonatur(donatur);
                            frm.Show();
                            this.Hide();
                            return;
                        }

                        dr.Close();

                        //login pengelola

                        string queryPengelola = "SELECT * FROM pengelola WHERE email = @Email AND sandi = @Sandi";
                        cmd = new NpgsqlCommand(queryPengelola, conn);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Sandi", txtPassword.Text);

                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Pengelola pengelola = new Pengelola();
                            pengelola.id = Convert.ToInt32(dr["id_pengelola"]);
                            pengelola.nama = dr["nama"].ToString();
                            pengelola.email = dr["email"].ToString();
                            pengelola.sandi = dr["sandi"].ToString();
                            pengelola.nomorHp = dr["nomor_hp"].ToString();

                            dr.Close();
                            MessageBox.Show("Login berhasil! Selamat datang, " + pengelola.GetRole());

                            //FrmDashboardPengelola frm = new FrmDashboardPengelola(pengelola);
                            //frm.Show();
                            //this.Hide();
                            return;
                        }
                        dr.Close();

                        MessageBox.Show("Login gagal! Pastikan email dan password benar.");
                    }
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
        }
    }
}
