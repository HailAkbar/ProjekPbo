using ProjekPbo.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using ProjekPbo.Controllers;
using System.Drawing.Drawing2D;

namespace ProjekPbo.View
{
    public partial class FrmLupaPassword : Form
    {
        private C_LupaPasswordDonatur controller;
        public FrmLupaPassword()
        {
            InitializeComponent();
            controller = new C_LupaPasswordDonatur();

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

            ResetPassword();
        }

        private bool Validasi()
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email Wajib Diisi");
                return false;
            }

            if (txtPasswordBaru.Text.Trim() == "")
            {
                MessageBox.Show("Password Barunya Harus Diisi");
                return false;
            }

            if (txtKonfirmasi.Text.Trim() == "")
            {
                MessageBox.Show("Konfirmasi Password Harus Diisi");
                return false;
            }

            if (txtPasswordBaru.Text != txtPasswordBaru.Text.Trim())
            {
                MessageBox.Show("Konfirmasi Password Tidak Sama");
                return false;
            }
            return true;
        }

        private void ResetPassword()
        {
            try
            {
                bool berhasil = controller.LupaPassword(txtEmail.Text.Trim(), txtPasswordBaru.Text);
                if (!berhasil)
                {
                    MessageBox.Show("Email Tidak Ditemukan!");
                }

                MessageBox.Show("Password Berhasil Diubah!");
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void FrmLupaPassword_Load(object sender, EventArgs e)
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
