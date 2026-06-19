using Npgsql;
using ProjekPbo.Controllers;
using ProjekPbo.Database;
using ProjekPbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace ProjekPbo.View
{
    public partial class FrmGantiPassword : Form
    {
        private Pengelola pengelola;
        private C_GantiPasswordPengelola controller;
        public FrmGantiPassword(Pengelola p)
        {
            InitializeComponent();
            pengelola = p;
            controller = new C_GantiPasswordPengelola();

            btnKembali.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            btnKembali.ForeColor = Color.White;
            btnKembali.Text = "Kembali";

            btnKembali.MouseEnter += (s, e) => {
                btnKembali.BackColor = ColorTranslator.FromHtml("#199255");
            };

            btnKembali.MouseLeave += (s, e) => {
                btnKembali.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            };

            btnSimpan.BackColor = ColorTranslator.FromHtml("#199255");
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Text = "Simpan";

            btnSimpan.MouseEnter += (s, e) => {
                btnSimpan.BackColor = ColorTranslator.FromHtml("#8E8E8E");
            };

            btnSimpan.MouseLeave += (s, e) => {
                btnSimpan.BackColor = ColorTranslator.FromHtml("#199255");
            };
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!Validasi())
                return;

            GantiPassword();
        }

        private bool Validasi()
        {
            if (txtPasswordLama.Text.Trim() == "")
            {
                MessageBox.Show("Password lama harus diisi");
                return false;
            }

            if (txtPasswordBaru.Text.Trim() == "")
            {
                MessageBox.Show("Password baru tidak boleh kosong");
                return false;
            }

            if (txtKonfirmasi.Text.Trim() == "")
            {
                MessageBox.Show("Konfirmasi Password harus diisi");
                return false;
            }

            if (txtKonfirmasi.Text != txtPasswordBaru.Text)
            {
                MessageBox.Show("Konfirmasi Password harus sama");
                return false;
            }

            return true;
        }

        private void GantiPassword()
        {
            try
            {
                bool berhasil = controller.gantiPassword(pengelola, txtPasswordLama.Text, txtPasswordBaru.Text);
                if (!berhasil)
                {
                    MessageBox.Show("Password Lama Salah!");
                    return;
                }

                MessageBox.Show("Password Berhasil Diubah!");

                FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
                frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmProfilPengelola frm = new FrmProfilPengelola(pengelola);
            frm.Show();
            this.Close();
        }

        private void FrmGantiPassword_Load(object sender, EventArgs e)
        {
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.FlatAppearance.BorderSize = 0;

            btnKembali.Paint += (s, e) => {
                int radius = 20;
                GraphicsPath path = new GraphicsPath();


                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btnKembali.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btnKembali.Width - radius, btnKembali.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btnKembali.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btnKembali.Region = new Region(path);

                btnSimpan.FlatStyle = FlatStyle.Flat;
                btnSimpan.FlatAppearance.BorderSize = 0;

                btnSimpan.Paint += (s, e) => {
                    int radius = 20;
                    GraphicsPath path = new GraphicsPath();


                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(btnSimpan.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(btnSimpan.Width - radius, btnSimpan.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, btnSimpan.Height - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    btnSimpan.Region = new Region(path);
                };
            };
        }
    }
}
