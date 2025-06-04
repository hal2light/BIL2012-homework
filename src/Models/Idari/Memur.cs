using System;

namespace BIL2012_homework.Models.Idari
{
    public class Memur : IdariPersonel
    {
        public override string Unvan => "Memur";

        public Memur(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            SabitUcret = 90_000;
        }

        public override decimal MaasHesapla()
        {
            return SabitUcret;
        }
    }
}