using System;

namespace BIL2012_homework.Models.Idari
{
    public class TeknikPersonel : IdariPersonel
    {
        public override string Unvan => "Teknik Personel";

        public TeknikPersonel(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            SabitUcret = 96_000;
        }

        public override decimal MaasHesapla()
        {
            return SabitUcret;
        }
    }
}