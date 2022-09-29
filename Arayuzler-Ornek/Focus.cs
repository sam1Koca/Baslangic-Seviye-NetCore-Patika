using System;

namespace Arayuzler_Ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }

        public int KacTekrlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}