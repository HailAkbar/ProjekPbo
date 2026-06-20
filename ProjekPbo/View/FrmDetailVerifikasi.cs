using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Models;
using Npgsql;
using ProjekPbo.Database;
using ProjekPbo.View;
using System.Runtime.Intrinsics.Arm;
using ProjekPbo.Controllers;

namespace ProjekPbo.View
{
    public partial class FrmDetailVerifikasi : Form
    {
        private int idBarang;
        private Pengelola pengelola;
        private C_DetailVerifikasiPengelola controller;
        public FrmDetailVerifikasi(int barangId, Pengelola p)
        {
            InitializeComponent();
            idBarang = barangId;
            pengelola = p;
            controller = new C_DetailVerifikasiPengelola();
        }

        private void FrmVerivikasi_Load(object sender, EventArgs e)
        {
            TampilkanBarangnya();
        }

        private void TampilkanBarangnya()
        {
            try
            {
                DataTable dt = controller.DetailBarang(idBarang);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    lblNamaBarang.Text = dr["nama_barang"].ToString();
                    lblNamaDonatur.Text = dr["donatur"].ToString();
                    lblKategori.Text = dr["nama_kategori"].ToString();
                    lblKondisi.Text = dr["kondisi"].ToString();
                    lblTanggal.Text = Convert.ToDateTime(dr["tanggal_upload"]).ToString("dd/MM/yyyy");
                    rtbDeskripsi.Text = dr["deskripsi"].ToString();

                    if (dr["foto_barang"] != DBNull.Value)
                    {
                        byte[] fotoBytes = (byte[])dr["foto_barang"];
                        using (var ms = new System.IO.MemoryStream(fotoBytes))
                        {
                            picBarang.Image = Image.FromStream(ms);
                            picBarang.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data barang: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpanVerif("Diterima");
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimpanVerif("Ditolak");
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.ShowDialog();
            this.Hide();
        }

        private void SimpanVerif(string status)
        {
            bool berhasil = controller.NyimpenVerif(idBarang, pengelola, txtCatatan.Text.Trim(), status);
            if (berhasil)
            {
                MessageBox.Show("Verifikasi Berhasil");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal Menyimpan Data Verifikasi");
                this.Hide();
            }
        }

        private void btnKeVerifikasi_Click(object sender, EventArgs e)
        {
            FrmDaftarBarangPengelola frm = new FrmDaftarBarangPengelola(pengelola);
            frm.Show();
            this.Hide();
        }

        private void btnKeKelola_Click(object sender, EventArgs e)
        {
            FrmKelolaKategori frm = new FrmKelolaKategori(pengelola);
            frm.Show();
            this.Hide();
        }

        private void btnKeStatistik_Click(object sender, EventArgs e)
        {
            FrmStatistikPengelola frm = new FrmStatistikPengelola(pengelola);
            frm.Show();
            this.Hide();
        }

        private void btnKeProfil_Click(object sender, EventArgs e)
        {
            FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
            frm.Show();
            this.Hide();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void btnKeHome_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.Show();
            this.Hide();
        }
    }
}
