using System.Diagnostics.CodeAnalysis;

namespace taskcem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 278;
            int sum = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                n /= 10;
            }
            Console.WriteLine("Reqemlerin cemi:" + sum);
        }
    }
}
