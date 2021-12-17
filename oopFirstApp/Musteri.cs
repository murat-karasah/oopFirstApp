using System;
using System.Collections.Generic;
using System.Text;

namespace oopFirstApp
{
    class Musteri
    {
        //:Müşteri          -> T.C.,Ad,Soyad,Cinsiyet vb.
        public string tcKimlikNo;
        public string isim;
        public string soyisim;
        public int cinsiyet; //777100101 erkek,777100102 kadın

            public Musteri()
        {
            //hiç dokunulmazsa varsayılan değeriyle çalışır
            tcKimlikNo = "11111111111"; // diğer halini ezdim. Bunu kullan dedim

        }
        
        public Musteri(string _tckimlikno)
        {
            tcKimlikNo = _tckimlikno;
        }
        public Musteri(string _tckimlikno,string _isim)
        {
            tcKimlikNo = _tckimlikno;
            isim = _isim;
        }
        public Musteri(string _tckimlikno, string _isim,string _soyisim)
        {
            tcKimlikNo = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;

        }

        public bool musteriKontrol()
        {
            bool kontrol = musteriKontrolDataBase(tcKimlikNo);
            return kontrol;
        }
        private bool musteriKontrolDataBase(string tc)
        {
            //db'de bu tc kimlik numarası var mı yok mu
            return true;
        }



    }
}
