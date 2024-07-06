namespace ActionDelegate
{
    internal class Program
    {
        //Action Delegate ler geriye dönüş tipi olmayan metotları temsil eder.
        static void Main(string[] args)
        {
            Action action = () => Console.WriteLine("Merhaba Arkadaşlar");
            action();

            Action<int, int> Sum = (a, b) => Console.WriteLine(a + b);
            Sum(8, 6);
           
        }
    }
}
