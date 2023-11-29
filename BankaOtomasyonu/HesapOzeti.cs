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
    public partial class frmHesapOzeti : Form
    {
        public frmHesapOzeti()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void frmHesapOzeti_Load(object sender, EventArgs e)
        {
            //tablo.Columns[2].ColumnName = "surun1";
            tablo.Columns.Add("giden", typeof(int));
            tablo.Columns.Add("gelen", typeof(int));
            dataGridView1.DataSource = tablo;
            //MessageBox.Show(frmParaYatirma.)


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(FormParaCekme.countcekme.ToString(),"2");
            dataGridView1.DataSource = tablo;
        }
    }
}
