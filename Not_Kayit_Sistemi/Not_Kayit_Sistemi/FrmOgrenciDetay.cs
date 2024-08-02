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

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;TrustServerCertificate=True");
        public string numara, durum;

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ders Where OgrenciNumara=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                if (dr[8].ToString() == "True")
                {
                    durum = "Geçti";
                }
                if (dr[8].ToString() == "False")
                {
                    durum = "Kaldı";
                }
                lblDurum.Text = durum;
            }
            baglanti.Close();
        }
    }
}
