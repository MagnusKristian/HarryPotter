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
                    Console.ReadLine();
                    break;
                case "2":
                    BuyItem(curCharacter, MainInventoryList, 1/*1=petsList*/);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("-Not made yet.");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("-Not made yet.");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Exiting now...");
                    Console.ReadLine();
                    return;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"Did not recognize '{choice}', try again.");
                    Console.ReadLine();
                    break;
            }
            
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


        //for each list (of list (of item)) in InventoryList[number(either wands or pets)].
        //this only gets wands and pets.
        //structure is: list(of list(of list(of item))) ?
        //so:   mainlist: (list)
        //          wands: (list)
        //              phoenixwands: (list)
        //                  phoenixwand1: (object)
        //              Unicornwands: (list)
        //                  Unicornwand1: (object)
        //                  Unicornwand2: (object)
        //              Trollwands: (list)
        //                  Trollwand1: (object)
        //                  Trollwand2: (object)
        //                  Trollwand3: (object)
        //          pets: (list)
        //              Owls: (list)
        //                  Owl1: (object)
        //              Cats: (list)
        //                  Cat1: (object)
        //                  Cat2: (object)
        //              Rats: (list)
        //                  Rat1: (object)
        //                  Rat2: (object)
        //                  Rat3: (object)

        int index1 = 0;
        int amountOfItemsToBuy=0;
        int count = 0;
        bool outOfInventory = false;
        //exits if there is no inventory.
        if (inventoryList[itemTypeIndex].Count < 1)
        {
            outOfInventory = true;
        }
        if (outOfInventory == true)
        {
            Console.WriteLine($"Out of inventory! Someone has bought all the stuff.");
            return;
        }
        foreach (var ListOfList in inventoryList[itemTypeIndex])
        {
            //prints the name,price,stock-amount for each type of item in shop-inventory.
            //uses and increases "index1" to display what number the user needs to press to select the item.
            if (ListOfList.Count >=1)
            {
                Console.WriteLine($"{index1 + 1}. To buy: '{ListOfList[0].Name}'- {ListOfList[0].CashValue}$.-{ListOfList.Count} in stock.");
                index1++;
                amountOfItemsToBuy++;
            }
            if(inventoryList[itemTypeIndex].Count <1)
            {
                outOfInventory = true;
                return;
            }
            count++;
        }
        Console.WriteLine($"4. To exit.");

        string choice1 = Console.ReadLine();
        if (choice1 == "4")
        {
            Console.WriteLine($"Exiting now...");
            Console.ReadLine();
            return;
        }
        //checks if the userinput is within the allowed parameters.
        try
        {
            int convertedUserInput = Convert.ToInt32(choice1);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            Console.WriteLine($"NOT A NUMBER: Pick a number between '0' - {index1}.");
            Console.WriteLine($"You chose '{choice1}'.");
            Console.ReadLine();
            return;
        }
        if (Convert.ToInt32(choice1) > index1 || Convert.ToInt32(choice1) < 1)
        {
            Console.WriteLine($"wrong number, pick a number between '0' - {index1}.");
            Console.WriteLine($"You chose '{choice1}'. (converted:'{Convert.ToInt32(choice1)}')");
            Console.ReadLine();
            return;
        }

        int indexOfItemToBuy = Convert.ToInt32(choice1)-1;
        //because zeroindexnumber stuff.
        Console.WriteLine($"this is the number chosen:_indexOfItemToBuy: {indexOfItemToBuy}");
        Console.ReadLine();
        buy(curCharacter, inventoryList[itemTypeIndex][indexOfItemToBuy][0].Name, inventoryList[itemTypeIndex][indexOfItemToBuy][0].CashValue, inventoryList[itemTypeIndex][indexOfItemToBuy]);
        
        //TODO: MASSE BUGS HER. FML.
        if (choice1 == "4")
        {
            return;
        }

    }

    public List<List<List<Item>>> GetInventoryLists()
    {
        //structure is: list(of list(of list(of item))) ?
        //so:   mainlist: (list)
        //          wands: (list)
        //              phoenixwands: (list)
        //                  phoenixwand1: (object)
        //              Unicornwands: (list)
        //                  Unicornwand1: (object)
        //                  Unicornwand2: (object)
        //              Trollwands: (list)
        //                  Trollwand1: (object)
        //                  Trollwand2: (object)
        //                  Trollwand3: (object)
        //          pets: (list)
        //              Owls: (list)
        //                  Owl1: (object)
        //              Cats: (list)
        //                  Cat1: (object)
        //                  Cat2: (object)
        //              Rats: (list)
        //                  Rat1: (object)
        //                  Rat2: (object)
        //                  Rat3: (object)

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
        if (PhoenixWands.Count > 0) { wandList.Add(PhoenixWands); }
        if (TrollWands.Count > 0) { wandList.Add(TrollWands); }
        if (UnicormWands.Count > 0) { wandList.Add(UnicormWands); }

        List<List<Item>> PetList = new List<List<Item>>();

        if (Owls.Count > 0) { PetList.Add(Owls); }
        if (Cats.Count > 0) { PetList.Add(Cats); }
        if (Rats.Count > 0) { PetList.Add(Rats); }

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
        Console.WriteLine($"this is what BUY gets as name::_{itemName}");
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