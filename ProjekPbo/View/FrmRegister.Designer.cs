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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 96);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 149);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "No HP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 208);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 286);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 356);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 5;
            label6.Text = "Konfirmasi Password";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(42, 63);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(125, 27);
            txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(49, 179);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(125, 27);
            txtNoHP.TabIndex = 8;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(49, 234);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(233, 49);
            txtAlamat.TabIndex = 9;
            txtAlamat.Text = "";
            // 
            // txtSandi
            // 
            txtSandi.Location = new Point(43, 310);
            txtSandi.Name = "txtSandi";
            txtSandi.Size = new Size(125, 27);
            txtSandi.TabIndex = 10;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.Location = new Point(42, 391);
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.Size = new Size(125, 27);
            txtKonfirmasi.TabIndex = 11;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(125, 434);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(94, 29);
            btnDaftar.TabIndex = 13;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(64, 479);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 14;
            lblLogin.TabStop = true;
            lblLogin.Text = "Login";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 520);
            Controls.Add(lblLogin);
            Controls.Add(btnDaftar);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtSandi);
            Controls.Add(txtAlamat);
            Controls.Add(txtNoHP);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
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