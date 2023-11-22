using System.Runtime.InteropServices;

namespace Coffe_Order_Menu
{
    internal class Program
    {
       
        public enum enumDrinks
        {
            Americano=1,
            Latte,
            Cappuccino
        }
        public enum enumSize
        {
            small=1,
            mediam,
            large
        }
        static void Main(string[] args)
        {
            display_menu();
        }
        static void display_menu()
        {
            string menu = "Welcome To coffee Shop!\n" +
                "Menu:\n" +
                "               size: Small(1)     Medium(2)      Large(3)\n" +
                "   Drinks\n" +
                "   1.Americano  |    $2.50        $3.00          $3.50\n" +
                "   2.Latte      |    $3.00        $3.50          $4.00\n" +
                "   3.Cappuccino |    $3.5         $4.00          $4.50\n";
            Console.WriteLine(menu);
            int size;
            string suger;
            string milk;
            int coffee = place_order(out size,out suger,out milk);
            double cost = calculate_cost(coffee, size);
            display_order_summary(coffee, size,suger,milk,cost);


        }
        static int place_order(out int size,out string suger,out string milk)
        {
            bool userChooise;
            int coffee;
            do
            {
                Console.Write("Select a coffee(1-3): ");
                userChooise = Int32.TryParse(Console.ReadLine(), out coffee);
            } while (!userChooise || !Enum.IsDefined(typeof(enumDrinks), coffee));
            Console.WriteLine();
            do
            {
                Console.Write("Select a size (1-3): ");
                userChooise = Int32.TryParse(Console.ReadLine(), out size);
            } while (!userChooise || !Enum.IsDefined(typeof(enumSize), size));
            Console.WriteLine();
            do
            {
                Console.Write("Do you want Suger (yes/no): ");
                suger = Console.ReadLine();
                userChooise = (suger.ToLower()=="yes" || suger.ToLower() == "no")?true:false;
            } while (!userChooise);
            Console.WriteLine();
            do
            {
                Console.Write("Do you want Suger (yes/no): ");
                milk = Console.ReadLine();
                userChooise = (milk.ToLower() == "yes" || milk.ToLower() == "no") ? true : false;
            } while (!userChooise);
            return coffee;
        }
        static double calculate_cost(int coffee,int size)
        {
            List<string> list_price = new List<string> { "2.50", "3.00", "3.50" };
            double cost = Convert.ToDouble(list_price[coffee-1])+(0.5* (size-1));
            return cost;
        }
        static void display_order_summary(int coffee,int size,string suger,string milk,double price)
        {
                string sugerOut = suger.ToLower()=="yes" ? "With Suger" : "Without Suger";
                string milkOut = milk.ToLower() == "yes" ? "With milk" : "Without milk";
                Console.WriteLine("");
                Console.WriteLine($"Your Order Summary: " +
                    $"{(enumDrinks)coffee}" +
                    $" ({(enumSize)size})" +
                    $" {sugerOut} and " +
                    $"{milkOut}");
            Console.WriteLine("Total Cost: $" + price);
            Console.WriteLine("Thanks you for ordering!");
        }
    }
}