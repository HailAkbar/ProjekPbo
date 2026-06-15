using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Models;
using ProjekPbo.Controllers;

namespace ProjekPbo.View
{
    public partial class FrmDaftarBarangPengelola : Form
    {
        private Pengelola pengelola;
        private C_DaftarBarangPengelola controler;
        public FrmDaftarBarangPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
            controler = new C_DaftarBarangPengelola();
        }

        private void FrmDaftarBarangPengelola_Load(object sender, EventArgs e)
        {
            TampilkanBarang();
        }

        private void TampilkanBarang()
        {
            try
            {
                flpBarang.Controls.Clear();
                DataTable dt = controler.Tampilkanbarangnya();
                foreach (DataRow row in dt.Rows)
                {
                    Cardnya(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Cardnya(DataRow row)
        {
            int idBarang = Convert.ToInt32(row["id_barang"]);
            Panel card = new Panel();

            card.Width = 320;
            card.Height = 130;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);


            Label lblNama = new Label();
            lblNama.Text = row["nama_barang"].ToString();
            lblNama.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNama.Location = new Point(10, 10);
            lblNama.AutoSize = true;

            Label lblDonatur = new Label();
            lblDonatur.Text = "Donatur : " + row["nama"].ToString();
            lblDonatur.Location = new Point(10, 40);
            lblDonatur.AutoSize = true;

            Label lblKategori = new Label();
            lblKategori.Text = "Kategori : " + row["nama_kategori"].ToString();
            lblKategori.Location = new Point(10, 65);
            lblKategori.AutoSize = true;

            Button btnDetail = new Button();
            btnDetail.Text = "Verifikasi";
            btnDetail.Width = 100;
            btnDetail.Height = 35;
            btnDetail.Location = new Point(210, 90);

            btnDetail.Click += (s, e) =>
            {
                FrmDetailVerifikasi frm = new FrmDetailVerifikasi(idBarang, pengelola);
                frm.ShowDialog();
                TampilkanBarang();
            };

            card.Controls.Add(lblNama);
            card.Controls.Add(lblDonatur);
            card.Controls.Add(lblKategori);
            card.Controls.Add(btnDetail);

            flpBarang.Controls.Add(card);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilkanBarang();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void CariBarang()
        {
            try
            {
                flpBarang.Controls.Clear();
                DataTable dt = controler.CariBarangnya(txtCari.Text);

                foreach (DataRow row in dt.Rows)
                {
                    Cardnya(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.Show();
            this.Close();
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
