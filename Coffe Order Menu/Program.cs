namespace Coffe_Order_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Price of drinks as a Constant
            List<string> list_drinks = new List<string> { "Americano", "Latte", "Cappuccino" };
            List<string> list_custimaization = new List<string> { "Small", "Medium", "Large" };
            List<string> list_price = new List<string> { "2.50", "3.00", "3.50" };

            string menu = "Welcome To coffee Shop!\n" +
                "Menu:\n" +
                "   1.Americano - $2.50\n" +
                "   2.Latte - $3.00\n" +
                "   3.Cappuccino - $3.5\n" +
                "Select a coffee(1-3): ";
            Console.Write(menu);
            String type = Console.ReadLine();
            string custimaization = "Customizations:\n" +
                "   1.Small\n" +
                "   2.Medium\n" +
                "   3.Large\n" +
                "Select a size (1-3): ";
            Console.Write(custimaization);
            String size = Console.ReadLine();
            Console.Write("Do you want Suger (yes/no): ");
            string suger = Console.ReadLine();
            Console.Write("Do you wnat Milk (yes/no): ");
            string milk = Console.ReadLine();
            if (milk == "yes" && suger == "no")
            {
                Console.WriteLine("Your Order Summary: " + list_drinks[int.Parse(type) - 1] +
                    "(" + list_custimaization[int.Parse(size)] + ")" + " with Milk");
            }
            else if (milk == "no" && suger == "yes")
            {
                Console.WriteLine("Your Order Summary: " + list_drinks[int.Parse(type) - 1] +
                    "(" + list_custimaization[int.Parse(size)] + ")" + " with Suger");
            }
            else
            {
                Console.WriteLine("Your Order Summary: " + list_drinks[int.Parse(type) - 1] +
                    "(" + list_custimaization[int.Parse(size)] + ")" + " without Milk and Suger");
            }
            Console.WriteLine("Total Cost: $" + list_price[int.Parse(type) - 1]);
            Console.WriteLine("Thanks you for ordering!");
        }
    }
}