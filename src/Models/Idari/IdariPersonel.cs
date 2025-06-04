using BIL2012_homework.Interfaces;

namespace BIL2012_homework.Models.Idari
{
    public abstract class IdariPersonel : Personel, IZamYapilabilir
    {
        public decimal SabitUcret { get; set; }

        public virtual void ZamYap(decimal oran, decimal dersSaatiOran = 0)
        {
            SabitUcret += SabitUcret * oran;
        }
    }
}