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
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;TrustServerCertificate=True");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.Tbl_Ders' table. You can move, or remove it, as needed.
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Ders WHERE durum = 0", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lblKalanSayisi.Text = dr1[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Ders WHERE durum = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblGecenSayisi.Text = dr2[0].ToString();
            }
            baglanti.Close();
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Tbl_Ders (OgrenciNumara, OgrenciAd, OgrenciSoyad) values (@p1, @p2, @p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;

            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Ders set OgrenciSinav1=@p1, OgrenciSinav2=@p2, OgrenciSinav3=@p3, Ortalama=@p4, Durum=@p5 Where OgrenciNumara=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSinav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSinav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSinav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
        }
    }
}
