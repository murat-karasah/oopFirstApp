using System;
using System.Collections.Generic;
using System.Text;

namespace oopFirstApp
{
    class Arac
    {

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
        public string aracMarka, aracModel,aracYakitTipi,aracVitesTipi;
        public int aracYil, aracKm;
        public decimal aracAlisFiyat, aracSatisFiyat, aracMaxIndirim, fiyat, fiyatAta;
        public Arac()
        {
            aracMarka = "BMW";    
        }
        public Arac(string _aracMarka, string _aracModel)
        {
            aracMarka = _aracMarka;
            aracModel = _aracModel;
        }
        public Arac(string _aracMarka, string _aracModel, int _aracYil)
        {
            aracMarka = _aracMarka;
            aracModel = _aracModel;
            _aracYil = _aracYil;
        }

        public Arac(string _aracMarka, string _aracModel, int _aracYil, int _aracKm)
        {
            aracMarka = _aracMarka;
            aracModel = _aracModel;
            aracYil = _aracYil;
            aracKm = _aracKm;
        }

        public void ekranayazdir()
        {
            Console.WriteLine($"{aracMarka}, {aracModel},{aracYil},{aracKm}");
        }
        public void indirim(decimal _fiyat)
        {
            decimal fiyathesap = (aracSatisFiyat - aracMaxIndirim);
            if (_fiyat < fiyathesap)
            {
                Console.WriteLine("Geçersiz Bir Fiyat");
            }
            else
            {
                fiyat = _fiyat;
            }
        }
    }
}
