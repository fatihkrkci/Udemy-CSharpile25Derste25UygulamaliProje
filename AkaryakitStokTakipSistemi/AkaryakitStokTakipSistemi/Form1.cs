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

namespace AkaryakitStokTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=AkaryakitStokTakipSistemi;Integrated Security=True;TrustServerCertificate=True");

        void listele()
        {
            //Kurşunsuz95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblBenzin Where PetrolTur='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKursunsuz95.Text = dr[3].ToString();
                prgKursunsuz95.Value = int.Parse(dr[4].ToString());
                lblKursunsuz95Depo.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Kurşunsuz97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From TblBenzin Where PetrolTur='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKursunsuz97.Text = dr2[3].ToString();
                prgKursunsuz97.Value = int.Parse(dr2[4].ToString());
                lblKursunsuz97Depo.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //EuroDizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From TblBenzin Where PetrolTur='EuroDizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblEuroDizel10.Text = dr3[3].ToString();
                prgEuroDizel10.Value = int.Parse(dr3[4].ToString());
                lblEuroDizel10Depo.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //YeniProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From TblBenzin Where PetrolTur='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblYeniProDizel.Text = dr4[3].ToString();
                prgYeniProDizel.Value = int.Parse(dr4[4].ToString());
                lblYeniProDizelDepo.Text = dr4[4].ToString();
            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * From TblBenzin Where PetrolTur='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblGaz.Text = dr5[3].ToString();
                prgGaz.Value = int.Parse(dr5[4].ToString());
                lblGazDepo.Text = dr5[4].ToString();
            }
            baglanti.Close();

            //Kasa
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * From tblkasa", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void nmrKursunsuz95_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblKursunsuz95.Text);
            litre = Convert.ToDouble(nmrKursunsuz95.Value);
            tutar = kursunsuz95 * litre;
            txtKursunsuz95Tutar.Text = tutar.ToString();
        }

        private void bmrKursunsuz97_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblKursunsuz97.Text);
            litre = Convert.ToDouble(nmrKursunsuz97.Value);
            tutar = kursunsuz97 * litre;
            txtKursunsuz97Tutar.Text = tutar.ToString();
        }

        private void nmrEuroDizel10_ValueChanged(object sender, EventArgs e)
        {
            double euroDizel10, litre, tutar;
            euroDizel10 = Convert.ToDouble(lblEuroDizel10.Text);
            litre = Convert.ToDouble(nmrEuroDizel10.Value);
            tutar = euroDizel10 * litre;
            txtEuroDizel10Tutar.Text = tutar.ToString();
        }

        private void nmrYeniProDizel_ValueChanged(object sender, EventArgs e)
        {
            double yeniProDizel, litre, tutar;
            yeniProDizel = Convert.ToDouble(lblYeniProDizel.Text);
            litre = Convert.ToDouble(nmrYeniProDizel.Value);
            tutar = yeniProDizel * litre;
            txtYeniProDizelTutar.Text = tutar.ToString();
        }

        private void nmrGaz_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblGaz.Text);
            litre = Convert.ToDouble(nmrGaz.Value);
            tutar = gaz * litre;
            txtGazTutar.Text = tutar.ToString();
        }

        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (nmrKursunsuz95.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tblhareket (plaka,benzinturu, litre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3", nmrKursunsuz95.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz95Tutar.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblkasa set miktar=miktar+@p1",baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuz95Tutar.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update tblbenzin set stok=stok-@p1 where petroltur='Kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", nmrKursunsuz95.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                listele();
            }
        }
    }
}
