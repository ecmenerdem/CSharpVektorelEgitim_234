namespace Crypto
{
   internal class Program
    {
        static void Main(string[] args)
        {
            string ifade = "";

            Console.WriteLine("Kripto Uygulamamıza Hoş Geldiniz");
            while (true)
            {
                Console.WriteLine("İşlem Seçiniz:");

                Console.WriteLine("1- Şifrele");

                Console.WriteLine("2- Şifre Çöz");

                var cevap = Console.ReadLine();

                if (Convert.ToInt32(cevap) == 1)
                {
                    Console.Write("Şifrelemek İstediğiniz İfadeyi Giriniz: ");
                    ifade = Console.ReadLine();
                    Console.WriteLine(ifade.ToEncrypt());
                    
                    Console.WriteLine("Şifreyi Kaydetmek İstiyor Musunuz?");

                    var kayitIstek= Console.ReadLine();

                    if (kayitIstek.Equals("e",StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Hangi İsimle Kaydetmek İstiyorsunuz: ");
                        string kayitAdi = Console.ReadLine();

                       var insertRow = kayitAdi + ": " + ifade.ToEncrypt();

                        string path = @"C:\Password\password.txt";

                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(insertRow);
                            
                        }
                        Console.WriteLine("İşlem Yapıldı");
                    }
                }
                else
                {
                    Console.Write("Çözmek İstediğiniz İfadeyi Giriniz: ");
                    ifade = Console.ReadLine();

                    Console.WriteLine(ifade.ToDecrypt());
                }
            }
            
        }
    }

   public static class Extentions
    {
      public static string ToEncrypt(this string ifade)
        {
            List<char> normList = new List<char>(){'a','b','c','ç','d','e','f','g','ğ','h','ı','i','j','k','l','m','n','o','ö','p','r','s','ş','t','u','ü','v','y','z',' '};
            List<char> mixList = new List<char>() { 't','m','h','b','k','f','g','i','e','ç','z','ş','p','s','r','u','ö','y','ğ','v','c','l','j','d','n','o','a','ı','ü','_'};

            string encryptIfade = "";

            for (int i = 0; i < ifade.Length; i++)
            {
                var position = normList.IndexOf(ifade[i]);
                encryptIfade += mixList[position];
            }

            return encryptIfade;
        }
       public static string ToDecrypt(this string ifade)
        {
            List<char> normList = new List<char>(){'a','b','c','ç','d','e','f','g','ğ','h','ı','i','j','k','l','m','n','o','ö','p','r','s','ş','t','u','ü','v','y','z',' '};
            List<char> mixList = new List<char>() { 't','m','h','b','k','f','g','i','e','ç','z','ş','p','s','r','u','ö','y','ğ','v','c','l','j','d','n','o','a','ı','ü','_'};

            string decryptIfade = "";

            for (int i = 0; i < ifade.Length; i++)
            {
                var position = mixList.IndexOf(ifade[i]);
                decryptIfade += normList[position];
            }

            return decryptIfade;
        }
    }
}
