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

namespace Sifreli_Veriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;TrustServerCertificate=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_veriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] adDizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adSifre = Convert.ToBase64String(adDizi);

            string soyad = txtSoyad.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadSifre = Convert.ToBase64String(soyadDizi);

            string mail = txtMail.Text;
            byte[] mailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailSifre = Convert.ToBase64String(mailDizi);

            string sifre = txtSifre.Text;
            byte[] sifreDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreSifre = Convert.ToBase64String(sifreDizi);

            string hesapNo = txtHesapNO.Text;
            byte[] hesapNoDizi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapNoSifre = Convert.ToBase64String(hesapNoDizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into tbl_veriler (ad, soyad, mail, sifre, hesapno) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adSifre);
            komut.Parameters.AddWithValue("@p2", soyadSifre);
            komut.Parameters.AddWithValue("@p3", mailSifre);
            komut.Parameters.AddWithValue("@p4", sifreSifre);
            komut.Parameters.AddWithValue("@p5", hesapNoSifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adCozum = txtAd.Text;
            byte[] adCozumDizi = Convert.FromBase64String(adCozum);
            string adVerisi = ASCIIEncoding.ASCII.GetString(adCozumDizi);
            label6.Text = adVerisi;
        }
    }
}
