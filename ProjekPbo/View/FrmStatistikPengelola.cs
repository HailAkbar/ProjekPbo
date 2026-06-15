using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Database;
using ProjekPbo.Models;
using Npgsql;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;

namespace ProjekPbo.View
{
    public partial class FrmStatistikPengelola : Form
    {
        private Pengelola pengelola;
        public FrmStatistikPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
        }

        private void FrmStatistikPengelola_Load(object sender, EventArgs e)
        {
            MunculinStatus();
            MunculinKategori();
        }

        private int NgitungJumlah(string status)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM barang WHERE status=@status";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int NgitungTotal()
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM barang";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void MunculinStatus()
        {
            flpStatus.Controls.Clear();

            MunculinStatusnya("Menunggu", NgitungJumlah("Menunggu Verifikasi"));
            MunculinStatusnya("Diterima", NgitungJumlah("Diterima"));
            MunculinStatusnya("Ditolak", NgitungJumlah("Ditolak"));
            MunculinStatusnya("Selesai", NgitungJumlah("Selesai"));
            MunculinStatusnya("Total", NgitungTotal());
        }

        private void MunculinStatusnya(string judul, int jumlah)
        {
            Panel pnl = new Panel();

            pnl.Width = 140;
            pnl.Height = 100;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Margin = new Padding(10);

            Label lblJudul = new Label();
            lblJudul.Text = judul;
            lblJudul.Font = new Font( "Segoe UI", 10, FontStyle.Bold);
            lblJudul.Width = 120;
            lblJudul.Height = 30;
            lblJudul.TextAlign = ContentAlignment.MiddleCenter;
            lblJudul.Location = new Point(10, 10);

            Label lblJumlah = new Label();
            lblJumlah.Text = jumlah.ToString();
            lblJumlah.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblJumlah.Width = 120;
            lblJumlah.Height = 40;
            lblJumlah.TextAlign = ContentAlignment.MiddleCenter;
            lblJumlah.Location = new Point(10, 45);

            pnl.Controls.Add(lblJudul);
            pnl.Controls.Add(lblJumlah);

            flpStatus.Controls.Add(pnl);

        }
        private void MunculinKategori()
        {
            try
            {
                flpKategori.Controls.Clear();

                using (NpgsqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT " +
                            "k.nama_kategori, " +
                            "COUNT(*) AS jumlah " +
                            "FROM barang b " +
                            "JOIN kategori k ON b.id_kategori = k.id_kategori " +
                            "GROUP BY k.nama_kategori " +
                            "ORDER BY k.nama_kategori DESC";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MunculinKategorinya(dr["nama_kategori"].ToString(), Convert.ToInt32(dr["jumlah"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MunculinKategorinya(string kategori, int jumlah)
        {
            Panel pnl = new Panel();

            pnl.Width = 140;
            pnl.Height = 100;

            pnl.BorderStyle = BorderStyle.FixedSingle;

            pnl.Margin = new Padding(10);

            Label lblKategori = new Label();
            lblKategori.Text = kategori;
            lblKategori.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblKategori.AutoSize = false;
            lblKategori.Width = 120;
            lblKategori.Height = 40;
            lblKategori.TextAlign = ContentAlignment.MiddleCenter;
            lblKategori.Location = new Point(10, 10);

            Label lblJumlah = new Label();
            lblJumlah.Text = jumlah + " Donasi";
            lblJumlah.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            lblJumlah.AutoSize = false;
            lblJumlah.Width = 120;
            lblJumlah.Height = 25;
            lblJumlah.TextAlign = ContentAlignment.MiddleCenter;
            lblJumlah.Location = new Point(10, 55);

            pnl.Controls.Add(lblKategori);
            pnl.Controls.Add(lblJumlah);

            flpKategori.Controls.Add(pnl);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MunculinStatus();
            MunculinKategori();
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
