namespace taskfaktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin:");
            int n = Convert.ToInt32(Console.ReadLine());
            long faktorial = 1;
            for (int i = 1; i<= n; i++)
            {
                faktorial *= i;
            }
            Console.WriteLine(faktorial);
        }
    }
}
