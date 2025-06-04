using System;

namespace BIL2012_homework.Models.Akademik
{
    public class Professor : AkademikPersonel
    {
        public override string Unvan => "Profesör";

        public Professor(string ad, string soyad, int dersSaati)
        {
            Ad = ad;
            Soyad = soyad;
            SabitUcret = 200_000;
            DersSaatiUcreti = 3_000;
            DersSaati = dersSaati;
        }

        public override decimal MaasHesapla()
        {
            return SabitUcret + (DersSaati * DersSaatiUcreti);
        }
    }
}