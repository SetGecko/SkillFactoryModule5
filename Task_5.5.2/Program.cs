namespace Task_5._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");

            var str = Console.ReadLine();

            Console.WriteLine("Напишите глубину эха");

            var deep = int.Parse(Console.ReadLine());

            for (int i = 0; i < deep; i++)
            {
                Echo(str, deep);
            }
        }

        static void Echo(string saidword, int deep)
        {
            var modif = saidword;

            Console.WriteLine(saidword);

            if (deep > 1)
            {
                Echo(saidword, deep - 1);
            }
        }
    }
}