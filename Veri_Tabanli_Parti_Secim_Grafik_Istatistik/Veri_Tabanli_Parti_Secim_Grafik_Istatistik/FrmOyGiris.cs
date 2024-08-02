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

namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;TrustServerCertificate=True");

        private void btnOyGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Ilce (IlceAd, AParti, BParti, CParti, DParti, EParti) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", txtAParti.Text);
            komut.Parameters.AddWithValue("@p3", txtBParti.Text);
            komut.Parameters.AddWithValue("@p4", txtCParti.Text);
            komut.Parameters.AddWithValue("@p5", txtDParti.Text);
            komut.Parameters.AddWithValue("@p6", txtEParti.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
