using System;

namespace Hazir_Metotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string ornek = "Hoşgeldiniz! Dersimiz C#";
            string ornek2 = "C#";

            //Lenght - String bir ifadenin uzunluğuna bakmak için kullanılır.
            Console.WriteLine(ornek.Length);


            // ToUpper | ToLower - String ifadede ki karekterlerin tamamını büyük yapar | İfadelerin Hepsini Küçük yapar.
            Console.WriteLine(ornek.ToUpper());
            Console.WriteLine(ornek.ToLower());


            //Concat - Verilen String İfadeleri Birleştirir [İki Tane Paremetre Alır]
            Console.WriteLine(String.Concat(ornek, " Başlaylımm..!"));


            //Compare, CompareTo - İlk verilen değişkenin karekter sayısı, ikinci değişkenin karekter sayısından büyükse 1,eşitse 0, küçükde -1 döner
            Console.WriteLine(ornek.CompareTo(ornek2));
            Console.WriteLine(String.Compare(ornek,ornek2,true)); // true dersem büyük-küçük harf duyarlıdır |false dersem dyarlı değildir
            Console.WriteLine(String.Compare(ornek,ornek2,false));


            //Contains - Bu dğişkenin içinde bu değişken varmı gibi kontrolleri yapmak için kullanırı.
            Console.WriteLine(ornek.Contains(ornek2)); // Eğer bulursa true değeri döner

            Console.WriteLine(ornek.EndsWith("Dersimiz C#")); // Bu değişkende ki ifade verdiğim string değerle bitiyor mu? [false-true]
            Console.WriteLine(ornek.StartsWith("Hoşgeldiniz!")); // Verdiğim ifade ile başlıyormu.. [false-true] 


            //IndexOf
            Console.WriteLine(ornek.IndexOf("C#")); // Değişken içinde verdiğim değeri arar. Bulduğunda bu değerin index numarasını döner. Bulamazsa -1 döner =>True
            Console.WriteLine(ornek.IndexOf("C#Merhaba")); // => false
            Console.WriteLine(ornek.LastIndexOf("i")); // Bu harfin kaçıncı indexte olduğunu söyler.


            //Insert
            Console.WriteLine(ornek.Insert(0,"Hello!")); // 0'ıncı indexten başlar ve string değere verdiğim ifadeyi ekler.


            //PadLeft, PadRight;
            Console.WriteLine(ornek + ornek2.PadLeft(30)); // ornek2'nin soluna 30'a tamamlayacak şekilde boşluk ekler.
            Console.WriteLine(ornek + ornek2.PadLeft(30,'-'));
            Console.WriteLine(ornek.PadRight(50) + ornek2);
            Console.WriteLine(ornek.PadRight(50, '-') + ornek2);



            // Remove
            Console.WriteLine(ornek.Remove(10)); // start indexi verirsem sadece oradan başlar ve sonuna kadar siler. -sadece 10. inndexen öncekini getirir.
            Console.WriteLine(ornek.Remove(5,3)); // 5. Karekterden başla ve 3 kareketer sil
            Console.WriteLine(ornek.Remove(0,1));


            //Replace
            Console.WriteLine(ornek.Replace("C#", "CSharp")); //İçindeki C# ile benim verdiğim CSharp'ı değiştir dedim. 
            Console.WriteLine(ornek.Replace(" ","*")); // Boşlukları * ile değiştir.


            //Split
            Console.WriteLine(ornek.Split(" ")[1]); // Boşluklara göre parçala ve bana birinci index değerini getir.
             

            //Substring
            Console.WriteLine(ornek.Substring(4)); // 4. indexten başla ve gerisini getir.
            Console.WriteLine(ornek.Substring(3,8)); // 3. indexten başla ve 8. indexe kadar getir.






        }
    }
}
