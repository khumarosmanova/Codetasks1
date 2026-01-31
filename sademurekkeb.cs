namespace tasksade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil et:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (n <= 1)
            {
                Console.WriteLine("Ne sade, ne murekkeb");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i ==0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    Console.WriteLine("Sade ededdir");
                }
                else
                {
                    Console.WriteLine("Murekkeb ededdir");
                }
            }
        }
    }
}
