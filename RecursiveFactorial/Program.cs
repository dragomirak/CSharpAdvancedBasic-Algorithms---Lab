namespace RecursiveFactorial;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        long fact = Factorial(n);
        Console.WriteLine(fact);
    }

    public static long Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}