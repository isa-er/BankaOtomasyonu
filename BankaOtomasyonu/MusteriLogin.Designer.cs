
namespace BankaOtomasyonu
{
    partial class frmMusteriLogin
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.rdBtnBireysel = new System.Windows.Forms.RadioButton();
            this.rdBtnTicari = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(250, 97);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(94, 23);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "HESAP NO:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(426, 97);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(120, 22);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(426, 161);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(120, 22);
            this.txtKullaniciSifre.TabIndex = 3;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSifre.Location = new System.Drawing.Point(250, 161);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(61, 23);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "ŞİFRE:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGirisYap.Location = new System.Drawing.Point(272, 299);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(274, 67);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // rdBtnBireysel
            // 
            this.rdBtnBireysel.AutoSize = true;
            this.rdBtnBireysel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnBireysel.ForeColor = System.Drawing.SystemColors.Info;
            this.rdBtnBireysel.Location = new System.Drawing.Point(202, 233);
            this.rdBtnBireysel.Name = "rdBtnBireysel";
            this.rdBtnBireysel.Size = new System.Drawing.Size(203, 27);
            this.rdBtnBireysel.TabIndex = 5;
            this.rdBtnBireysel.TabStop = true;
            this.rdBtnBireysel.Text = "BİREYSEL MÜŞTERİYİM";
            this.rdBtnBireysel.UseVisualStyleBackColor = true;
            this.rdBtnBireysel.CheckedChanged += new System.EventHandler(this.rdBtnBireysel_CheckedChanged);
            // 
            // rdBtnTicari
            // 
            this.rdBtnTicari.AutoSize = true;
            this.rdBtnTicari.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnTicari.ForeColor = System.Drawing.SystemColors.Info;
            this.rdBtnTicari.Location = new System.Drawing.Point(464, 233);
            this.rdBtnTicari.Name = "rdBtnTicari";
            this.rdBtnTicari.Size = new System.Drawing.Size(184, 27);
            this.rdBtnTicari.TabIndex = 6;
            this.rdBtnTicari.TabStop = true;
            this.rdBtnTicari.Text = "TİCARİ MÜŞTERİYİM";
            this.rdBtnTicari.UseVisualStyleBackColor = true;
            this.rdBtnTicari.CheckedChanged += new System.EventHandler(this.rdBtnTicari_CheckedChanged);
            // 
            // frmMusteriLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdBtnTicari);
            this.Controls.Add(this.rdBtnBireysel);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "frmMusteriLogin";
            this.Text = "MusteriLogin";
            this.Load += new System.EventHandler(this.MusteriLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKullaniciAdi;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.TextBox txtKullaniciSifre;
        public System.Windows.Forms.Label lblSifre;
        public System.Windows.Forms.Button btnGirisYap;
        public System.Windows.Forms.RadioButton rdBtnBireysel;
        public System.Windows.Forms.RadioButton rdBtnTicari;
    }
}