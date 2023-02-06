internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        int x = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Введите столбец: ");
        int y = Convert.ToInt32(Console.ReadLine()) - 1;
        int n = 5;
        int m = 7;
        Random random = new Random();
        int[,] arr = new int[n, m];
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = random.Next(10, 99);
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
        }
        if (x < 0 | x > arr.GetLength(0) - 1 | y < 0 | y > arr.GetLength(1) - 1)
        {
            Console.WriteLine("Такого элемента нет!  ");
        }
        else
        {
            Console.WriteLine("Значение элемента : {0}", arr[x, y]);
        }
        Console.ReadLine();
    }
}