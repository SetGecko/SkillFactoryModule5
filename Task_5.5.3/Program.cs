namespace Task_5._5._3
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

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            int color = deep;
            while (color > 15)
                color -= 15;
            Console.BackgroundColor = (ConsoleColor)color;

            Console.WriteLine("..." + modif);

            Console.BackgroundColor = ConsoleColor.Black;

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}