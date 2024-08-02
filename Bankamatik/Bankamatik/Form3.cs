using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankamatik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=DbBankamatik;Integrated Security=True;TrustServerCertificate=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_kisiler (Ad, Soyad, TC, Telefon, HesapNo, Sifre) values (@p1, @p2, @p3, @p4, @p5, @p6)",  baglanti );
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");
        }

        private void btnHesapNo_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000, 1000000);
            mskHesapNo.Text = sayi.ToString();
        }
    }
}
