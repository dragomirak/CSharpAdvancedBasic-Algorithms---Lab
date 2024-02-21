using System.Security.Cryptography.X509Certificates;

namespace RecursiveArraySum;

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int sum = Sum(numbers, 0);
        Console.WriteLine(sum);
    }

    public static int Sum(int[] arr, int currentIndex)
    {
        if (currentIndex == arr.Length - 1)
        {
            return arr[currentIndex];
        }

        return arr[currentIndex] + Sum(arr, currentIndex + 1);
    }
}