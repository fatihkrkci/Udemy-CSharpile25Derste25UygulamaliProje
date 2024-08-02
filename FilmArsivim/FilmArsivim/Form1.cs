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

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FatihKurekci\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True;TrustServerCertificate=True");
        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Filmler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Filmler (Ad, Kategori, Link) values (@p1, @p2, @p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Listenize Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Fatih Kürekçi tarafından 10 Temmuz 2024'te kodlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
