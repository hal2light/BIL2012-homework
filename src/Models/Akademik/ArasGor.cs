using System;

namespace BIL2012_homework.Models.Akademik
{
    public class ArasGor : AkademikPersonel
    {
        public override string Unvan => "Araştırma Görevlisi";

        public ArasGor(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            SabitUcret = 100_000;
            DersSaatiUcreti = 0;
            DersSaati = 0;
        }

        public override decimal MaasHesapla()
        {
            return SabitUcret;
        }
    }
}