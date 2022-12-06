using Defunct_Exchange;

Console.WriteLine("Start Game");
Settings.SetSettings(3, 5, -5);
Exchange.GenerateCoins(true);
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"День {i + 1}");
    Exchange.UpdateDay();
    Exchange.PrintAllInfo();
}
