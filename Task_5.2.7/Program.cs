namespace Task_5._2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Алексей", 35);

            Console.WriteLine("Моё имя {0}", name);
            Console.WriteLine("Мой возраст {0}", age);

            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            var favcolor = new string[3];

            for (int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i] = ShowColor(name, age);
            }

            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolor)
            {
                Console.WriteLine(color);
            }

            ShowColors(name, favcolor);

            Console.ReadKey();

        }

        static string ShowColor(string username, int userage, params string[] favcolor)
        {
            Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }

        static void ShowColors(string username = "Жужа", params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}