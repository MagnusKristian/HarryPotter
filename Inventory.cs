namespace HarryPotter;

public class Inventory
{
    public List<Wand> Wands { get; set; }
    public List<Pet> Pets { get; set; }
    public List<Letter> Letters { get; set; }

    public Inventory()
    {
        Wands = new List<Wand>();
        Pets = new List<Pet>();
        Letters = new List<Letter>();
    }
}