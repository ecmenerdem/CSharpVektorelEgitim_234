namespace PassingString
{
    internal class Program
    {
        // string immutable bir tipdir.
        static void Main(string[] args)
        {
            string name = "veli";
            Console.WriteLine("Değiştirilmeden Önceki Hali: " + name);

            ChangeString(name);

            Console.WriteLine("Değiştirildikten Sonraki Hali: " + name);
        }

        static void ChangeString(string name)
        {
            name = "Ali";
        }
    }
}
