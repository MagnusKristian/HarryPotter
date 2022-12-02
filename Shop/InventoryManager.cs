namespace HarryPotter;

public class InventoryManager
{
    public List<TrollWand> AddTrollWand(int amount)
    {
        List<TrollWand> TrollWands = new List<TrollWand>();
        for (int i = 0; i < amount; i++)
        {
            TrollWands.Add(new TrollWand());
        }
        return TrollWands;
    }

    public void AddTrollWandsToList(List<TrollWand> TrollWandList, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            TrollWandList.Add(new TrollWand());
        }
    }
    public void AddItemToList(string item, int amount, List<Item> list)
    {
        Item newItem = TypeOfItem(item);
        if (newItem == null)
        {
            Console.WriteLine("Error adding item to list.");
            Console.ReadLine();
            return;
        }
        for (int i = 0; i < amount; i++)
        {
            list.Add(newItem);
        }
    }

    public Item TypeOfItem(string item)
    {
        Item newItem = null;
        switch (item)
        {
            case "TrollWand":
                newItem = new TrollWand();
                break;
            case "PhoenixWand":
                newItem = new PhoenixWand();
                break;
            case "UnicornWand":
                newItem = new UnicornWand();
                break;

            case "Owl":
                newItem = new Owl();
                break;
            case "Rat":
                newItem = new Cat();
                break;
            case "Cat":
                newItem = new Rat();
                break;
            default:
                break;
        }

        return newItem;
    }
}