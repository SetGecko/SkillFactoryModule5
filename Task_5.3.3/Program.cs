namespace Task_5._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Алексей";
            Console.WriteLine(someName);

            GetName(ref someName);

            Console.WriteLine(someName);

            //Финальное значение перемнной изменилось при передаче данных ПО ССЫЛКЕ
        }

        static void GetName( ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }
    }
}