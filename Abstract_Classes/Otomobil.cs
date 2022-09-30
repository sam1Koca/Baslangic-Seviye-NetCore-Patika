using System;

namespace Abstract_Classes
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4; // Bu metot ile kod tekrarından kurtuldum.
        }

        public virtual Renk StandartRengiNe()
        {
            return Renk.Siyah;
        }

        public abstract Marka HangiMarkaninAraci(); 
    }
}