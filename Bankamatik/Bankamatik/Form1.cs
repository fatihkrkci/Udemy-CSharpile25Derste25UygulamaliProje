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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=DbBankamatik;Integrated Security=True;TrustServerCertificate=True");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kisiler Where HesapNo=@p1 AND Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 form2 = new Form2();
                form2.hesapNo = mskHesapNo.Text;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            baglanti.Close();
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
