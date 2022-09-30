using System;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            New_Astra new_Astra = new New_Astra();

            Console.WriteLine(new_Astra.HangiMarkaninAraci().ToString());
            Console.WriteLine(new_Astra.KacTekerlektenOlusur().ToString());
            Console.WriteLine(new_Astra.StandartRengiNe().ToString());


            NewFocus newFocus = new NewFocus();

            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());

            
        }
    }
}
