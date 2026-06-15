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
            btnSimpan = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(60, 243);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Masukkan Email";
            txtEmail.Size = new Size(258, 31);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPasswordBaru
            // 
            txtPasswordBaru.BorderStyle = BorderStyle.None;
            txtPasswordBaru.Location = new Point(69, 352);
            txtPasswordBaru.Multiline = true;
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.PlaceholderText = "Masukkan Password Baru";
            txtPasswordBaru.Size = new Size(249, 36);
            txtPasswordBaru.TabIndex = 4;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.BorderStyle = BorderStyle.None;
            txtKonfirmasi.Location = new Point(60, 461);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.PlaceholderText = "Ulangi Password Baru";
            txtKonfirmasi.Size = new Size(258, 29);
            txtKonfirmasi.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnSimpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSimpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(233, 536);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 37);
            btnSimpan.TabIndex = 6;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnKembali.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKembali.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Location = new Point(47, 536);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(97, 37);
            btnKembali.TabIndex = 7;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FrmLupaPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPasswordBaru);
            Controls.Add(txtEmail);
            DoubleBuffered = true;
            Name = "FrmLupaPassword";
            Text = "FrmLupaPassword";
            Load += FrmLupaPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private TextBox txtPasswordBaru;
        private TextBox txtKonfirmasi;
        private Button btnSimpan;
        private Button btnKembali;
    }
}