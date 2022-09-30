using System;

namespace Abstract_Classes
{
    public class A6_Sedan : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Audi;
        }

        public int KacTekrlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Siyah;
        }
    }
}