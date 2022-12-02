namespace HarryPotter;

public class PrintIntro
{
    List<Character> Characters = new List<Character>();

    //public List<Character> Characters
    //{
    //    get => characters;
    //    set => characters = value ?? throw new ArgumentNullException(nameof(value));
    //}

    public PrintIntro()
    {
        addCharacters();
    }
    public void addCharacters()
    {
        //Name, Description, Items, House: 
        //Characters.Add(new Character("Harry Potter"));
        //List<Item> items = new List<Item>();

        //Inventory inventory = new Inventory();
        //Wand phoenixWand1 = new Wand("","",40);
        PhoenixWand phoenixWand1 = new PhoenixWand();


        List<Item> wands = new List<Item>();

        //Owl owl = new Owl("Roger");

        wands.Add(phoenixWand1);

        //objects.Add(owl);
        Console.WriteLine(wands.Count);
        //wands[0].PrintWand();
        var phoenix = wands[0] as PhoenixWand;
        Console.WriteLine(phoenix.Damage);

        foreach (var wand in wands)
        {
            var WandWand = wand as Wand;
            WandWand.PrintWand();
        }

        (wands[0] as PhoenixWand).PrintPhoenix();
        (wands[0] as PhoenixWand).PrintWand();
        (wands[0] as Wand).PrintWand();


        //Console.WriteLine(wands[0] as Wand);
        phoenixWand1.PrintPhoenix();
        //Console.WriteLine(objects[0].Name);
        //Console.WriteLine(objects[1].Name);

        //objects[0].



        //List<PhoenixWand> items = new List<PhoenixWand>();
        //List<Item> items = new List<Item>();
        //items.Add(phoenixWand1);

        //List<Item> items = new List<Item>();
        //items.Add(phoenixWand1);

        //Console.WriteLine(phoenixWand1.Damage);
        //Console.WriteLine(items[0].Damage);

        //phoenixWand1.PrintPhoenix();
        //items[0].

    }
    public void print()
    {

    }
}