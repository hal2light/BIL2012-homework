using System;
using BIL2012_homework.Interfaces;

namespace BIL2012_homework.Models.Akademik
{
    public abstract class AkademikPersonel : Personel, IZamYapilabilir
    {
        public int DersSaati { get; set; }
        public decimal SabitUcret { get; set; }
        public decimal DersSaatiUcreti { get; set; }

        public virtual void ZamYap(decimal oran, decimal dersSaatiOran = 0)
        {
            SabitUcret += SabitUcret * oran;
            DersSaatiUcreti += DersSaatiUcreti * dersSaatiOran;
        }
    }
}