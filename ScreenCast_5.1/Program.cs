namespace ScreenCast_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res2 = new int[5];
            res2 = GetArrayFromConsole();
            foreach(var el in res2) 
            {
                Console.WriteLine(el);
            }

        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}