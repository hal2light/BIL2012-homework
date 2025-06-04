using System;

namespace BIL2012_homework.Models
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public abstract string Unvan { get; }
        public abstract decimal MaasHesapla();
    }
}