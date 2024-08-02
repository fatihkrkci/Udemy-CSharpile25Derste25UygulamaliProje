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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=Rehber;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Kisiler", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTelefon.Text = "";
            txtMail.Text = "";
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kisiler (Ad, Soyad, Telefon, Mail) values (@p1, @p2, @p3, @p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void pctClear_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from kisiler where ID=" +txtID.Text,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehberden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update kisiler set Ad=@p1, Soyad=@p2, Telefon=@p3, Mail=@p4 where ID=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Bilgileri Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }
    }
}
