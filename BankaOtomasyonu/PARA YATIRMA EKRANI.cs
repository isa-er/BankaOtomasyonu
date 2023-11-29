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
    public partial class frmParaYatirma : Form
    {
        public frmParaYatirma()
        {
            InitializeComponent();
        }



        Hesap hesap = new Hesap();
        public static int tutar;
        int kalan = FormParaCekme.kalantutar;
        int havaleKalan = frmHavale.havaleKalan;

        int countpara = FormParaCekme.countcekme;
        private void btnOK_Click(object sender, EventArgs e)
        {

            hesap.Bakiye += Convert.ToInt32(txtTutar.Text) + kalan;
            tutar = hesap.Bakiye;
            MessageBox.Show("Yeni Bakiyeniz:" + tutar.ToString()+"TL");
            countpara++;
        }

        private void frmParaYatirma_Load(object sender, EventArgs e)
        {

        }
    }
}
