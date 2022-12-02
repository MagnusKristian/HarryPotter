namespace HarryPotter;

public abstract class Item
{
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int CashValue { get; set; }

    //public string SubType { get; set; } ??

    public Item(string name,string description, string type/*, string subType*/, int cashValue = 123)
    {
        Guid = Guid.NewGuid();
        Name = name;
        Description = description;
        Type = type;
        CashValue = cashValue;

        //SubType = subType;
    }
}