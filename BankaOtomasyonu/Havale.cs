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
    public partial class frmHavale : Form
    {
        public frmHavale()
        {
            InitializeComponent();
        }

        public static int havaleKalan;
        public  int counthavale = FormParaCekme.countcekme;
        private void Havale_Load(object sender, EventArgs e)
        {

            

            frmMusteriLogin musteriLogin = new frmMusteriLogin();
            string x = frmMusteriLogin.rd;

            if (x == "bi")
            {
                MessageBox.Show("Bireysel Hesap ");
                MessageBox.Show(counthavale.ToString());
            }

            else if (x == "ti")
            {
                MessageBox.Show("Ticari Hesap");
                MessageBox.Show(counthavale.ToString());
            }

            Hesap hesap = new Hesap();
            hesap.Bakiye = havaleKalan;


        }

        double kesinti;
        double toplamKesinti;
        string x = frmMusteriLogin.rd;
        private void btnHesapla_Click(object sender, EventArgs e)
        {

            frmMusteriLogin frmMusteri = new frmMusteriLogin();
            Hesap hesap = new Hesap();
            

            if (x=="bi")
            {
                BireyselMusteri bireyselMusteri = new BireyselMusteri();
                kesinti = (bireyselMusteri.HavaleOrani * Convert.ToDouble(txtTutar.Text));
                txtKesinti.Text = kesinti.ToString();
                toplamKesinti = (Convert.ToDouble(kesinti) + Convert.ToDouble(txtTutar.Text));
                MessageBox.Show("Havale Ücreti:"+txtKesinti.Text.ToString()+"  TL");
            }

            else if (x=="ti")
            {
                TicariMusteri ticariMusteri = new TicariMusteri();
                kesinti = (ticariMusteri.HavaleOrani * Convert.ToDouble(txtTutar.Text));
                txtKesinti.Text = kesinti.ToString();
                toplamKesinti = (Convert.ToDouble(kesinti) + Convert.ToDouble(txtTutar.Text));
                MessageBox.Show("Havale Ücreti:"+txtKesinti.Text.ToString()+"  TL");

            }

            else
            {
                MessageBox.Show("hata");
            }

        }

        
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();
            hesap.Bakiye = frmParaYatirma.tutar;
            

            if (Convert.ToInt32(txtTutar.Text)>hesap.Bakiye)
            {
                MessageBox.Show("Bakiyeniz Yetersiz!");
            }

            else if (Convert.ToInt32(txtTutar.Text) <= hesap.Bakiye)
            {
                MessageBox.Show("hesap.bakiye="+hesap.Bakiye.ToString());
                hesap.Bakiye = hesap.Bakiye - (Convert.ToInt32(txtTutar.Text)+Convert.ToInt32(txtKesinti.Text));
                MessageBox.Show(txtTutar.Text.ToString() + "TL Gönderildi\nKalan Tutar:" +hesap.Bakiye.ToString());
                counthavale++;
            }

            
            //KONTROLLER

            // tutar yeterli mi kontrol et  (toplamKesintiyi)
            //hesap no var mı?
            // karsı tarafın hesap no su mevcut mu?


            // bakiyesini düş (toplamKesintiyi)
            // karsı tarafın bakiyesini arttır (txtTutar kadar)
        }

            





    }
}
