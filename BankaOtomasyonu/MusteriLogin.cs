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
    public partial class frmMusteriLogin : Form
    {
        public frmMusteriLogin()
        {
            InitializeComponent();
        }

        public bool RadioButtonSelected { get; set; }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (true)
            {
                frmMüsteriAnaSayfa frmMüsteriAna = new frmMüsteriAnaSayfa();
                frmMüsteriAna.Show();
                this.Hide();
            }
        }


        public static string rd;
        private void rdBtnBireysel_CheckedChanged(object sender, EventArgs e)
        {
            BireyselMusteri bireyselMusteri = new BireyselMusteri();

            

            if (rdBtnBireysel.Checked)
            {
                rd = "bi";
            }

            
        }

       

        private void rdBtnTicari_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdBtnTicari.Checked)
            {
                rd = "ti";
            }

        }

       

        private void MusteriLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
