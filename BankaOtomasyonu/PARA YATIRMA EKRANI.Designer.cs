
namespace BankaOtomasyonu
{
    partial class frmParaYatirma
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
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHesapNo.Location = new System.Drawing.Point(263, 106);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(97, 23);
            this.lblHesapNo.TabIndex = 0;
            this.lblHesapNo.Text = "HESAP NO:";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapNo.Location = new System.Drawing.Point(389, 106);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(123, 30);
            this.txtHesapNo.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(389, 174);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(123, 30);
            this.txtTutar.TabIndex = 3;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTutar.Location = new System.Drawing.Point(263, 177);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(65, 23);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "TUTAR:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(304, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(176, 58);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "PARA YATIR";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmParaYatirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.lblHesapNo);
            this.Name = "frmParaYatirma";
            this.Text = "PARA YATIRMA EKRANI";
            this.Load += new System.EventHandler(this.frmParaYatirma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnOK;
    }
}