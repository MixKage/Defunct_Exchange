namespace Defunct_Exchange;

public static class Exchange
{
    public static List<Coin> Coins = new List<Coin>();

    public static void GenerateCoins(bool debugMode = false)
    {
        for (int i = 0; i < Settings.CountCoins; i++)
        {
            Coins.Add(new Coin(i.ToString(), 1));
        }
        if(debugMode)
            Console.WriteLine($"Монеты сгенерированы в количестве ({Settings.CountCoins}) шт.");
    }
    
    public static void UpdateDay(bool debugMode = false)
    {
        Random random = new Random();
        foreach (Coin coin in Coins)
        {
            coin.Value += random.Next(Settings.MinRandom, Settings.MaxRandom);;
        }
        if (debugMode)
            Console.WriteLine("День обновлён");
    }

    public static void PrintAllInfo()
    {
        foreach (Coin coin in Coins)
        {
            Console.WriteLine(coin.Name + " : " + coin.Value);
        }
    }
}
