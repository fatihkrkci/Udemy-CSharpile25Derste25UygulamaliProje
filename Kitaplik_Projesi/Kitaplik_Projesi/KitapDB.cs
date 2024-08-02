using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Kitaplik_Projesi
{
    public class KitapDB
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Projects\udemy\murat_yucedag\C#ile25Derste25UygulamaliProje\Kitaplik2.accdb");

        public List<Kitap> kitapListesi()
        {
            List<Kitap> ktp = new List<Kitap>();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitaplar", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt16(dr[0].ToString());
                k.Ad = dr[1].ToString();
                k.Yazar = dr[2].ToString();

                ktp.Add(k);
            }
            baglanti.Close();
            return ktp;
        }

        public void KitapEkle(Kitap kt)
        {
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("insert into kitaplar (kitapad, yazar) values (@p1, @p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.Ad);
            komut.Parameters.AddWithValue("@p2", kt.Yazar);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
