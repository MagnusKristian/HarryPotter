namespace HarryPotter;

public class TrollWand : Wand
{
    public TrollWand() : base("TrollWand", "This is a TrollWand, it does TrollWand-things.", 50,"TrollWand" )
    {
       
    }
    public void PrintTrollWand()
    {
        Console.WriteLine($"PrintTrollWand()");
    }
}