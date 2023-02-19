namespace Task_5._4._4
{
    internal class Program
    {
        int val = 8;
        static void Main(string[] args)
        {
            int val = 9;
            {
                val++;
            }

            Console.WriteLine(val);
            Console.ReadKey();
        }
    }
}