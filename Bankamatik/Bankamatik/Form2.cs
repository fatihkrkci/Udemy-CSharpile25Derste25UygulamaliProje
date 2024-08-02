using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankamatik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=DbBankamatik;Integrated Security=True;TrustServerCertificate=True");

        public string hesapNo;

        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesapNo;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kisiler where hesapno=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesapNo);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTC.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_hesap set bakiye=bakiye+@p1 where hesapNo=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p2", mskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //Gönderen Hesabın Para Azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update tbl_hesap set bakiye=@k1 where hesapno=@k2", baglanti);
            komut.Parameters.AddWithValue("@k1", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@k2", hesapNo);
            baglanti.Close();
            MessageBox.Show("İşlem Gerçekleşti");
        }
    }
}
