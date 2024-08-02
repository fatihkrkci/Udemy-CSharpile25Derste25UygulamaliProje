using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KitapDB dbSinif = new KitapDB();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbSinif.kitapListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap ktpsinif = new Kitap();

            ktpsinif.Ad = textBox1.Text;
            ktpsinif.Yazar = textBox2.Text;
            dbSinif.KitapEkle(ktpsinif);
            MessageBox.Show("Kitap Eklendi");
        }
    }
}
