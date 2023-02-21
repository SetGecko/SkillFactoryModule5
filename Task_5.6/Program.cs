using System.Text.RegularExpressions;

namespace Task_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = NewUser();
            ShowUser(user);
        }

        static (string FirstName, string LastName, int Age, string[] PetsNames, string[] FavColors) NewUser()
        {
            (string FirstName, string LastName, int Age, string[] PetsNames, string[] FavColors) User;

            string pattern = "[0-9!@#$%^&*()_+-={}:;<>?/|,.~`]";
            var regex = new Regex(pattern);

            #region First name

            string firstname;

            do
            {
                Console.WriteLine("Введите ваше имя: ");
                firstname = Console.ReadLine();
                if (firstname.Length > 2)
                    if (!regex.IsMatch(firstname))
                    {
                        break;
                    }
                Console.WriteLine("Ввведите правильно ваше имя!");
            } while (true);

            User.FirstName = firstname;

            #endregion

            #region Last name

            string lastname;

            do
            {
                Console.WriteLine("Введите вашу фамилию: ");
                lastname = Console.ReadLine();
                if (lastname.Length > 2)
                    if (!regex.IsMatch(lastname))
                    {
                        break;
                    }
                Console.WriteLine("Ввведите правильно вашу фамилию!");
            } while (true);

            User.LastName = lastname;

            #endregion

            #region Age

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите ваш возраст ");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));

            User.Age = intage;

            #endregion

            #region Pets

            string havepets;
            string pets;
            int intpets;

            while (true)
            {
                Console.WriteLine("У вас есть животные? Введите Да или Нет.");
                havepets = Console.ReadLine();

                if (havepets.ToLower() == "да")
                {
                    do
                    {
                        Console.WriteLine("Сколько у вас животных?");
                        pets = Console.ReadLine();
                    } while (CheckNum(pets, out intpets));

                    User.PetsNames = PetsNames(intpets);
                    break;
                }
                else if (havepets.ToLower() == "нет")
                {
                    User.PetsNames = new string[0];
                    break;
                }
            }

            #endregion

            #region Colors

            string colors;
            int intcolors;

            do
            {
                Console.WriteLine("Сколько у вас любимых цветов? ");
                colors = Console.ReadLine();
            } while (CheckNum(colors, out intcolors));

            User.FavColors = Colors(intcolors);

            #endregion

            return User;
        }

        static void ShowUser((string FirstName, string LastName, int Age, string[] PetsName, string[] Favcolors) user)
        {
            Console.WriteLine("\n\nВы ввели данные ");
            Console.WriteLine("\nИмя: {0} \nФамилия: {1} \nВозраст: {2}", user.FirstName, user.LastName, user.Age);

            Console.WriteLine("\nИмя вашего питомца:");
            for (int i = 0; i < user.PetsName.Length; i++)
            {
                Console.WriteLine(user.PetsName[i]);
            }

            Console.WriteLine("\nВаш любимый цвет: ");
            for (int i = 0; i < user.Favcolors.Length; i++)
            {
                Console.WriteLine(user.Favcolors[i]);
            }
        }

        static bool CheckNum(string num, out int corrnumber)
        {
            if (int.TryParse(num, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            Console.WriteLine("Введите больше 0!");
            corrnumber = 0;
            return true;
        }

        static string[] PetsNames(int num)
        {
            string[] names = new string[num];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Введите имя для {0} питомца: ", i + 1);
                names[i] = Console.ReadLine();
            }

            return names;
        }

        static string[] Colors(int num)
        {
            string[] colors = new string[num];

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Введите название {0} цвета: ", i + 1);
                colors[i] = Console.ReadLine();
            }

            return colors;
        }
    }
}