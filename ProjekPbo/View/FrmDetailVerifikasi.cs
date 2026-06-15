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
                    lblNamaBarang.Text = "Nama Barang: " + dr["nama_barang"].ToString();
                    lblNamaDonatur.Text = "Nama Donatur: " + dr["donatur"].ToString();
                    lblKategori.Text = "Kategori: " + dr["nama_kategori"].ToString();
                    lblKondisi.Text = "kondisi: " + dr["kondisi"].ToString();
                    lblTanggal.Text = "Tanggal Upload: " + Convert.ToDateTime(dr["tanggal_upload"]).ToString("dd/MM/yyyy");
                    rtbDeskripsi.Text = "Deskripsi: " + dr["deskripsi"].ToString();

                    if (dr["foto_barang"] != DBNull.Value)
                    {
                        byte[] fotoBytes = (byte[])dr["foto_barang"];
                        using (var ms = new System.IO.MemoryStream(fotoBytes))
                        {
                            picBarang.Image = Image.FromStream(ms);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimpanVerif("Ditolak");
        }

        private void SimpanVerif(string status)
        {
            bool berhasil = controller.NyimpenVerif(idBarang, pengelola, txtCatatan.Text.Trim(), status);
            if (berhasil)
            {
                MessageBox.Show("Verifikasi Berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal Menyimpan Data Verifikasi");
            }
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
