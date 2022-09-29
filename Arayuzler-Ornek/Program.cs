using System;

namespace Arayuzler_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString()); // Enum bir değeri string olarak bas ekrana.
            Console.WriteLine(focus.KacTekrlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());


            Astra astra = new Astra();
            Console.WriteLine(astra.HangiMarkaninAraci().ToString());
            Console.WriteLine(astra.KacTekrlektenOlusur().ToString());
            Console.WriteLine(astra.StandartRengiNe().ToString());

        }
    }
}
