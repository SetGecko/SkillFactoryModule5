namespace Task_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myAge = 35;
            Console.WriteLine("Мой возраст = {0}", myAge);

            ChangeAge(myAge);

            Console.WriteLine("Мой возраст после использования метода = {0}", myAge);
        }

        static void ChangeAge(int age)
        {
            Console.WriteLine("Введите ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
}