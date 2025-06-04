using System;

namespace BIL2012_homework.Models.Akademik
{
    public class DrOgrUyesi : AkademikPersonel
    {
        public override string Unvan => "Dr. Öğretim Üyesi";

        public DrOgrUyesi(string ad, string soyad, int dersSaati)
        {
            Ad = ad;
            Soyad = soyad;
            SabitUcret = 130_000;
            DersSaatiUcreti = 1_000;
            DersSaati = dersSaati;
        }

        public override decimal MaasHesapla()
        {
            return SabitUcret + (DersSaati * DersSaatiUcreti);
        }
    }
}