namespace HarryPotter;

public class UnicornWand : Wand
{
    public UnicornWand() : base("UnicornWand", "This is a UnicornWand, it does UnicornWand-things.", 40,"UnicornWand")
    {
    }
    public void PrintUnicornWand()
    {
        Console.WriteLine($"PrintUnicornWand()");
    }
}