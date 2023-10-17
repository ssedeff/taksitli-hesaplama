using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kar_orani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat;
            double toplam=0;
            fiyat=Convert.ToSingle(txtFiyat.Text);
            if (rbPeşin.Checked)
            {
                fiyat = fiyat;
                toplam = fiyat;
            }
            else if (rb2.Checked)
            {
                fiyat = fiyat * 1.02;
                toplam = fiyat / 2;
            }
            else if (rb6.Checked)
            {
                fiyat = fiyat * 1.04;
                toplam= fiyat / 6;
            }
            else if (rb9.Checked)
            {
                fiyat = fiyat * 1.07;
                toplam = fiyat / 9;
            }
            else
            {
                fiyat = fiyat * 1.10;
                toplam = fiyat / 12;
            }
            lblTaksit.Text ="TAKSİT TUTAR: "+ fiyat.ToString();
            lblToplam.Text = "TOPLAM TUTAR: "+toplam.ToString();
        }
    }
}
