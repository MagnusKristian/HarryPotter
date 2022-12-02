namespace HarryPotter;

public  class PhoenixWand: Wand
{
    public int Damage { get; set; }
    public PhoenixWand() : base("PhoenixWand", "This is a PhoenixWand, it does PhoenixWand-things.", 30, "PhoenixWand")
    {
        Damage = 30;
    }
    public void PrintPhoenix()
    {
        Console.WriteLine($"PrintPhoenix()");
    }
}