namespace PredicateDelegate
{
    internal class Program
    {
        //Predicate Delegateler belirli bir koşula göre true veya false dönen metotları temsil eder.
        static void Main(string[] args)
        {
            List<int> sayilar = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool isEven(int sayi)
            {
                //if (sayi %2==0)
                //{
                //    return true;
                //}
                //return false;
                
                return sayi % 2 == 0 ? true : false;
            };


            foreach (int sayi in sayilar)
            {
                if (isEven(sayi))
                {
                    Console.WriteLine(sayi);
                } 
            }


            Console.WriteLine("---------------------------------");

            Predicate<int> isEvenDelegate = (number) => number % 2 == 0;
            var evenNumbers= sayilar.FindAll(isEvenDelegate);
            evenNumbers.ForEach(Console.WriteLine);
        }
    }
}
