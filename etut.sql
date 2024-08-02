create procedure Etut
as
select ID,DersAd, (Tbl_Ogretmen.ad + ' ' + Tbl_Ogretmen.soyad) as 'Öðretmen', (Tbl_Ogrenci.ad + ' ' + Tbl_Ogrenci.Soyad) as 'Öðrenci', Tarih, Saat, Durum From Tbl_Etut
inner join Tbl_Dersler on Tbl_Etut.DersID=Tbl_Dersler.DersID
inner join Tbl_Ogretmen on Tbl_Etut.OgretmenID=Tbl_Ogretmen.OgrtID
inner join Tbl_Ogrenci on Tbl_Ogrenci.OgrID=Tbl_Etut.OgrenciID