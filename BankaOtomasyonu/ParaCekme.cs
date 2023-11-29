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
    public partial class FormParaCekme : Form
    {
        public FormParaCekme()
        {
            InitializeComponent();
        }

        private void FormParaCekme_Load(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();
            hesap.Bakiye = frmParaYatirma.tutar;
            MessageBox.Show("Bakiyeniz"+hesap.Bakiye.ToString());


        }
        Hesap hesap = new Hesap();
        public static int kalantutar;
        public static int countcekme=0;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();
            hesap.Bakiye = frmParaYatirma.tutar;
            
            if (Convert.ToInt32(txtParaTutar.Text) < 750 &&(hesap.Bakiye> Convert.ToInt32(txtParaTutar.Text)))
            {
                kalantutar = hesap.Bakiye- Convert.ToInt32(txtParaTutar.Text);
                MessageBox.Show("kalan bakiye:" + kalantutar);
                countcekme++;
            }

            else if (Convert.ToInt32(txtParaTutar.Text) > 750)
            {
                MessageBox.Show("750 TL'den fazla çekilemez");

            }

            else if (Convert.ToInt32(txtParaTutar.Text)>hesap.Bakiye)
            {
                DialogResult dialogResult = MessageBox.Show("Ek bakiyeden kullanmak ister misiniz?", "iptal", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kalantutar = hesap.Bakiye - Convert.ToInt32(txtParaTutar.Text)+hesap.EkBakiye;
                    MessageBox.Show("kalan:" + kalantutar.ToString());
                    countcekme++;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("iptal edildi");
                }
            }




        }

        private void btnCNCL_Click(object sender, EventArgs e)
        {
            txtHesapNo.Text = "";
            txtParaTutar.Text = "";
            txtHesapNo.Focus();
            MessageBox.Show("İptal Edildi");

        }
    }
}
