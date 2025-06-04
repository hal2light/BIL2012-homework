using System;
using System.Collections.Generic;
using BIL2012_homework.Models.Akademik;
using BIL2012_homework.Models.Idari;
using BIL2012_homework.Models;

namespace BIL2012_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personel listesi
            List<Personel> personeller = new List<Personel>
            {
                new Professor("Onur", "Polat", 10),
                new Docent("Buse", "Kara", 8),
                new Docent("Gökhan", "Öztürk", 6),
                new DrOgrUyesi("Seda", "Aksoy", 5),
                new DrOgrUyesi("Deniz", "Yıldız", 7),
                new DrOgrUyesi("Can", "Aydın", 4),
                new ArasGor("Merve", "Kurt"),
                new ArasGor("Emre", "Aslan"),
                new Memur("Burak", "Güneş"),
                new Memur("Elif", "Demir"),
                new TeknikPersonel("Ayşe", "Çelik")
            };

            decimal toplamYillikGider = 0;

            for (int ay = 1; ay <= 12; ay++)
            {
                Console.WriteLine($"\n--- {ay}. Ay ---");
                decimal toplamAylikGider = 0;

                // Haziran ayında zam uygulama
                if (ay == 6)
                {
                    foreach (var p in personeller)
                    {
                        if (p is AkademikPersonel akademik)
                            akademik.ZamYap(0.20m, 0.50m); // %20 sabit, %50 ders saati
                        else if (p is IdariPersonel idari)
                            idari.ZamYap(0.30m); // %30 zam
                    }
                    Console.WriteLine("Haziran ayında zamlar uygulandı!");
                }

                // Maaşları hesapla ve yazdır
                foreach (var p in personeller)
                {
                    decimal maas = p.MaasHesapla();
                    toplamAylikGider += maas;
                    Console.WriteLine($"{p.Unvan} {p.Ad} {p.Soyad} - Maaş: {maas:N0} TL");
                }

                Console.WriteLine($"Aylık Toplam Personel Gideri: {toplamAylikGider:N0} TL");
                toplamYillikGider += toplamAylikGider;
            }

            Console.WriteLine($"\n12 Ay Sonunda Toplam Personel Gideri: {toplamYillikGider:N0} TL");
        }
    }
}