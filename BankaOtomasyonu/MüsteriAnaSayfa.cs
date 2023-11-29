using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class frmMüsteriAnaSayfa : Form
    {
        public frmMüsteriAnaSayfa()
        {
            InitializeComponent();
        }

        private void pARAÇEKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormGetir(Form frm)
        {
            pnlMain.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
        

       

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMüsteriAnaSayfa_Load(object sender, EventArgs e)
        {
            BireyselMusteri bireyselMusteri = new BireyselMusteri();
            frmMusteriLogin musteriLogin = new frmMusteriLogin();

            string x = frmMusteriLogin.rd;
            
            if (x=="bi")
            {
                MessageBox.Show("Bireysel Hesap Girişi Başarılı");
            }

            else if (x=="ti")
            {
                MessageBox.Show("Ticari Hesap Girişi Başarılı");
            }

        }

        private void paraYatırmakİçinTıklayınızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaYatirma paraYatirma = new frmParaYatirma();
            FormGetir(paraYatirma);
        }

       

        private void havaleYapmakİçinTıklayınızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavale havale = new frmHavale();
            FormGetir(havale);


        }


        private void paraÇekmeİşlemiİçinTıklayınızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParaCekme formParaCekme = new FormParaCekme();
            FormGetir(formParaCekme);
        }

        private void hesapRaporunuGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapOzeti hesapOzeti = new frmHesapOzeti();
            FormGetir(hesapOzeti);
        }

        private void hESAPÖZETİGÖSTERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
