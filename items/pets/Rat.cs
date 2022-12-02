namespace HarryPotter;

public class Rat: Pet
{
    public new string Name { get; set; }
    public Rat(string name = "Rat", string description = "This is a Rat, it does Rat-things") : base(name, description, "Owl")
    {
        Name = name;
    }
}