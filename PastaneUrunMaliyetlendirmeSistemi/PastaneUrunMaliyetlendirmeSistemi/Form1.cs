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

namespace PastaneUrunMaliyetlendirmeSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=PastaneUrunMaliyetlendirmeSistemi;Integrated Security=True;TrustServerCertificate=True");

        void malzemeListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Malzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void urunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Urunler", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From Kasa", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrunOlusturUrun.ValueMember = "UrunID";
            cmbUrunOlusturUrun.DisplayMember = "Ad";
            cmbUrunOlusturUrun.DataSource = dt;
            baglanti.Close();
        }

        void malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from malzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrunOlusturMalzeme.ValueMember = "MalzemeID";
            cmbUrunOlusturMalzeme.DisplayMember = "Ad";
            cmbUrunOlusturMalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeListesi();
            urunler();
            malzemeler();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            urunListesi();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            malzemeListesi();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into malzemeler (ad,stok,fiyat,notlar) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtMalzemeNotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            malzemeListesi();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urunler (ad) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunListesi();
        }

        private void btnUrunOlusturEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into firin (UrunID,MalzemeID,Miktar,Maliyet) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbUrunOlusturUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbUrunOlusturMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtUrunOlusturMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtUrunOlusturMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtUrunOlusturMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;

            if (txtUrunOlusturMiktar.Text == "")
            {
                txtUrunOlusturMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from malzemeler where malzemeID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbUrunOlusturMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunOlusturMiktar.Text = dr[3].ToString();
            }
            baglanti.Close();
        }

        private void cmbUrunOlusturMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
