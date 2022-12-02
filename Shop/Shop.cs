namespace HarryPotter;

public class Shop
{
    public InventoryManager InventoryManager = new InventoryManager();
    public int ShopBalance { get; set; } 
    //get rid  of wands or comment out.
    //public List<Wand> Wands { get; set; }
    //public List<Pet> Pets { get; set; }
    public int PhoenixWandPrice { get; set; }
    public int UnicornWandPrice { get; set; }
    public int TrollWandPrice { get; set; }
    public int OwlPrice { get; set; }
    public int CatPrice { get; set; }
    public int RatPrice { get; set; }

    public List<Item> Inventory { get; set; }
    //private List<List<List<Item>>> InventoryList { get; set; }
    private List<List<List<Item>>> MainInventoryList { get; set; }

    //public List<TrollWand> TrollWands { get; set; }

    public Shop()
    {
        ShopBalance = 10_000;
        PhoenixWandPrice = 500;
        UnicornWandPrice = 400;   
        TrollWandPrice = 300;
        OwlPrice = 500;
        CatPrice = 400;
        RatPrice = 300;
        Inventory = new List<Item>();
        
        AddInventory();
        MainInventoryList = GetInventoryLists(); //TODO: maybe this?
    }

    public void ShopMenu(Character curCharacter)
    {
        string choice = "";
        do
        {
            //List<List<List<Item>>> MainInventoryList = GetInventoryLists();
            MainInventoryList = GetInventoryLists();



            Console.WriteLine("\n ******************************");
            Console.WriteLine(" WELCOME TO THE MAGIC SHOP! ");
            Console.WriteLine("\n ******************************");
            Console.WriteLine("1. Buy Wand");
            Console.WriteLine("2. Buy Pet");
            Console.WriteLine("3. Sell Stuff");
            Console.WriteLine("4. OPTION 4");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("\n ******************************");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    //BuyWand(curCharacter, MainInventoryList);
                    //Console.WriteLine("trying to fix.");
                    //BuyItem(curCharacter, wands, 0/*0=wandsList*/);
                    BuyItem(curCharacter, MainInventoryList, 0/*0=wandsList*/);
                    Console.WriteLine("fixing this, maybe...");

                    break;
                case "2":
                    BuyItem(curCharacter, MainInventoryList, 1/*1=petsList*/);
                    Console.WriteLine("fixing this, maybe...");

                    break;
                case "3":
                    Console.WriteLine("-Not made yet.");
                    break;
                case "4":
                    Console.WriteLine("-Not made yet.");
                    break;
                case "5":
                    Console.WriteLine("Exiting now...");
                    return;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"Did not recognize '{choice}', try again.");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        } while (choice != "5");
    }

    public void AddInventory()
    {
        //adds items to a general inventory of all things.
        //"type of item/name","amount of items of that type to add", "which list/where to add it":
        
        //AddItemToInventory("type", 1); this?

        InventoryManager.AddItemToList("PhoenixWand", 1, Inventory);
        InventoryManager.AddItemToList("UnicornWand",2,Inventory);
        InventoryManager.AddItemToList("TrollWand", 3, Inventory);

        InventoryManager.AddItemToList("Owl", 1, Inventory);
        InventoryManager.AddItemToList("Cat", 2, Inventory);
        InventoryManager.AddItemToList("Rat", 3, Inventory);



        //InventoryManager.AddTrollWandsToList(TrollWands, 5);

    }
    public void AddItemToInventory(string type,int amount)
    {
        InventoryManager.AddItemToList(type, amount, Inventory);
    }

    public void UpdateInventory(Item item)
    {
        //foreach (var VARIABLE in Inventory)
        //{
            
        //}
        RemoveFromInventory(item);
    }
    public void RemoveFromInventory(Item item)
    {
        Inventory.Remove(item);
        Console.WriteLine($"'{item.Name}' Removed from shop inventory.\n(ID:'{item.Guid.ToString()})'");
    }

    public void BuyItem(Character curCharacter, List<List<List<Item>>> inventoryList,int itemTypeIndex)
    {
        //if (expr)
        //{
            
        //}


        //TODO: wtf am i even doing, i should probably document my thought process huh? :D
        //could this work?
        
        int index1 = 0;

        foreach (var ListOfList in inventoryList[itemTypeIndex])
        {
            if (ListOfList.Count >=1)
            {
                Console.WriteLine($"{index1 + 1}. = '{ListOfList[0].Name}'- {ListOfList[0].CashValue}$.-{ListOfList.Count} in stock.");
                index1++;
            }
        }
        Console.WriteLine($"4. To exit.");

        string choice1 = Console.ReadLine();

        for (int i = 0; i < index1; i++)
        {
            if (choice1 == i.ToString())
            {
                buy(curCharacter, inventoryList[itemTypeIndex][i-1][0].Name, inventoryList[itemTypeIndex][i-1][0].CashValue, inventoryList[itemTypeIndex][i-1]);
                //her er jeg...
            }
        }
        //public void buy(Character curCharacter,string itemName,int amount, List<Item> items)
        //TODO: MASSE BUGS HER. FML.
        if (choice1 == "4")
        {
            return;
        }


        //switch (choice1)
        //{
        //    case "1":
        //        buy(curCharacter, "PhoenixWand", 300, inventoryList[itemTypeIndex][0]);
        //        break;
        //    case "2":
        //        buy(curCharacter, "UnicornWand", 400, inventoryList[itemTypeIndex][1]);
        //        break;
        //    case "3":
        //        buy(curCharacter, "TrollWand", 500, inventoryList[itemTypeIndex][2]);
        //        break;
        //    case "4":
        //        Console.WriteLine("Exiting now...");
        //        return;
        //    default:
        //        Console.Clear();
        //        Console.WriteLine($"Did not recognize '{choice1}', try again.");
        //        break;
        //}

        //for (int i = 0; i < itemTypeIndex; i++)
        //{
            
        //}




        //Console.WriteLine($"1. 'PhoenixWand' - 300$. ({inventoryList[itemTypeIndex][0].Count} In stock)");
        //Console.WriteLine($"2. '{inventoryList[itemTypeIndex][1][0].Name}' - {inventoryList[itemTypeIndex][1][0].CashValue}$. ({inventoryList[itemTypeIndex][1][0].CashValue} In stock)");

        //var ListOfListOfWands

        //Console.WriteLine($"What kind of wand do you want to buy?");
        //Console.WriteLine($"1. 'PhoenixWand' - 300$. ({inventoryList[itemTypeIndex][0].Count} In stock)");
        //if (inventoryList[0])
        //{
            
        //}
        //Console.WriteLine($"2. 'UnicornWand' - 400$. ({inventoryList[itemTypeIndex][1].Count} In stock)");
        //Console.WriteLine($"3. 'TrollWand' - 500$. ({inventoryList[itemTypeIndex][2].Count} In stock)");
        //Console.WriteLine($"4. To exit.");


        //string choice = "";
        //choice = Console.ReadLine();
        //while (choice != "1" && choice != "2" && choice != "3")
        //{
        //    Console.WriteLine("sorry, didnt get that, try again.");
        //    choice = Console.ReadLine();
        //}


        //if (Wands.Count <= 0)
        //{
        //    Console.WriteLine("We aint got none of those... sorry!");
        //    return;
        //}

        //List<Item> items = new List<Item>();

        //foreach (var wand in Wands)
        //{
        //    items.Add(wand);
        //}
        //switch (choice)
        //{
        //    case "1":
        //        buy(curCharacter, "PhoenixWand", 300, inventoryList[itemTypeIndex][0]);
        //        break;
        //    case "2":
        //        buy(curCharacter, "UnicornWand", 400, inventoryList[itemTypeIndex][1]);
        //        break;
        //    case "3":
        //        buy(curCharacter, "TrollWand", 500, inventoryList[itemTypeIndex][2]);
        //        break;
        //    case "4":
        //        Console.WriteLine("Exiting now...");
        //        return;
        //    default:
        //        Console.Clear();
        //        Console.WriteLine($"Did not recognize '{choice}', try again.");
        //        break;
        //}
        //Console.ReadLine();
        //Console.Clear();
    }

    public List<List<List<Item>>> GetInventoryLists()
    {
        //this one is good for now.
        List<Item> PhoenixWands = new List<Item>();
        List<Item> UnicormWands = new List<Item>();
        List<Item> TrollWands = new List<Item>();

        List<Item> Owls = new List<Item>();
        List<Item> Cats = new List<Item>();
        List<Item> Rats = new List<Item>();

        foreach (var item in Inventory)
        {
            switch (item.Type.ToLower())
            {
                case "phoenixwand":
                    PhoenixWands.Add(item);
                    break;
                case "unicornwand":
                    UnicormWands.Add(item);
                    break;
                case "trollwand":
                    TrollWands.Add(item);
                    break;
                case "owl":
                    Owls.Add(item);
                    break;
                case "cat":
                    Cats.Add(item);
                    break;
                case "rat":
                    Rats.Add(item);
                    break;
            }
        }
        //------------------------------------------------------------
        List<List<Item>> wandList = new List<List<Item>>();
        wandList.Add(PhoenixWands);
        wandList.Add(TrollWands);
        wandList.Add(UnicormWands);
        List<List<Item>> PetList = new List<List<Item>>();

        PetList.Add(Owls);
        PetList.Add(Cats);
        PetList.Add(Rats);

        List<List<List<Item>>> MainList = new List<List<List<Item>>>();
        MainList.Add(wandList);
        MainList.Add(PetList);
        //------------------------------------------------------------
        return MainList;
    }
    public int[] CheckInventory()
    {
        //TODO: fix this, maybe update with wandlist and petlist to update that.
        int PhoenixWand = 0;
        int UnicormWand = 0;
        int TrollWand = 0;

        int Owl = 0;
        int Cat = 0;
        int Rat = 0;


        foreach (var item in Inventory)
        {
            switch (item.Name)
            {
                case "PhoenixWand":
                    PhoenixWand++;
                    break;
                case "UnicornWand":
                    UnicormWand++;
                    break;
                case "TrollWand":
                    TrollWand++;
                    break;
                case "Owl":
                    Owl++;
                    break;
                case "Cat":
                    Cat++;
                    break;
                case "Rat":
                    Rat++;
                    break;
            }
        }
        int[] inventoryCount = { PhoenixWand, UnicormWand, TrollWand, Owl, Cat, Rat };
        return inventoryCount;
    }
    
    public void buy(Character curCharacter,string itemName,int price, List<Item> items)
    {
        bool EnoughCash = curCharacter.GetMoneyAmount()>=price;
        if (!EnoughCash)
        {
            Console.WriteLine($"Hey! Get out of here, you don't have enough money!");
            return;
        }
        if(items.Count <= 0){
            Console.WriteLine($"Aint got no inventory bruh...");
        }
        //int amountOfItemsInInventory = 0;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Name.ToLower() == itemName.ToLower())
            {
                //amountOfItemsInInventory++;
                Item itemToSell = items[i];
                items.Remove(itemToSell);
                RemoveFromInventory(itemToSell);
                curCharacter.AddInventoryItem(itemToSell);
                curCharacter.WithdrawCash(price);
                ShopBalance += price;
                Console.WriteLine($"successfully purchased {itemToSell.Name}.(add info here.)");
                return;
            }
            else
            {
                Console.WriteLine($"Out of inventory. for {itemName}");
            }
            return;
        }
    }
}