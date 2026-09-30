namespace Hamburger_Builder;

public class Burger
{
    public string Bread = "";

    public string Meat = "";

    public string Topping = "";

    public void Readinfo()
    {
        Console.WriteLine("What do you want for bread?");
        Bread = Console.ReadLine()?? "";
        Console.WriteLine("And what type of Meat do you want?");
        Meat = Console.ReadLine()?? "";
        Console.WriteLine("And do you want some topping?");
        Topping = Console.ReadLine()?? "";
    }
    public void DescribeBurger()
    {
        Console.WriteLine($"you want a burger with{Bread} bread and for your meat you wanted {Meat} and for topping you wanted {Topping}");
    }
}

