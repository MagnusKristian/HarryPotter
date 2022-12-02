namespace HarryPotter;

public class Menu
{
   
    public void PrintMenu(string[] options)
    {
        Console.WriteLine($"What do you want to do?");
        Console.WriteLine($"'9' to exit.");
        int choice = 0;
        while (choice !=9)
        {
            PrintChoices(options);
            choice = UserChoice(options.Length);
            //if (choice==0)
            //{
            //    return;
            //}
        }

        Console.WriteLine("Exiting menu now.");
        Console.ReadLine();
    }

    public void PrintChoices(string[] options)
    {
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i+1}. {options[i]}.");
        }
    }
    public int UserChoice(int optionsLength)
    {
        
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine("You chose: "+1);
                return 1;
            case "2":
                Console.WriteLine("You chose: " + 2);
                return 2;
            case "3":
                Console.WriteLine("You chose: " + 3);
                return 3;
        }

        Console.WriteLine("You didnt choose anything.");
        return 9;
    }
}