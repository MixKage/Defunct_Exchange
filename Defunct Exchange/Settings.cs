namespace Defunct_Exchange;

public static class Settings
{
    public static int CountCoins { private set; get; }
    public static int MaxRandom { private set; get; }
    public static int MinRandom { private set; get; }

    public static void SetSettings(int CountCoins, int MaxRandom, int MinRandom)
    {
        Settings.CountCoins = CountCoins;
        Settings.MaxRandom = MaxRandom;
        Settings.MinRandom = MinRandom;
    }
}
