using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using ProjekPbo.View;
using ProjekPbo.Database;

namespace ProjekPbo.View
{
    public partial class FrmPengelola : Form
    {
        private Pengelola pengelola;
        public FrmPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
        }

        private void FrmPengelola_Load(object sender, EventArgs e)
        {
            lblNama.Text = pengelola.nama;

            TampilkanBarangnya();
        }

        private int HitungStatusnya(string status)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM barang WHERE status = @status";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void TampilkanBarangnya()
        {
            lblMenunggu.Text = HitungStatusnya("Menunggu Verifikasi").ToString();
            lblDiterima.Text = HitungStatusnya("Diterima").ToString();
            lblDitolak.Text = HitungStatusnya("Ditolak").ToString();
        }

        private void btnVerifikasi_Click(object sender, EventArgs e)
        {
            FrmDaftarBarangPengelola frm = new FrmDaftarBarangPengelola(pengelola);
            frm.ShowDialog();
            this.Close();
            TampilkanBarangnya();
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            FrmStatistikPengelola frm = new FrmStatistikPengelola(pengelola);
            frm.ShowDialog();
            this.Hide();
            return;
        }

        private void btnkelola_Click(object sender, EventArgs e)
        {
            FrmKelolaKategori frm = new FrmKelolaKategori(pengelola);
            frm.Show();
            this.Hide();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
            frm.Show();
            this.Hide(); 
            return;
        }

        private void btnKeVerifikasi_Click(object sender, EventArgs e)
        {
            FrmDaftarBarangPengelola frm = new FrmDaftarBarangPengelola(pengelola);
            frm.Show();
            this.Close();
        }

        private void btnKeKelola_Click(object sender, EventArgs e)
        {
            FrmKelolaKategori frm = new FrmKelolaKategori(pengelola);
            frm.Show();
            this.Close();
        }

        private void btnKeStatistik_Click(object sender, EventArgs e)
        {
            FrmStatistikPengelola frm = new FrmStatistikPengelola(pengelola);
            frm.Show();
            this.Close();
        }

        private void btnKeProfil_Click(object sender, EventArgs e)
        {
            FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
            frm.Show();
            this.Close();
        }
    }
}
