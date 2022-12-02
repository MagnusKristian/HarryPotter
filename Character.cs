namespace HarryPotter;

public class Character
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Money { get; set; }
    public List<Item> Inventory { get; set; } //wand, owl, etc
    public Inventory Inventory2 { get; set; }
    //public List<Wand> Wands { get; set; }
    //public List<Pet> Pets { get; set; }
    public Item CurrentWand { get; set; }

    public string? House { get; set; } // huffelpuff, griffindor, slytherin, ravenclaw

    public Character(string name, string description/*="No description yet"*/, string house/* = "No House yet"*/)
    {
        Name = name;
        Description = description;
        Inventory2 = new Inventory();
        Inventory = new List<Item>();
        House = house;
        Money = 0;
    }

    public void AddInventoryItem(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine($"'{item.Name}' was added to '{Name}'s' inventory.");
    }

    public int GetMoneyAmount()
    {
        return Money;
    }
    public void WithdrawCash(int amount)
    {
        if (amount>Money)
        {
            Console.WriteLine($"Not enough money in {Name}'s wallet.");
            return;
        }
        Money -= amount;
        Console.WriteLine($"${amount} removed from {Name}'s wallet. new balance is: {Money}");

    }
    public void DepositCash(int amount)
    {
        Money += amount;
        Console.WriteLine($"${amount} added to {Name}'s wallet. new balance is: {Money}");
    }

    public void IntroduceCharacter()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"******************** Character info ********************");
        Console.WriteLine($"Hi. My name is {Name}. ");
        if (Description != null) { Console.WriteLine($"Description of me: {Description}. "); }
        if (House != null) { Console.WriteLine($"I am a member of {House}. "); }
        Console.WriteLine($"I have ${Money} in my account. ");
        if (Inventory.Count<1) { Console.WriteLine($"I Don't have anything in my inventory. "); }
        else
        {
            Console.WriteLine($"In my inventory, i have {Inventory.Count} items, which consists of: ");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"* {item.Name}");
            }
        }
        Console.WriteLine($"-------------------------------------------------------------");
    }
}