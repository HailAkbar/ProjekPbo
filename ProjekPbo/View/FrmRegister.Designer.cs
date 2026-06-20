namespace ProjekPbo.View
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            txtNoHP = new TextBox();
            txtSandi = new TextBox();
            txtKonfirmasi = new TextBox();
            btnDaftar = new Button();
            lblLogin = new LinkLabel();
            txtAlamat = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 96);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // txtNama
            // 
            txtNama.BackColor = SystemColors.Window;
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            txtNama.Location = new Point(97, 245);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama";
            txtNama.Size = new Size(236, 29);
            txtNama.TabIndex = 6;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            txtEmail.Location = new Point(97, 310);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtNoHP
            // 
            txtNoHP.BorderStyle = BorderStyle.None;
            txtNoHP.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            txtNoHP.Location = new Point(97, 371);
            txtNoHP.Margin = new Padding(3, 2, 3, 2);
            txtNoHP.Multiline = true;
            txtNoHP.Name = "txtNoHP";
            txtNoHP.PlaceholderText = "No HP";
            txtNoHP.Size = new Size(236, 32);
            txtNoHP.TabIndex = 8;
            // 
            // txtSandi
            // 
            txtSandi.BorderStyle = BorderStyle.None;
            txtSandi.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            txtSandi.Location = new Point(97, 516);
            txtSandi.Margin = new Padding(3, 2, 3, 2);
            txtSandi.Multiline = true;
            txtSandi.Name = "txtSandi";
            txtSandi.PlaceholderText = "Password";
            txtSandi.Size = new Size(236, 32);
            txtSandi.TabIndex = 10;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.BorderStyle = BorderStyle.None;
            txtKonfirmasi.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            txtKonfirmasi.Location = new Point(97, 579);
            txtKonfirmasi.Margin = new Padding(3, 2, 3, 2);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.PlaceholderText = "Konfirmasi Password";
            txtKonfirmasi.Size = new Size(236, 30);
            txtKonfirmasi.TabIndex = 11;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.Transparent;
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Inter ExtraBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(43, 629);
            btnDaftar.Margin = new Padding(3, 2, 3, 2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(297, 52);
            btnDaftar.TabIndex = 13;
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.DisabledLinkColor = Color.Transparent;
            lblLogin.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.LinkBehavior = LinkBehavior.NeverUnderline;
            lblLogin.LinkColor = Color.FromArgb(142, 142, 142);
            lblLogin.Location = new Point(226, 693);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 22);
            lblLogin.TabIndex = 14;
            lblLogin.TabStop = true;
            lblLogin.Text = "Login";
            lblLogin.LinkClicked += lblLogin_LinkClicked;
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.None;
            txtAlamat.Font = new Font("Inter Medium", 10.2F, FontStyle.Bold);
            txtAlamat.Location = new Point(97, 429);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = "Alamat";
            txtAlamat.Size = new Size(236, 61);
            txtAlamat.TabIndex = 15;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 741);
            Controls.Add(txtAlamat);
            Controls.Add(lblLogin);
            Controls.Add(btnDaftar);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtSandi);
            Controls.Add(txtNoHP);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REUSEHUB";
            Load += FrmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNama;
        private TextBox txtEmail;
        private TextBox txtNoHP;
        private TextBox txtSandi;
        private TextBox txtKonfirmasi;
        private Button btnDaftar;
        private LinkLabel lblLogin;
        private TextBox txtAlamat;
    }
}