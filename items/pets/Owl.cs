namespace HarryPotter;

public class Owl : Pet
{
    public new string Name { get; set; }
    public Owl(string name = "Owl", string description = "This is an Owl, it does Owl-things"):base(name,description,"Owl")
    {
        Name = name;
    }
    public void SendLetter()
    {
        Console.WriteLine("Error trying to send letter.");
    }
}