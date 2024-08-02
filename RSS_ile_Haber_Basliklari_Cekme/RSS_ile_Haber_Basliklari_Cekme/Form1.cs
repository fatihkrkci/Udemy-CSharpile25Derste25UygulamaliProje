using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_ile_Haber_Basliklari_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add(xmlOku.ReadString());
                }
            }
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku2 = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/otomobilrss.xml");
            while (xmlOku2.Read())
            {
                if (xmlOku2.Name == "title")
                {
                    listBox1.Items.Add(xmlOku2.ReadString());
                }
            }
        }

        private void btnFotomac_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku3 = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");
            while (xmlOku3.Read())
            {
                if (xmlOku3.Name == "title")
                {
                    listBox1.Items.Add(xmlOku3.ReadString());
                }
            }
        }
    }
}
