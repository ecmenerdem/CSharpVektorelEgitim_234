namespace CreateFileAndWrite
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<User> userList = new()
            {
                new()
                {
                    Username="ahmet123",
                    Password="123",
                    FullName="Ahmet Ahmet"
                }, new()
                {
                    Username="mehmet1234",
                    Password="1234",
                    FullName="Mehmet Mehmet"
                }, new()
                {
                    Username="ali12345",
                    Password="12345",
                    FullName="Ali Ali"
                }, new()
                {
                    Username="veli123456",
                    Password="123456",
                    FullName="Veli Veli"
                }

            };

            User user = new()
            {
                Username = "ayse1234",
                Password = "1234",
                FullName = "Ayşe Ayşe"
            };

            userList.Add(user);

            User user1 = new();
            user1.Username = "fatma1234";  
            user1.Password = "1234";
            user1.FullName = "Fatma Fatma";

            userList.Add(user1);


            //kullanici adı ve şifre girildikten sonra ilk olarak kullanıcı adı var mı diye sorgulanacak varsa şifre kontrolü yapılacak. iki doğrulamadanda geçerse "Ad" Değişkenine login olan kullanıcın Adı yazılıp sisteme giriş yapılması sağlanacak

            // Login  isimli bir metot oluşturulup dönüşü login olan kullanıcın adı olan metodun üzerinden sağlanacak.

            //Login olamayan kullanıcyada kullanıcı adı veya şifreniz yanlış uyarısı verecek.

            //Linq kullanılacak.

            string Ad = "";
            Console.WriteLine("Kullanici Adınızı Yaziniz");
            string kullaniciAd = Console.ReadLine();
            Console.WriteLine("Şifre Yazınız");
            string sifre = Console.ReadLine();
            User user2 = new User();


            var extUser = user2.Login(userList, kullaniciAd, sifre);



            if (/*extUser !=null*/ /*extUser is not null*/  extUser is {} )
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Lütfen Bir Sayi Giriniz");

                        int sayi = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Lütfen Başka Bir Sayi Giriniz");

                        int sayi1 = Convert.ToInt32(Console.ReadLine());

                        if (sayi1 == 0)
                        {
                            throw new DivideByZeroException("0 a Bölünme Hatası");
                        }
                        else if (sayi1 < 0)
                        {
                            throw new Exception("Girilen İkinci Sayı Negatifdir.");
                        }

                        int sonuc = sayi / sayi1;

                        Console.WriteLine(sonuc);

                    }
                    catch (Exception ex)
                    {
                        if (ex.GetType() == typeof(DivideByZeroException))
                        {
                            string path = @"C:\Example\" + Ad + "_" + Guid.NewGuid() + ".txt";
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                sw.WriteLine(ex);
                            }
                        }

                        Console.WriteLine("Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz.");

                    }
                }
            }

            else
            {
                Console.WriteLine("Kullanıcı Adı Veya Şifreniz Yanlış");
            }
        }

        
    }

   public class User()
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public User Login(List<User> userList, string kullaniciAdi, string sifre)
        {
            var user = userList.Where(q => q.Username == kullaniciAdi && q.Password == sifre).FirstOrDefault();
            return user;
        }
    }
}
