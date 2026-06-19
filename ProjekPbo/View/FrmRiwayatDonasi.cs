using System.IO;
using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Controllers;
using System.Drawing.Drawing2D;

namespace ProjekPbo.View
{
    public partial class FrmRiwayatDonasi : Form
    {
        public Donatur donatur;
        private string filterStatus = "";
        private C_RiwayatDonasiDonatur controller;
        private Button tombolaktif = null;

        public FrmRiwayatDonasi(Donatur d)
        {
            InitializeComponent();
            donatur = d;
            controller = new C_RiwayatDonasiDonatur();
        }

        private void TampilinRiwayatDonasi()
        {
            try
            {
                flpRiwayat.Controls.Clear();
                DataTable dt = controller.ambilRiwayat(donatur.id, filterStatus);
                if(dt.Rows.Count == 0)
                {
                    Label lblKosong = new Label();
                    lblKosong.Text = "Belum ada riwayat donasi.";
                    lblKosong.Font = new Font("Segoe UI", 11, FontStyle.Italic);
                    lblKosong.ForeColor = Color.Gray;
                    lblKosong.AutoSize = true;
                    lblKosong.Margin = new Padding(20, 20, 0, 0);

                    flpRiwayat.Controls.Add(lblKosong);
                    return;
                }

                foreach (DataRow dr in dt.Rows)
                {
                    byte[] foto = null;

                    if (dr["foto_barang"] != DBNull.Value)
                    {
                        foto = (byte[])dr["foto_barang"];
                    }

                    Nambah(
                            Convert.ToInt32(dr["id_barang"]),
                            foto,
                            dr["nama_barang"].ToString(),
                            dr["nama_kategori"].ToString(),
                            dr["kondisi"].ToString(),
                            dr["status"].ToString(),
                            dr["catatan"].ToString(),
                            Convert.ToDateTime(dr["tanggal_upload"]).ToString("dd-MM-yyyy")
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil riwayat donasi: " + ex.Message);
            }
        }



        private void Nambah(int idBarang, byte[] fotoBytes, string nama, string kategori, string kondisi, string status, string catatan, string tanggal)
        {

            ModernCard card = new ModernCard();
            card.Size = new Size(350, 180);
            card.Margin = new Padding(10);

            Panel content = new Panel();
            content.Dock = DockStyle.Fill;
            content.BackColor = Color.White;
            content.Padding = new Padding(10);

            Label lblNama = new Label();
            lblNama.Text = nama;
            lblNama.Font = new Font("Inter", 10, FontStyle.Bold);
            lblNama.Location = new Point(85, 10);
            lblNama.AutoSize = true;

            Label lblKategori = new Label();
            lblKategori.Text = "Kategori : " + kategori;
            lblKategori.Location = new Point(85, 35);
            lblKategori.AutoSize = true;

            PictureBox picStatus = new PictureBox();
            picStatus.Size = new Size(70, 150);
            picStatus.Location = new Point(250, -40);
            picStatus.SizeMode = PictureBoxSizeMode.Zoom;
            if (status == "Diterima")
            {
                picStatus.Image = Properties.Resources.diterima;
            }
            else if (status == "Ditolak")
            {
                picStatus.Image = Properties.Resources.Ditolak;
            }
            else
            {
                picStatus.Image = Properties.Resources.menunggu;
            }

            Label lblTanggal = new Label();
            lblTanggal.Text = tanggal;
            lblTanggal.Location = new Point(85, 120);
            lblTanggal.AutoSize = true;

            if (String.IsNullOrEmpty(catatan))
            {
                catatan = "Tidak ada Catatan";
            }
            Label lblCatatan = new Label();
            lblCatatan.Text = "Catatan : " + catatan;
            lblCatatan.MaximumSize = new Size(270, 0);
            lblCatatan.AutoSize = true;
            lblCatatan.Location = new Point(85, 95);

            Button btnHapus = new Button();
            btnHapus.Text = "Hapus";
            btnHapus.Width = 80;
            btnHapus.Height = 30;
            btnHapus.Location = new Point(230, 130);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.BackColor = ColorTranslator.FromHtml("#199255");
            btnHapus.ForeColor = Color.White;
            if (status != "Menunggu Verifikasi")
                if (status != "Menunggu Verifikasi")
                {
                    btnHapus.Visible = false;
                }

            btnHapus.Click += (s, e) =>
            {
                HapusBarang(idBarang, status);
            };

            btnHapus.MouseEnter += (s, e) =>
            {
                btnHapus.BackColor = Color.Red;
            };

            btnHapus.MouseLeave += (s, e) =>
            {
                btnHapus.BackColor = ColorTranslator.FromHtml("#199255");
            };

            PictureBox pic = new PictureBox();
            pic.Width = 70;
            pic.Height = 70;
            pic.Location = new Point(10, 10);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.BorderStyle = BorderStyle.FixedSingle;
            if (fotoBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    pic.Image = Image.FromStream(ms);
                }
            }

            content.Controls.Add(lblNama);
            content.Controls.Add(lblKategori);
            content.Controls.Add(lblTanggal);
            content.Controls.Add(lblCatatan);
            content.Controls.Add(btnHapus);
            content.Controls.Add(picStatus);
            content.Controls.Add(pic);

            card.Controls.Add(content);

            flpRiwayat.Controls.Add(card);
        }

        private void HapusBarang(int idBarang, string status)
        {
            if (status != "Menunggu Verifikasi")
            {
                MessageBox.Show("Barang yang sudah diverifikasi tidak bisa dihapus");
                return;
            }

            DialogResult hasil = MessageBox.Show("Yakin ingin menghapus barang ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.No)
                return;

            try
            {
                bool berhasil = controller.HapusBarang(idBarang);
                if (berhasil)
                {
                    MessageBox.Show("Barang berhasil dihapus.");
                    TampilinRiwayatDonasi();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus barang.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settombolAktif(Button btn)
        {
            if (tombolaktif != null)
            {
                tombolaktif.BackColor = Color.White;
                tombolaktif.ForeColor = Color.Black;
            }

            tombolaktif = btn;
            tombolaktif.BackColor = ColorTranslator.FromHtml("#199255");
            tombolaktif.ForeColor= Color.White;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilinRiwayatDonasi();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmUploadBarang frm = new FrmUploadBarang(donatur);
            frm.Show();
            this.Close();
        }

        private void FrmRiwayatDonasi_Load_1(object sender, EventArgs e)
        {
            settombolAktif(btnSemua);

            btnSemua.FlatStyle = FlatStyle.Flat;
            btnSemua.FlatAppearance.BorderSize = 0;
            btnSemua.Paint += (s, e) =>
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnSemua.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnSemua.Width - radius, btnSemua.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnSemua.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btnSemua.Region = new Region(path);
            };

            btnMenunggu.FlatStyle = FlatStyle.Flat;
            btnMenunggu.FlatAppearance.BorderSize = 0;
            btnMenunggu.Paint += (s, e) =>
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnMenunggu.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnMenunggu.Width - radius, btnMenunggu.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnMenunggu.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btnMenunggu.Region = new Region(path);
            };

            btnDitolak.FlatStyle = FlatStyle.Flat;
            btnDitolak.FlatAppearance.BorderSize = 0;
            btnDitolak.Paint += (s, e) =>
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnDitolak.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnDitolak.Width - radius, btnDitolak.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnDitolak.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btnDitolak.Region = new Region(path);
            };

            btnDiterima.FlatStyle = FlatStyle.Flat;
            btnDiterima.FlatAppearance.BorderSize = 0;
            btnDiterima.Paint += (s, e) =>
            {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnDiterima.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnDiterima.Width - radius, btnDiterima.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnDiterima.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btnDiterima.Region = new Region(path);
            };
            TampilinRiwayatDonasi();
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            filterStatus = "";
            settombolAktif(btnSemua);
            TampilinRiwayatDonasi();
        }

        private void btnDiterima_Click(object sender, EventArgs e)
        {
            filterStatus = "Diterima";
            settombolAktif(btnDiterima);
            TampilinRiwayatDonasi();
        }

        private void btnDitolak_Click(object sender, EventArgs e)
        {
            filterStatus = "Ditolak";
            settombolAktif(btnDitolak);
            TampilinRiwayatDonasi();
        }

        private void btnMenunggu_Click(object sender, EventArgs e)
        {
            filterStatus = "Menunggu Verifikasi";
            settombolAktif(btnMenunggu);
            TampilinRiwayatDonasi();
        }

        private void btnKeProfil_Click(object sender, EventArgs e)
        {
            FrmProfilDonatur frm = new FrmProfilDonatur(donatur);
            frm.ShowDialog();
            this.Close();
        }

        private void btnKeRiwayat_Click(object sender, EventArgs e)
        {
            FrmRiwayatDonasi frm = new FrmRiwayatDonasi(donatur);
            frm.ShowDialog();
            this.Close();
        }
    }
}