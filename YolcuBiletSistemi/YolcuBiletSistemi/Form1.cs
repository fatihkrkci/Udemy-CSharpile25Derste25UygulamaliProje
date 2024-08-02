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

namespace YolcuBiletSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=YolcuBiletSistemi;Integrated Security=True;TrustServerCertificate=True");

        void seferListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_SeferBilgi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_YolcuBilgi (ad,soyad,telefon,tc,cinsiyet,mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi");
        }

        private void btnKaptanKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kaptan (kaptanno,adsoyad,telefon) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi");
        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_SeferBilgi (kalkis,varis,tarih,saat,kaptan,fiyat) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", txtVaris.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", mskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi");
            seferListesi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtSeferNumara.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtYolcuKoltukNo.Text = "9";
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_SeferDetay (seferno,yolcutc,koltuk) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi");
        }
    }
}
