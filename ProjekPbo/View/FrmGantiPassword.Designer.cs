namespace ProjekPbo.View
{
    partial class FrmGantiPassword
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
            btnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKembali = new Button();
            txtPasswordLama = new TextBox();
            txtPasswordBaru = new TextBox();
            txtKonfirmasi = new TextBox();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(127, 291);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 41);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Password Lama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 122);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Password Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 207);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 3;
            label3.Text = "Ulangi Password Baru";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(32, 384);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // txtPasswordLama
            // 
            txtPasswordLama.Location = new Point(32, 75);
            txtPasswordLama.Name = "txtPasswordLama";
            txtPasswordLama.Size = new Size(279, 27);
            txtPasswordLama.TabIndex = 5;
            // 
            // txtPasswordBaru
            // 
            txtPasswordBaru.Location = new Point(32, 157);
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.Size = new Size(279, 27);
            txtPasswordBaru.TabIndex = 6;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.Location = new Point(32, 239);
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.Size = new Size(279, 27);
            txtKonfirmasi.TabIndex = 7;
            // 
            // FrmGantiPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPasswordBaru);
            Controls.Add(txtPasswordLama);
            Controls.Add(btnKembali);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Name = "FrmGantiPassword";
            Text = "FrmGantiPassword";
            Load += FrmGantiPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKembali;
        private TextBox txtPasswordLama;
        private TextBox txtPasswordBaru;
        private TextBox txtKonfirmasi;
    }
}