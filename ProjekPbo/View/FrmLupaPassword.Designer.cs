namespace ProjekPbo.View
{
    partial class FrmLupaPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLupaPassword));
            txtEmail = new TextBox();
            txtPasswordBaru = new TextBox();
            txtKonfirmasi = new TextBox();
            btnKembali = new Button();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(93, 204);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Masukkan Email";
            txtEmail.Size = new Size(240, 28);
            txtEmail.TabIndex = 3;
            // 
            // txtPasswordBaru
            // 
            txtPasswordBaru.BorderStyle = BorderStyle.None;
            txtPasswordBaru.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
            txtPasswordBaru.Location = new Point(50, 293);
            txtPasswordBaru.Multiline = true;
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.PlaceholderText = "Masukkan Password Baru";
            txtPasswordBaru.Size = new Size(283, 29);
            txtPasswordBaru.TabIndex = 4;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.BorderStyle = BorderStyle.None;
            txtKonfirmasi.Font = new Font("Inter Medium", 9F, FontStyle.Bold);
            txtKonfirmasi.Location = new Point(50, 385);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.PlaceholderText = "Ulangi Password Baru";
            txtKonfirmasi.Size = new Size(283, 32);
            txtKonfirmasi.TabIndex = 5;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Inter ExtraBold", 10.8F, FontStyle.Bold);
            btnKembali.Location = new Point(44, 440);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(145, 58);
            btnKembali.TabIndex = 8;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Inter ExtraBold", 10.8F, FontStyle.Bold);
            btnSimpan.Location = new Point(197, 440);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(145, 58);
            btnSimpan.TabIndex = 9;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // FrmLupaPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 741);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPasswordBaru);
            Controls.Add(txtEmail);
            DoubleBuffered = true;
            Name = "FrmLupaPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REUSEHUB";
            Load += FrmLupaPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private TextBox txtPasswordBaru;
        private TextBox txtKonfirmasi;
        private Button btnKembali;
        private Button btnSimpan;
    }
}