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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGantiPassword));
            btnSimpan = new Button();
            btnKembali = new Button();
            txtPasswordLama = new TextBox();
            txtPasswordBaru = new TextBox();
            txtKonfirmasi = new TextBox();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(202, 448);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(143, 50);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(41, 448);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(146, 50);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // txtPasswordLama
            // 
            txtPasswordLama.Location = new Point(45, 195);
            txtPasswordLama.Margin = new Padding(3, 2, 3, 2);
            txtPasswordLama.Multiline = true;
            txtPasswordLama.Name = "txtPasswordLama";
            txtPasswordLama.Size = new Size(291, 47);
            txtPasswordLama.TabIndex = 5;
            // 
            // txtPasswordBaru
            // 
            txtPasswordBaru.Location = new Point(45, 289);
            txtPasswordBaru.Margin = new Padding(3, 2, 3, 2);
            txtPasswordBaru.Multiline = true;
            txtPasswordBaru.Name = "txtPasswordBaru";
            txtPasswordBaru.Size = new Size(291, 44);
            txtPasswordBaru.TabIndex = 6;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.Location = new Point(45, 382);
            txtKonfirmasi.Margin = new Padding(3, 2, 3, 2);
            txtKonfirmasi.Multiline = true;
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.Size = new Size(291, 46);
            txtKonfirmasi.TabIndex = 7;
            // 
            // FrmGantiPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 749);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPasswordBaru);
            Controls.Add(txtPasswordLama);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGantiPassword";
            Text = "FrmGantiPassword";
            Load += FrmGantiPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnKembali;
        private TextBox txtPasswordLama;
        private TextBox txtPasswordBaru;
        private TextBox txtKonfirmasi;
    }
}