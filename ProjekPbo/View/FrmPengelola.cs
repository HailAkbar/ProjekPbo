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
            lblMenunggu.Text = "Menunggu: " + HitungStatusnya("Menunggu Verifikasi").ToString();
            lblDiterima.Text = "Diterima: " + HitungStatusnya("Diterima").ToString();
            lblDitolak.Text = "Ditolak: " + HitungStatusnya("Ditolak").ToString();
            lblSelesai.Text = "Selesai: " + HitungStatusnya("Selesai").ToString();
        }

        private void btnKelola_Click(object sender, EventArgs e)
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
    }
}
