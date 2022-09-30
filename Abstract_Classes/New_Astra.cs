using System;

namespace Abstract_Classes
{
    public class New_Astra : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Opel;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}