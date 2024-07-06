namespace Delegate
{
    public class Program
    {
       public delegate void MyDelegate(string message);

       public static void Main(string[] args)
        {
            MyDelegate myDelegate = MyMethod;
            CallMethod(myDelegate);

        }

        public static void MyMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void CallMethod(MyDelegate myDelegate) {

            myDelegate("Merhaba");
        
        }
    }
}
