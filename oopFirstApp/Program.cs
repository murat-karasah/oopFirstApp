using System;

namespace oopFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////:Müşteri          -> T.C.,Ad,Soyad,Cinsiyet vb.
            ////Satış Temsilcisi  -> T.C.,Sicil Numarası,Ad,Soyad,Cinsiyet vb.
            ////Araç              -> Marka,Model,yıl,k.m.,yakıt tüketimi,vites tipi vb.
            ////Teklif            -> Teklif ID,fiyat,satıcı
            ////Sipariş           -> Sipariş No, teklif,fiyat
            ////Fatura            -> Fatura No,Teklif,müşteri...
            //Musteri M1 = new Musteri();
            //M1.tcKimlikNo = "10000000000";
            //M1.isim = "Murat";
            //M1.soyisim = "KARAŞAH";
            //M1.cinsiyet = 777100101;

            //Musteri M2 = M1;
            //M2.isim = "asd";
            //M1.tcKimlikNo = "12312";
            //M2 = null;
            //M1 = null;
            ////m2 ve m1 e sen artık o noktaya bakma dedim heap bölgede o noktayı tutan bir değer kalmadığında pointersız kalır ve ramden düşer. Garbage collector bunu alır ve siler.
            //string isim = M2.isim; //bunu çalıştırdığımda hata alırım.M2'nin müşteri nesnesi olduğunu biliyorum ama new'lenmediğim için buna ulaşamam.

            Musteri M1 = new Musteri("13123123","leyla");
            M1.musteriKontrol();

            /*
             Arac adında class oluştur
            marka,model,yıl,km,yakıttipi,vitestipi,alışfiyat,satisfiyat,maxindirim,fiyat

            arac class'ın 4 tane overload olacak 
            -var sayıla boş hali
            -marka, model
            -marka,model,yıl,
            -marka,model,yıl,km

            2 metot 
            -void bilgilerigörüntüle
            ekranda yazıdr
            -void fiyat ata(fiyat)
            fiyat değeri satis-indirimtutarı
            fiyat değeri kullanıcının girdiği fiyattan küçükse geçersiz fiyat desin değilse fiyatı güncelle



             */

            Arac A1 = new Arac("BMW", "3.20", 2019, 30000);
            A1.aracSatisFiyat = 50000;
            A1.aracMaxIndirim = 4000;
            A1.aracAlisFiyat = 42000;
            A1.ekranayazdir();
            A1.indirim(60000);


        }

     

    }
}
