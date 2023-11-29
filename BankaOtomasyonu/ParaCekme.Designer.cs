
namespace BankaOtomasyonu
{
    partial class FormParaCekme
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
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnCNCL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblHesaplar = new System.Windows.Forms.Label();
            this.txtParaTutar = new System.Windows.Forms.TextBox();
            this.lblParaTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(471, 172);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(121, 22);
            this.txtHesapNo.TabIndex = 12;
            // 
            // btnCNCL
            // 
            this.btnCNCL.BackColor = System.Drawing.Color.Crimson;
            this.btnCNCL.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCNCL.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCNCL.Location = new System.Drawing.Point(424, 274);
            this.btnCNCL.Name = "btnCNCL";
            this.btnCNCL.Size = new System.Drawing.Size(156, 55);
            this.btnCNCL.TabIndex = 11;
            this.btnCNCL.Text = "İPTAL ET";
            this.btnCNCL.UseVisualStyleBackColor = false;
            this.btnCNCL.Click += new System.EventHandler(this.btnCNCL_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(209, 274);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(166, 55);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "PARAYI ÇEK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblHesaplar
            // 
            this.lblHesaplar.AutoSize = true;
            this.lblHesaplar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesaplar.ForeColor = System.Drawing.Color.Crimson;
            this.lblHesaplar.Location = new System.Drawing.Point(189, 170);
            this.lblHesaplar.Name = "lblHesaplar";
            this.lblHesaplar.Size = new System.Drawing.Size(244, 23);
            this.lblHesaplar.TabIndex = 9;
            this.lblHesaplar.Text = "HESAP NUMARANIZI YAZINIZ:";
            // 
            // txtParaTutar
            // 
            this.txtParaTutar.Location = new System.Drawing.Point(471, 95);
            this.txtParaTutar.Name = "txtParaTutar";
            this.txtParaTutar.Size = new System.Drawing.Size(121, 22);
            this.txtParaTutar.TabIndex = 8;
            // 
            // lblParaTutar
            // 
            this.lblParaTutar.AutoSize = true;
            this.lblParaTutar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaTutar.ForeColor = System.Drawing.Color.Crimson;
            this.lblParaTutar.Location = new System.Drawing.Point(189, 93);
            this.lblParaTutar.Name = "lblParaTutar";
            this.lblParaTutar.Size = new System.Drawing.Size(230, 23);
            this.lblParaTutar.TabIndex = 7;
            this.lblParaTutar.Text = "ÇEKMEK İSTEDİĞİNİZ TUTAR";
            // 
            // FormParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.btnCNCL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblHesaplar);
            this.Controls.Add(this.txtParaTutar);
            this.Controls.Add(this.lblParaTutar);
            this.Name = "FormParaCekme";
            this.Text = "ParaCekme";
            this.Load += new System.EventHandler(this.FormParaCekme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtHesapNo;
        public System.Windows.Forms.Button btnCNCL;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Label lblHesaplar;
        public System.Windows.Forms.TextBox txtParaTutar;
        public System.Windows.Forms.Label lblParaTutar;
    }
}