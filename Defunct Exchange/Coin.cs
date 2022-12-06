namespace Defunct_Exchange;

public class Coin
{
    public Coin(string name, int value)
    {
        Name = name;
        Value = value;
    }
    public string Name { private set; get; }
    public int Value { set; get; }
}
