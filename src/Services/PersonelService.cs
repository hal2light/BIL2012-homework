using System;
using System.Collections.Generic;
using System.Linq;
using BIL2012_homework.Models;
using BIL2012_homework.Models.Akademik;
using BIL2012_homework.Models.Idari;

namespace BIL2012_homework.Services
{
    public class PersonelService
    {
        private List<Personel> personelList;

        public PersonelService()
        {
            personelList = new List<Personel>();
        }

        public void AddPersonel(Personel personel)
        {
            personelList.Add(personel);
        }

        // Maaşları hesaplamak için sadece maaşları döndürmek yeterli
        public List<decimal> MaaslariHesapla()
        {
            return personelList.Select(p => p.MaasHesapla()).ToList();
        }

        // Zam uygulama (Haziran için özel oranlar)
        public void ZamUygula()
        {
            foreach (var personel in personelList)
            {
                if (personel is AkademikPersonel akademik)
                    akademik.ZamYap(0.20m, 0.50m); // %20 sabit, %50 ders saati
                else if (personel is IdariPersonel idari)
                    idari.ZamYap(0.30m); // %30 zam
            }
        }

        public List<Personel> ListAllPersonel()
        {
            return personelList;
        }

        public decimal ToplamMaasGideri()
        {
            return personelList.Sum(p => p.MaasHesapla());
        }
    }
}