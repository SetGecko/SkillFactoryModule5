using System.Security.Cryptography.X509Certificates;

namespace Task_5._4._3
{
    internal class Program
    {
        int val = 8;
        static void Main(string[] args)
        {
            int val = 10;
            Doubled(ref val);
            Console.WriteLine(val);
            Console.ReadKey();
        }

        static void Doubled(ref int val)
        {
            val = val * 2;
        }
    }
}