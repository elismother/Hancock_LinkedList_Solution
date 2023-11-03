// Brittany Hancock
// IT113
// NOTES: none
// BEHAVIORS NOT IMPLIMENTED AND WHY: n/a
namespace Hancock_LinkedList_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            bool exit = false;
            while (!exit)
            {
                Menu();
                string input = Console.ReadLine();

                if (input == "1")
                {
                    ClearScreen();
                    Console.Write("Enter the name to add: ");
                    string itemToAdd = Console.ReadLine();
                    ClearScreen();
                    Console.WriteLine(MyList.Add(itemToAdd));
                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    bool list = MyList.ValidList();
                    if (!list)
                    {
                        ClearScreen();
                        Console.WriteLine("No list to remove from.");
                        Console.WriteLine();
                    }
                    else
                    {
                        ClearScreen();
                        Console.Write("Enter the name to remove: ");
                        string itemToRemove = Console.ReadLine();
                        ClearScreen();
                        Console.WriteLine(MyList.Remove(itemToRemove));
                        Console.WriteLine();
                    }
                }
                else if (input == "3")
                {
                    bool list = MyList.ValidList();
                    if (!list)
                    {
                        ClearScreen();
                        Console.WriteLine("No list to search.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Enter the name to search for: ");
                        string itemToSearch = Console.ReadLine();
                        bool found = MyList.Contains(itemToSearch);
                        if (found)
                        {
                            ClearScreen();
                            Console.WriteLine("Item found.");
                            Console.WriteLine();
                        }
                        else
                        {
                            ClearScreen();
                            Console.WriteLine("Item not found.");
                            Console.WriteLine();
                        }
                    }
                }
                else if (input == "4")
                {
                    ClearScreen();
                    bool list = MyList.ValidList();
                    if (!list)
                    {
                        Console.WriteLine("No list to print");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("List Items:\n");
                        MyList.PrintAllNodes();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadLine();
                        ClearScreen();
                    }
                }
                else if (input == "5")
                {
                    ClearScreen();
                    exit = true;
                }

                else
                {
                    ClearScreen();
                    Console.WriteLine("Invalid option, please try again.");
                    Console.WriteLine();
                }
            }

            void Menu()
            {
                Console.WriteLine("Please choose an option:" +
                    "\nPress 1 to add an item" +
                    "\nPress 2 to remove an item" +
                    "\nPress 3 to search for an item" +
                    "\nPress 4 to print all items " +
                    "\nPress 5 to exit");
            }

            void ClearScreen()
            {
                Console.Clear();
            }
        }
    }
}