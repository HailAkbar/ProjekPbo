using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPbo.Models;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace ProjekPbo.View
{
    public partial class FrmProfilPengelola : Form
    {
        private Pengelola pengelola;
        public FrmProfilPengelola(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
        }

        private void FrmProfilPengelola_Load(object sender, EventArgs e)
        {
            SetupOutlineButton(btnLogout, ColorTranslator.FromHtml("#BF0606"));
            SetupOutlineButton(btnUbahPassword, ColorTranslator.FromHtml("#199255"));
            SetupOutlineButton(btnKembali, ColorTranslator.FromHtml("#8E8E93"));
            SetRoundedButton(btnLogout, ColorTranslator.FromHtml("#BF0606"), 20);
            SetRoundedButton(btnUbahPassword, ColorTranslator.FromHtml("#199255"), 20);
            SetRoundedButton(btnKembali, ColorTranslator.FromHtml("#8E8E93"), 20);

            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = ColorTranslator.FromHtml("#BF0606");
            btnLogout.Text = "Logout";

            btnLogout.MouseEnter += (s, e) =>
            {
                btnLogout.BackColor = ColorTranslator.FromHtml("#BF0606");
                btnLogout.ForeColor = Color.White;
            };

            btnLogout.MouseLeave += (s, e) =>
            {
                btnLogout.BackColor = Color.White;
                btnLogout.ForeColor = ColorTranslator.FromHtml("#BF0606");
            };

            btnUbahPassword.BackColor = Color.White;
            btnUbahPassword.ForeColor = ColorTranslator.FromHtml("#199255");
            btnUbahPassword.Text = "Ganti\nPassword";

            btnUbahPassword.MouseEnter += (s, e) =>
            {
                btnUbahPassword.BackColor = ColorTranslator.FromHtml("#199255");
                btnUbahPassword.ForeColor = Color.White;
            };

            btnUbahPassword.MouseLeave += (s, e) =>
            {
                btnUbahPassword.BackColor = Color.White;
                btnUbahPassword.ForeColor = ColorTranslator.FromHtml("#199255");
            };

            btnKembali.BackColor = Color.White;
            btnKembali.ForeColor = ColorTranslator.FromHtml("#8E8E93");
            btnKembali.Text = "Kembali";

            btnKembali.MouseEnter += (s, e) =>
            {
                btnKembali.BackColor = ColorTranslator.FromHtml("#8E8E93");
                btnKembali.ForeColor = Color.White;
            };

            btnKembali.MouseLeave += (s, e) =>
            {
                btnKembali.BackColor = Color.White;
                btnKembali.ForeColor = ColorTranslator.FromHtml("#8E8E93");
            };

            lblNamaAtas.Text = pengelola.nama.ToString();
            lblNama.Text = pengelola.nama.ToString();
            lblEmail.Text = pengelola.email.ToString();
            lblNoHp.Text = pengelola.nomorHp.ToString();
        }
        private void SetupOutlineButton(Button btn, Color warna)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = warna;

            btn.BackColor = Color.White;
            btn.ForeColor = warna;
        }
        private void SetRoundedButton(Button btn, Color borderColor, int radius)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 3;

            btn.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);

                GraphicsPath path = new GraphicsPath();

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, 1))
                {
                    g.DrawPath(pen, path);
                }
            };
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Yakin Mau Logout? ", "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            FrmGantiPassword frm = new FrmGantiPassword(pengelola);
            frm.ShowDialog();
            this.Hide();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.ShowDialog();
            this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaAtas_Click(object sender, EventArgs e)
        {

        }

        private void btnkeBeranda_Click(object sender, EventArgs e)
        {
            FrmPengelola frm = new FrmPengelola(pengelola);
            frm.Show();
            this.Hide(); 
        }
    }
}
