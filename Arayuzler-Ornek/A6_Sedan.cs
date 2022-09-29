using System;

namespace Arayuzler_Ornek
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