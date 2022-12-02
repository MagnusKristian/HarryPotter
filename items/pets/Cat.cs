namespace HarryPotter;

public class Cat : Pet
{
    public new string Name { get; set; }
    public Cat(string name = "Cat", string description = "This is a Cat, it does Cat-things") : base(name, description, "Cat",222)
    {
        Name = name;
    }
}