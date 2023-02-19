namespace Task_5._3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            Console.WriteLine(arr[0]);

            BigDataOperation(arr);

            Console.WriteLine(arr[0]);
        }
        static void BigDataOperation(in int[] arr)
        // при получении параметра с int[] arr - получаем данные по ссылке, данные изменятся
        // при получении параметра с in int[] arr - получаем данные по ссылке, данные изменятся
        {
            arr[0] = 4;
        }
        /*
         * По значению передаются параметры int, double, boo
         * По ссылке передаются параметры int[]
         */
    }
}