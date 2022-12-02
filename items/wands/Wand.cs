namespace HarryPotter;

public class Wand :Item
{
    //public string Name { get; set; }
    //public string Description { get; set; }
    public int Damage { get; set; }

    public Wand(string name, string description, int damage,string type):base(name,description,type)
    {
        //Name = name;
        //Description = description;
        Damage = damage;
    }

    public void PrintWand()
    {
        Console.WriteLine($"PrintWand() in wand . Type for this: {Type}");
    }
}