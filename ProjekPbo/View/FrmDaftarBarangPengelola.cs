using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Models;
using ProjekPbo.Controllers;
using System.Drawing.Drawing2D;

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

            ModernCard card = new ModernCard();
            card.Width = 360;
            card.Height = 150;
            card.Margin = new Padding(10);
            card.BackColor = Color.White;
            card.Padding = new Padding(10);

            Label lblNama = new Label();
            lblNama.Text = row["nama_barang"].ToString();
            lblNama.Font = new Font("Inter", 12, FontStyle.Bold);
            lblNama.Location = new Point(85, 10);
            lblNama.AutoSize = true;

            Label lblDonatur = new Label();
            lblDonatur.Text = "Donatur : " + row["nama"].ToString();
            lblDonatur.Font = new Font("Inter", 9, FontStyle.Regular);
            lblDonatur.Location = new Point(85, 40);
            lblDonatur.AutoSize = true;

            Label lblKategori = new Label();
            lblKategori.Text = "Kategori : " + row["nama_kategori"].ToString();
            lblKategori.Font = new Font("Inter", 9, FontStyle.Regular);
            lblKategori.Location = new Point(85, 65);
            lblKategori.AutoSize = true;

            Label lblTanggal = new Label();
            lblTanggal.Text = Convert.ToDateTime(row["tanggal_upload"]).ToString("dd-MM-yyyy");
            lblTanggal.Font = new Font("Inter", 9, FontStyle.Regular);
            lblTanggal.Location = new Point(10, 120);
            lblTanggal.AutoSize = true;

            PictureBox picBarang = new PictureBox();
            picBarang.Width = 70;
            picBarang.Height = 80;
            picBarang.Location = new Point(10, 10);
            picBarang.SizeMode = PictureBoxSizeMode.Zoom;
            picBarang.BorderStyle = BorderStyle.FixedSingle;
            if (row["foto_barang"] != DBNull.Value)
            {
                byte[] fotoBytes = (byte[])row["foto_barang"];
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    picBarang.Image = Image.FromStream(ms);
                }
            }

            Button btnDetail = new Button();
            btnDetail.Text = "Verifikasi";
            btnDetail.Width = 100;
            btnDetail.Height = 35;
            btnDetail.Location = new Point(250, 103);
            btnDetail.FlatStyle = FlatStyle.Flat;
            btnDetail.FlatAppearance.BorderSize = 0;
            btnDetail.BackColor = ColorTranslator.FromHtml("#199255");
            btnDetail.ForeColor = Color.White;
            btnDetail.MouseEnter += (s, e) =>
            {
                btnDetail.BackColor = Color.DarkGreen;
            };

            btnDetail.MouseLeave += (s, e) =>
            {
                btnDetail.BackColor = ColorTranslator.FromHtml("#199255");
            };

            btnDetail.Click += (s, e) =>
            {
                FrmDetailVerifikasi frm = new FrmDetailVerifikasi(idBarang, pengelola);
                frm.ShowDialog();
                TampilkanBarang();
                this.Hide();
            };

            card.Controls.Add(lblNama);
            card.Controls.Add(lblDonatur);
            card.Controls.Add(lblKategori);
            card.Controls.Add(lblTanggal);
            card.Controls.Add(picBarang);
            card.Controls.Add(btnDetail);

            flpBarang.Controls.Add(card);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
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

        private void flpBarang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKeBeranda_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.Show();
            this.Close();
        }
    }
}
