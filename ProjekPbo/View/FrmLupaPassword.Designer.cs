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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPasswordBaru = new TextBox();
            txtKonfirmasi = new TextBox();
            btnSimpan = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 57);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 137);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Password Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 218);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 2;
            label3.Text = "Ulangi Passwordnya";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(37, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPasswordBaru
            // 
            txtPasswordBaru.Location = new Point(37, 172);
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.Size = new Size(307, 27);
            txtPasswordBaru.TabIndex = 4;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.Location = new Point(37, 253);
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.Size = new Size(307, 27);
            txtKonfirmasi.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(142, 308);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(37, 384);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FrmLupaPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPasswordBaru);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLupaPassword";
            Text = "FrmLupaPassword";
            Load += FrmLupaPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPasswordBaru;
        private TextBox txtKonfirmasi;
        private Button btnSimpan;
        private Button btnKembali;
    }
}