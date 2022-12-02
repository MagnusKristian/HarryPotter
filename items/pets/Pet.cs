namespace HarryPotter;

public class Pet :Item
{
    public string TypeOfAnimal { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }


    public Pet(string name ,string description,string type):base(name, description, type)
    {
        Name = name;
        Description = description;
        TypeOfAnimal = type;
    }

}