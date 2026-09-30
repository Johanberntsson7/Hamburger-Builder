namespace Hamburger_Builder;

class Program
{
    static void Main(string[] args)
    {
        DescribeBurger();
        Console.ReadLine();
    }
    static void DescribeBurger()
    {
        Console.WriteLine("What do you want to order?");
        Burger burger = new Burger();
        Console.WriteLine("Hamburger 1");
        burger.Readinfo();

        Burger burger1 = new Burger();
        Console.WriteLine("Hamburger 2");
        burger1.Readinfo();

        burger.DescribeBurger();
        burger1.DescribeBurger();

    }
}
