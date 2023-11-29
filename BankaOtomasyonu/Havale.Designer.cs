
namespace BankaOtomasyonu
{
    partial class frmHavale
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
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.txtHavaleNo = new System.Windows.Forms.TextBox();
            this.lblHavaleNo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtKesinti = new System.Windows.Forms.TextBox();
            this.lblKesinti = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.Teal;
            this.lblTutar.Location = new System.Drawing.Point(147, 160);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(284, 23);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "GÖNDERMEK İSTEDİĞİNİZ TUTAR:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(449, 160);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(120, 22);
            this.txtTutar.TabIndex = 1;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(449, 39);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(120, 22);
            this.txtHesapNo.TabIndex = 3;
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.ForeColor = System.Drawing.Color.Teal;
            this.lblHesapNo.Location = new System.Drawing.Point(147, 39);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(179, 23);
            this.lblHesapNo.TabIndex = 2;
            this.lblHesapNo.Text = "HESAP NUMARANIZ:";
            // 
            // txtHavaleNo
            // 
            this.txtHavaleNo.Location = new System.Drawing.Point(449, 95);
            this.txtHavaleNo.Name = "txtHavaleNo";
            this.txtHavaleNo.Size = new System.Drawing.Size(120, 22);
            this.txtHavaleNo.TabIndex = 5;
            // 
            // lblHavaleNo
            // 
            this.lblHavaleNo.AutoSize = true;
            this.lblHavaleNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHavaleNo.ForeColor = System.Drawing.Color.Teal;
            this.lblHavaleNo.Location = new System.Drawing.Point(147, 95);
            this.lblHavaleNo.Name = "lblHavaleNo";
            this.lblHavaleNo.Size = new System.Drawing.Size(258, 23);
            this.lblHavaleNo.TabIndex = 4;
            this.lblHavaleNo.Text = "KARŞI TARAFIN HESAP NO\'SU:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(243, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(252, 75);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "HAVALE YAP";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtKesinti
            // 
            this.txtKesinti.Location = new System.Drawing.Point(449, 217);
            this.txtKesinti.Name = "txtKesinti";
            this.txtKesinti.ReadOnly = true;
            this.txtKesinti.Size = new System.Drawing.Size(120, 22);
            this.txtKesinti.TabIndex = 8;
            // 
            // lblKesinti
            // 
            this.lblKesinti.AutoSize = true;
            this.lblKesinti.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKesinti.ForeColor = System.Drawing.Color.Teal;
            this.lblKesinti.Location = new System.Drawing.Point(147, 215);
            this.lblKesinti.Name = "lblKesinti";
            this.lblKesinti.Size = new System.Drawing.Size(157, 23);
            this.lblKesinti.TabIndex = 7;
            this.lblKesinti.Text = "BANKA KESİNTİSİ:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHesapla.Location = new System.Drawing.Point(602, 206);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(140, 44);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 457);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKesinti);
            this.Controls.Add(this.lblKesinti);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtHavaleNo);
            this.Controls.Add(this.lblHavaleNo);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Name = "frmHavale";
            this.Text = "Havale";
            this.Load += new System.EventHandler(this.Havale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTutar;
        public System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.TextBox txtHesapNo;
        public System.Windows.Forms.Label lblHesapNo;
        public System.Windows.Forms.TextBox txtHavaleNo;
        public System.Windows.Forms.Label lblHavaleNo;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Label lblKesinti;
        public System.Windows.Forms.TextBox txtKesinti;
        public System.Windows.Forms.Button btnHesapla;
    }
}