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

namespace Trigger_Kullanimi
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
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sayac", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKitapAdet.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kitaplar (ad, yazar, sayfa, yayinevi, tur) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@p5", txtTur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Eklendi");
            listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYayinevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Tbl_kitaplar Where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sistemden Silindi");
            listele();
            sayac();
        }
    }
}
