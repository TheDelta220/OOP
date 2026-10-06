



namespace Swin_Adventure3
{
    internal class Program
    {
        static void Main()
        {
            Inventory inventory = new Inventory();
            Bag bag = new Bag(new string[] { "bag" }, "a bag", "This is a bag");
            Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
            Item axe = new Item(new string[] { "axe" }, "a axe", "This is a axe");
            Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
            bool end = false;
            LookCommand look = new LookCommand();

            Console.WriteLine("What is your name traveller?");
            string name = Console.ReadLine();
            Console.WriteLine("what is your desciption?");
            string info = Console.ReadLine();
            Player traveller = new Player(name, info);
            traveller.Inventory.Put(axe);
            traveller.Inventory.Put(shovel);
            traveller.Inventory.Put(bag);
            bag.Inventory.Put(sword);
            
            while (end = false)
            {
                Console.WriteLine("Command:");
                string command = Console.ReadLine();
                if (command == "exit")
                {
                    end = true;
                }
                else
                {
                    Console.WriteLine(look.Execute(traveller, command.Split()));
                }

            }






        }
    }
}
