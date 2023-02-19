namespace Screencast_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Алексей";
            Console.WriteLine(someName);

            GetName(someName);

            Console.WriteLine(someName);
        }

        static void GetName(string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }
    }
}