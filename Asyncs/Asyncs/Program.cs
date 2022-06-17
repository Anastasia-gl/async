namespace Asyncs
{
    class Program
    {
        public static void Main()
        {
            Class1 class1 = new Class1();
            class1.ConctAsync().GetAwaiter().GetResult();
        }
    }
}