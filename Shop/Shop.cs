﻿namespace HarryPotter;

public class Shop
{
    public InventoryManager InventoryManager = new InventoryManager();
    public int ShopBalance { get; set; } 
    //get rid  of wands or comment out.
    //public List<Wand> Wands { get; set; }
    //public List<Pet> Pets { get; set; }

    public List<Item> Inventory { get; set; }
    //public List<TrollWand> TrollWands { get; set; }

    public Shop()
    {
        ShopBalance = 10_000;
        //Wands = new List<Wand>();
        //Pets = new List<Pet>();
        Inventory = new List<Item>();
        
        AddInventory();
        
    }

    public void ShopMenu(Character curCharacter)
    {
        string choice = "";
        do
        {
            //List<Item>[] ItemList = GetInventory();

            //List<List<Item>> ItemList2 = new List<List<Item>>();

            //List<List<Item>[]> ListItemList = GetInventoryLists();

            List<List<List<Item>>> MainInventoryList = GetInventoryLists();
            //List<List<Item>> wands = MainInventoryList[0];
            //List<List<Item>> pets = MainInventoryList[1];


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
        InventoryManager.AddItemToList("PhoenixWand", 1, Inventory);
        InventoryManager.AddItemToList("UnicornWand",2,Inventory);
        InventoryManager.AddItemToList("TrollWand", 3, Inventory);

        InventoryManager.AddItemToList("Owl", 1, Inventory);
        InventoryManager.AddItemToList("Cat", 2, Inventory);
        InventoryManager.AddItemToList("Rat", 3, Inventory);



        //InventoryManager.AddTrollWandsToList(TrollWands, 5);

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





    public void BuyWand(Character curCharacter, List<List<List<Item>>> inventoryList)
    {
        //List<Item>[] list = listItemList;
        //Item someItem = list[3][0];
        //Console.WriteLine(someItem.Name);

        //List[0] = phoenixwands
        //List[1] = unicornwands
        //and so on...
        //TODO: wtf am i even doing, i should probably document my thought process huh? :D
        //could this work?
        //List<Item>[] inventory = GetInventory();
        //List<Item>[] ItemList = GetInventory();
        //List<List<Item>[]>[] ListItemList = GetInventoryLists();

        //--------------------------------

        int[] inventoryCount = CheckInventory();

        Console.WriteLine($"What kind of wand do you want to buy?");
        Console.WriteLine($"1. 'PhoenixWand' - 300$. ({inventoryList[0][0].Count} In stock)");
        Console.WriteLine($"2. 'UnicornWand' - 400$. ({inventoryList[0][1].Count} In stock)");
        Console.WriteLine($"3. 'TrollWand' - 500$. ({inventoryList[0][2].Count} In stock)");
        Console.WriteLine($"4. To exit.");


        string choice = "";
        choice = Console.ReadLine();
        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("sorry, didnt get that, try again.");
            choice = Console.ReadLine();
        }
        //if (Wands.Count <= 0)
        //{
        //    Console.WriteLine("We aint got none of those... sorry!");
        //    return;
        //}

        List<Item> items = new List<Item>();

        //foreach (var wand in Wands)
        //{
        //    items.Add(wand);
        //}
        switch (choice)
        {
            case "1":
                //buy(curCharacter,"PhoenixWand",300, inventoryList[0]);
                break;
            case "2":
                //buy(curCharacter, "UnicornWand", 400, inventoryList[1]);
                break;
            case "3":
            //buy(curCharacter, "TrollWand", 500, inventoryList[2]);
                break;
            case "4":
                Console.WriteLine("Exiting now...");
                return;
            default:
                Console.Clear();
                Console.WriteLine($"Did not recognize '{choice}', try again.");
                break;
        }
            //Console.ReadLine();
            //Console.Clear();
    }
    public List<Item>[] GetInventory()
    {

        List<Item> PhoenixWands = new List<Item>();
        List<Item> UnicormWands = new List<Item>();
        List<Item> TrollWands = new List<Item>();

        List<Item> Owls = new List<Item>();
        List<Item> Cats = new List<Item>();
        List<Item> Rats = new List<Item>();

        //_--------------------------------------------
        List<List<Item>> wandList = new List<List<Item>>(3);
        wandList.Add(PhoenixWands);
        wandList.Add(TrollWands);
        wandList.Add(UnicormWands);
        List<List<Item>> PetList = new List<List<Item>>(3);

        PetList.Add(Owls);
        PetList.Add(Cats);
        PetList.Add(Rats);

        List<List<List<Item>>> MainList = new List<List<List<Item>>>(2);
        MainList.Add(wandList);
        MainList.Add(PetList);

        //string name = MainList[0] /*wands*/[0] /*phoenixwands*/[0] /*first phoenixwand*/.Name;
        //Item phoenixwand1 = MainList[0] /*wands*/[0] /*phoenixwands*/[0] /*first phoenixwand*/;


        //----------------------------------------------


        foreach (var item in Inventory)
        {
            switch (item.Name)
            {
                case "PhoenixWand":
                    PhoenixWands.Add(item);
                    break;
                case "UnicornWand":
                    UnicormWands.Add(item);
                    break;
                case "TrollWand":
                    TrollWands.Add(item);
                    break;
                case "Owl":
                    Owls.Add(item);
                    break;
                case "Cat":
                    Cats.Add(item);
                    break;
                case "Rat":
                    Rats.Add(item);
                    break;
            }
        }
       
        List<Item>[] inventory = { PhoenixWands, UnicormWands, TrollWands, Owls, Cats, Rats };
        return inventory;
    }
    public List<List<List<Item>>> GetInventoryLists()
    {
        //List<List<Item>[]> GetInventoryLists()
        List<Item> PhoenixWands = new List<Item>();
        List<Item> UnicormWands = new List<Item>();
        List<Item> TrollWands = new List<Item>();

        List<Item> Owls = new List<Item>();
        List<Item> Cats = new List<Item>();
        List<Item> Rats = new List<Item>();

        //List<List<Item>> listTest = new List<List<Item>>();
        //listTest[0].Add(PhoenixWands);
        //listTest.Add(UnicormWands);
        //L


        foreach (var item in Inventory)
        {
            switch (item.Name)
            {
                case "PhoenixWand":
                    PhoenixWands.Add(item);
                    break;
                case "UnicornWand":
                    UnicormWands.Add(item);
                    break;
                case "TrollWand":
                    TrollWands.Add(item);
                    break;
                case "Owl":
                    Owls.Add(item);
                    break;
                case "Cat":
                    Cats.Add(item);
                    break;
                case "Rat":
                    Rats.Add(item);
                    break;
            }
        }

        //List<List<Item>>[] wandss = new List<List<Item>>[3];
        //wandss[0].Add(PhoenixWands); //= PhoenixWands;
        //wandss[1].Add(UnicormWands);
        //wandss[2].Add(TrollWands);

        //List<List<Item>[]> petss = new List<List<Item>[]>(3);
        //petss[0] = new List<Item>[3]; //Add(Owls); //= PhoenixWands;
        //petss[0][0] = Cats;
        //petss[0][1] = Rats;
        //petss[0][2] = Cats;
        //int tegs = petss[0][0].Count;
        //petss[1].Add(Cats);
        //petss[2].Add(Rats);

        //this
        List<Item>[] pets = new List<Item>[3];
        pets[0] = Owls;
        pets[1] = Rats;
        pets[2] = Cats;

        List<Item>[] wands = new List<Item>[3];
        wands[0] = PhoenixWands;
        wands[1] = UnicormWands;
        wands[2] = UnicormWands;
        //this

        //maybe this
        // List<Item>[] pets = new List<Item>[3];

        //List<List<Item>[]> lists = new List<List<Item>[]>(2);
        //lists[0] = wands;
        //lists[1] = pets;

        //Item itemitem = lists[0][0][0];

        //maybe this




        //List<List<Item>>[] inventoryLists = new List<List<Item>>[2];
        //List<List<List<Item>[]>[]>[] qweqwe = new List<List<List<Item>[]>[]>[2];
        //int nla = qweqwe[0][0][0].Count;
        //inventoryLists[0][0][0] = new List<Item>();
        //inventoryLists[0] = wandss;
        //inventoryLists[0][0] = TrollWands;
        //inventoryLists[0][1] = TrollWands;


        //int lsls = inventoryLists[0][0].Length;

        //int ienf = inventoryLists[0][0][0].Count; //.Add(wandss);

        //List<Item> Owls = new List<Item>();
        //List<List<Item>>[] wandss = new List<List<Item>>[3];
        //List<List<Item>>[]

        //List<List<Item>[]>[] = 

        //______________________________


        //List<List<Item>> wands = { PhoenixWands, UnicormWands, TrollWands };
        //List<Item>[] pets = { Owls, Cats, Rats };


        //List<List<Item>[]>[] inventoryListsx = new List<List<Item>[]>[2];
        //List<List<string>> myList = new List<List<string>>();
        //inventoryLists[0][0].Add(wands);
        //inventoryLists[1].Add(pets);
        List<List<Item>[]> inventoryLists = new List<List<Item>[]>();
        inventoryLists.Add(wands);
        inventoryLists.Add(wands);
        //inventoryLists[0] = wands;
        //inventoryLists[1] = pets;

        //------------------------------------------------------------
        List<List<Item>> wandList = new List<List<Item>>(3);
        wandList.Add(PhoenixWands);
        wandList.Add(TrollWands);
        wandList.Add(UnicormWands);
        List<List<Item>> PetList = new List<List<Item>>(3);

        PetList.Add(Owls);
        PetList.Add(Cats);
        PetList.Add(Rats);

        List<List<List<Item>>> MainList = new List<List<List<Item>>>(2);
        MainList.Add(wandList);
        MainList.Add(PetList);
        //------------------------------------------------------------

        return MainList;
    }
    public int[] CheckInventory()
    {
        
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
    public void BuyPet(Character curCharacter)
    {
        int[] inventoryCount = CheckInventory();
        Console.WriteLine($"What kind of Pet do you want to buy?");
        Console.WriteLine($"1. 'Owl' - 500$. ({inventoryCount[3]} In stock)");
        Console.WriteLine($"2. 'Cat' - 400$. ({inventoryCount[4]} In stock)");
        Console.WriteLine($"3. 'Rat' - 300$. ({inventoryCount[5]} In stock)");
        Console.WriteLine($"4. To exit.");


        string choice = "";
        choice = Console.ReadLine();
        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("sorry, didnt get that, try again.");
            choice = Console.ReadLine();
        }
        if (Inventory.Count <= 0)
        {
            Console.WriteLine("We aint got none of those... sorry!");
            return;
        }
        List<Item> items = new List<Item>();
        //foreach (var Pet in Pets)
        //{
        //    items.Add(Pet);
        //}
        switch (choice)
        {
            case "1":
                buy(curCharacter, "Owl", 500, items);
                break;
            case "2":
                buy(curCharacter, "Cat", 400, items);
                break;
            case "3":
                buy(curCharacter, "Rat", 300, items);
                break;
            case "4":
                Console.WriteLine("Exiting now...");
                return;
            default:
                Console.Clear();
                Console.WriteLine($"Did not recognize '{choice}', try again.");
                break;
        }
        //Console.ReadLine();
        //Console.Clear();
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