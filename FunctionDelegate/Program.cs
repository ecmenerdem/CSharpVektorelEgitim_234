using System.Security.Cryptography.X509Certificates;

namespace FunctionDelegate
{
    internal class Program
    {
        //Function Delegate ler geriye dönüş tipi olan metotları temsil eder.
        static void Main(string[] args)
        {
            //Parametresiz Func Delegate

            Func<int> getNumber = () => 50;

            Console.WriteLine(getNumber());


            //Parametreli Fun Delegate

            Func<int, int, int> Sum = (a, b) => a + b;
            Console.WriteLine(Sum(3,6));

            Func<string, string> SayMessage=(string s) => $"Hello {s}";
            Console.WriteLine(SayMessage("C#"));

        }
    }
}
