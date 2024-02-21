namespace SumOfCoins;

public class Program
{
    static void Main()
    {
        int[] coins = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int desiredSum = int.Parse(Console.ReadLine());
        int currentSum = 0;

        int[] sortedCoins = coins.OrderByDescending(c => c).ToArray();
        Dictionary<int, int> money = new Dictionary<int, int>();

        while (currentSum < desiredSum)
        {
            if (desiredSum - currentSum < sortedCoins[sortedCoins.Length - 1])
            {
                Console.WriteLine("Error");
                return;
            }

            for (int i = 0; i < sortedCoins.Length; i++)
            {
                if (desiredSum - currentSum >= sortedCoins[i])
                {
                    currentSum += sortedCoins[i];

                }
                else
                {
                    continue;
                }

                if (!money.ContainsKey(sortedCoins[i]))
                {
                    money[sortedCoins[i]] = 0;
                }

                money[sortedCoins[i]]++;
                i--;
            }
        }

        int coinsCount = money.Sum(c => c.Value);
        Console.WriteLine($"Number of coins to take: {coinsCount}");

        foreach (var coin in money)
        {
            Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
        }
    }
}