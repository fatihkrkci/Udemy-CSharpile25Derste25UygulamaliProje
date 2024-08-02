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

namespace Etut_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=EtutSistemi;Integrated Security=True;TrustServerCertificate=True");

        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "DersID";
            cmbDers.DisplayMember = "DersAd";
            cmbDers.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Ogretmen Where BransID=" + cmbDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbOgretmen.ValueMember = "OgrtID";
            cmbOgretmen.DisplayMember = "Ad";
            cmbOgretmen.DataSource = dt2;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Etut (DersID, OgretmenID, Tarih, Saat) values (@p1, @p2, @p3, @p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu");
        }

        void etutListesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_etut set ogrenciID=@p1, durum=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi");
        }
    }
}
