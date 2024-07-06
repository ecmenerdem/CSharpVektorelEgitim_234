namespace ValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;


            Console.WriteLine("Değiştirilmeden Önceki Hali: "+ sayi);

            changeValue(sayi);

            Console.WriteLine("Değiştirildikten Sonraki Hali: " + sayi);

            static void changeValue(int sayi)
            {
                sayi = 200;

                Console.WriteLine("Methoddaki Sayı:"+ sayi);
            }
        }

        
    }

   
}
