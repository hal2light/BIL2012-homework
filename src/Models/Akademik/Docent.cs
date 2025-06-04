using System;

namespace BIL2012_homework.Models.Akademik
{
    public class Docent : AkademikPersonel
    {
        public override string Unvan => "Doçent";

        public Docent(string ad, string soyad, int dersSaati)
        {
            Ad = ad;
            Soyad = soyad;
            SabitUcret = 160_000;
            DersSaatiUcreti = 2_000;
            DersSaati = dersSaati;
        }

        public override decimal MaasHesapla()
        {
            return SabitUcret + (DersSaati * DersSaatiUcreti);
        }
    }
}