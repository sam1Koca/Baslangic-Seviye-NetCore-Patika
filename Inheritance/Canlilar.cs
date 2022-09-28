using System;

namespace Inheritance
{
    public class Canlilar // sealed -> Bu sınıfı hiçbiri inherit alamaz. [Erişim belirteçinden sonra yazılarak kullanılır.]
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir...");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar...");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar...");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar Uyaranlara Tepki verir.");
        }
    }
}