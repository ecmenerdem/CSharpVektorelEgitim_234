using System.ComponentModel;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string ad = "özgür şengül";

            string userName = ad.ToEnglishCharacters();

            // Console.WriteLine(userName.ToCharArray());

            var array = ad.ToCharArray(); 

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //foreach (int item in list)
            //{
            //    Extentions.IsEven(item);


            //    IsEven(item);

            //    if (item.IsEven())
            //    {

            //    }

            //}


            //var charArray =  StringToChar(ad);

            //foreach (var charItem in charArray)
            //{
            //    Console.WriteLine(charItem);
            //}

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8 };
        }


       

        public static List<char> StringToChar(string ifade)
        {
            List<char> chars = new();

            foreach (char c in ifade)
            {
                chars.Add(c);
            }
            
        return chars;
        }


      
    }

   public static class Extentions
    {
        public static bool IsEven(this int sayi)
        {
            if (sayi % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static string ToEnglishCharacters(this string ifade)
        {
            string newIfade = "";

            foreach (var item in ifade)
            {
                if (item.Equals('ç'))
                {
                    newIfade += "c";
                }
                else if (item.Equals('ı'))
                {
                    newIfade += "i";
                }
                else if (item.Equals('ğ'))
                {
                    newIfade += "g";
                }
                else if (item.Equals('ö'))
                {
                    newIfade += "o";
                }
                else if (item.Equals('ü'))
                {
                    newIfade += "u";
                }
                else if (item.Equals('ş'))
                {
                    newIfade += "s";
                }
                else if (item.Equals(' '))
                {
                    newIfade += "";
                }
                else
                {
                    newIfade += item;
                }
            }
            return newIfade;

           

        }

        /*
         
        - Metot Adı ToEncrypt

        - indexof
        - [a,b,c,ç,d,e,f,g...........," "] normal liste
        - [e,g,t,k,m,ö,y.............,"_"] karıştırılmış liste
        - ifade girildikten sonra normal listede bulunacak daha sonra karıştırılmış listedeki karşılığı bulunup kriptolanacak.

        - ekrana criptolu hali yazılacak
         
        -Tersini ToDecrypt isimli metotla yapınız.
         */

    }
}
