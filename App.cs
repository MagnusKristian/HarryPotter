namespace HarryPotter;

public class App
{
    public List<Character> Characters { get; set; }
    public Shop Shop { get; set; }
    public Menu Menu { get; set; }
    public Character? CurrentCharacter { get; set; }

    Welcome welcome = new();
    public App()
    {
        Characters = new List<Character>();
        Shop = new Shop();
        Menu = new Menu();
        CurrentCharacter = null;

        AddCharacters();
        AddInventoryItemsToCharacters();


    }
    public void Run()
    {
        Welcome();
        //AddCharacters();
        MainMenu();
    }

    public void MainMenu()
    {
        //Menu.PrintMenu();
        string choice = "";
        do
        {
            Console.WriteLine("\n ******************************");
            Console.WriteLine("          MAIN MENU! ");
            Console.WriteLine("\n ******************************");
            Console.WriteLine("1. Print info");
            Console.WriteLine("2. go to shop");
            Console.WriteLine("3. Send letter");
            Console.WriteLine("4. fight");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("10=cash.(temp)");
            Console.WriteLine("\n ******************************");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    //PrintIntro();
                    //Console.WriteLine("Fix, just print on the character you've chosen.");
                    CurrentCharacter.IntroduceCharacter();
                    break;
                case "2":
                    Console.Clear();
                    Shop.ShopMenu(CurrentCharacter);
                    break;
                case "3":
                    Console.WriteLine("Do magic");
                    Console.WriteLine("-Not made yet.");
                    break;
                case "4":
                    Console.WriteLine("Fight with another wizard?");

                    Console.WriteLine("-Not made yet.");
                    break;
                case "5":
                    Console.WriteLine("Exiting now...");
                    return;
                case "10":
                    CurrentCharacter.DepositCash(1000);
                    Console.WriteLine($"{CurrentCharacter.Name} just recieved $1000 ...");
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

    public void Welcome()
    {
        Console.WriteLine("Welcome to this magic universe!");
        Console.WriteLine("Would you like to be a premade character or do you want to add a new?");
        Console.WriteLine("1 = Premade character. \n2 = Add new character. ");
        string premadeOrNew = Console.ReadLine();
        while (premadeOrNew != "1" && premadeOrNew != "2")
        {
            Console.WriteLine("sorry, didnt get that, try again.");
            premadeOrNew = Console.ReadLine();
        }

        if (premadeOrNew == "1")
        {
            CurrentCharacter = Characters[2];
            Console.WriteLine($"Your character is: {CurrentCharacter.Name}.");
            Console.WriteLine($"Description: {CurrentCharacter.Description}.");
            if (CurrentCharacter.House==null)
            {
                Console.WriteLine($"{CurrentCharacter.Name} does not belong to a house yet. Weird...");
            }
            if (CurrentCharacter.House != null)
            {
                Console.WriteLine($"{CurrentCharacter.Name} Belongs to house '{CurrentCharacter.House}'.");
            }
            return;
        }

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        string description = "";
        Console.WriteLine($"Hi '{name}', Welcome! \nPress 1. to add description, 2. to move on. ");
        string descriptionOrNot = Console.ReadLine();
        while (descriptionOrNot != "1" && descriptionOrNot != "2")
        {
            Console.WriteLine("sorry, didnt get that, try again.");
            descriptionOrNot = Console.ReadLine();
        }
        if (descriptionOrNot == "1")
        {
            Console.WriteLine("Enter a short description of yourself: ");
            description = Console.ReadLine();
            CurrentCharacter = AddCharacter(name, description);
        }
        if (descriptionOrNot == "2")
        {
            CurrentCharacter = AddCharacter(name);
        }
        Console.WriteLine($"Added character successfully. Welcome '{name}'!");
    }

    public Character AddCharacter(string name, string description = null, string house = null)
    {
        Character newCharacter = new Character(name,description,house);
        Characters.Add(newCharacter);
        Console.WriteLine($"Character '{newCharacter.Name}', added successfully.");
        return newCharacter;
    }
    public void AddCharacters()
    {
        //AddCharacter("name");
        //AddCharacter("name","description");
        //AddCharacter("name", "description","house");

        //----------------

        Character Harry = new Character(
            "Harry Potter",
            "Good guy, main character. parents died when he was young.",
            null);
        Characters.Add(Harry);
        Character Ron = new Character(
            "Ron Weasly",
            "Good guy, sidekick, large chaotic family",
            null);
        Characters.Add(Ron);
        Character Draco = new Character(
            "Draco Malfoy",
            "Bad guy, comes from a very bad family, but is he really bad? ",
            "Slytherin");
        Characters.Add(Draco);
    }

    public void AddInventoryItemsToCharacters()
    {
        Characters[0].Inventory.Add(new PhoenixWand());
        Characters[0].Inventory.Add(new TrollWand());

    }
    public void PrintIntro()
    {
        foreach (var character in Characters)
        {
            character.IntroduceCharacter();
        }
    }

    //public void vokal()
    //{
    //    string ord = "abcdefghijklmnopqrstuvwxyzæøå";
    //    string[] vokaler = {"a","e","i","o","u","y","æ","ø","å"};
    //    string ordUtenVokal = "";
    //    foreach (var letter in ord)
    //    {
    //        if (letter.ToString() is "a" or "e" or "i" or "o" or "u" or "y" or "æ" or "ø" or "å")
    //        {
    //            ordUtenVokal += letter.ToString();
    //        }
    //    }
    //    Console.WriteLine(ord);
    //    Console.WriteLine(vokaler);
    //    Console.WriteLine(ordUtenVokal);
    //}

}