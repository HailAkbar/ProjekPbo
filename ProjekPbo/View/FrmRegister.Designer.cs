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
            txtAlamat = new RichTextBox();
            txtSandi = new TextBox();
            txtKonfirmasi = new TextBox();
            btnDaftar = new Button();
            lblLogin = new LinkLabel();
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
            txtNama.Location = new Point(51, 240);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama";
            txtNama.Size = new Size(286, 37);
            txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(51, 302);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(286, 37);
            txtEmail.TabIndex = 7;
            // 
            // txtNoHP
            // 
            txtNoHP.BorderStyle = BorderStyle.None;
            txtNoHP.Location = new Point(51, 366);
            txtNoHP.Margin = new Padding(3, 2, 3, 2);
            txtNoHP.Multiline = true;
            txtNoHP.Name = "txtNoHP";
            txtNoHP.PlaceholderText = "No HP";
            txtNoHP.Size = new Size(286, 37);
            txtNoHP.TabIndex = 8;
            txtNoHP.TextChanged += txtNoHP_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.None;
            txtAlamat.Location = new Point(51, 424);
            txtAlamat.Margin = new Padding(3, 2, 3, 2);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(286, 66);
            txtAlamat.TabIndex = 9;
            txtAlamat.Text = "";
            // 
            // txtSandi
            // 
            txtSandi.BorderStyle = BorderStyle.None;
            txtSandi.Location = new Point(51, 512);
            txtSandi.Margin = new Padding(3, 2, 3, 2);
            txtSandi.Multiline = true;
            txtSandi.Name = "txtSandi";
            txtSandi.PlaceholderText = "Password";
            txtSandi.Size = new Size(286, 37);
            txtSandi.TabIndex = 10;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.BorderStyle = BorderStyle.None;
            txtKonfirmasi.Location = new Point(51, 572);
            txtKonfirmasi.Margin = new Padding(3, 2, 3, 2);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.PlaceholderText = "Konfirmasi Password";
            txtKonfirmasi.Size = new Size(286, 38);
            txtKonfirmasi.TabIndex = 11;
            txtKonfirmasi.TextChanged += txtKonfirmasi_TextChanged;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.Transparent;
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Location = new Point(37, 627);
            btnDaftar.Margin = new Padding(3, 2, 3, 2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(308, 61);
            btnDaftar.TabIndex = 13;
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.DisabledLinkColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.LinkColor = Color.Transparent;
            lblLogin.Location = new Point(237, 690);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 25);
            lblLogin.TabIndex = 14;
            lblLogin.TabStop = true;
            lblLogin.Text = "Login";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 741);
            Controls.Add(lblLogin);
            Controls.Add(btnDaftar);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtSandi);
            Controls.Add(txtAlamat);
            Controls.Add(txtNoHP);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegister";
            Text = "FrmRegister";
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
        private RichTextBox txtAlamat;
        private TextBox txtSandi;
        private TextBox txtKonfirmasi;
        private Button btnDaftar;
        private LinkLabel lblLogin;
    }
}