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
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 72);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(45, 240);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(296, 46);
            txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(45, 301);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 46);
            txtEmail.TabIndex = 7;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(45, 365);
            txtNoHP.Margin = new Padding(3, 2, 3, 2);
            txtNoHP.Multiline = true;
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(296, 45);
            txtNoHP.TabIndex = 8;
            txtNoHP.TextChanged += txtNoHP_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(45, 425);
            txtAlamat.Margin = new Padding(3, 2, 3, 2);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(296, 72);
            txtAlamat.TabIndex = 9;
            txtAlamat.Text = "";
            // 
            // txtSandi
            // 
            txtSandi.Location = new Point(45, 516);
            txtSandi.Margin = new Padding(3, 2, 3, 2);
            txtSandi.Multiline = true;
            txtSandi.Name = "txtSandi";
            txtSandi.Size = new Size(296, 40);
            txtSandi.TabIndex = 10;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.Location = new Point(45, 578);
            txtKonfirmasi.Margin = new Padding(3, 2, 3, 2);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.Size = new Size(296, 43);
            txtKonfirmasi.TabIndex = 11;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(43, 636);
            btnDaftar.Margin = new Padding(3, 2, 3, 2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(300, 52);
            btnDaftar.TabIndex = 13;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(239, 704);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 14;
            lblLogin.TabStop = true;
            lblLogin.Text = "Login";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 749);
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