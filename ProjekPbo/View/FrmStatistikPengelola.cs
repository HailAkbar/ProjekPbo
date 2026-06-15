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
using ProjekPbo.Controllers;

namespace ProjekPbo.View
{
    public partial class FrmStatistikPengelola : Form
    {
        private Pengelola pengelola;
        private C_StatistikPengelola controller;
        public FrmStatistikPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
            controller = new C_StatistikPengelola();
        }

        private void FrmStatistikPengelola_Load(object sender, EventArgs e)
        {
            MunculinStatus();
            MunculinKategori();
        }

        private void MunculinStatus()
        {
            flpStatus.Controls.Clear();

            MunculinStatusnya("Menunggu", controller.HitungJumlah("Menunggu Verifikasi"));
            MunculinStatusnya("Diterima", controller.HitungJumlah("Diterima"));
            MunculinStatusnya("Ditolak", controller.HitungJumlah("Ditolak"));
            MunculinStatusnya("Total", controller.HitungTotal());
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
                DataTable dt = controller.StatistikKategori();
                foreach (DataRow dr in dt.Rows)
                {
                    MunculinKategorinya(dr["nama_kategori"].ToString(), Convert.ToInt32(dr["jumlah"]));
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
