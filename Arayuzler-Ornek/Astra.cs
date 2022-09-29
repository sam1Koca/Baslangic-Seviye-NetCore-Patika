using System;

namespace Arayuzler_Ornek
{
    public class Astra : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Opel;
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