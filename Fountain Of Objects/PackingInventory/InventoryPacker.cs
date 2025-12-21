using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Fountain_Of_Objects.PackingInventory
{
    public class InventoryPacker
    {
     
        Pack Backpack = new Pack(5.0f, 8);
        //Pack BeltPouch = new Pack(2.0f, 3);
        //Pack MountSatchel = new Pack(10.0f, 15);

        public void Run()
        {
            Console.WriteLine("Welcome To The Inventory Packer!");
            Console.WriteLine("Pack Items in to your Backpack for your journey");
            Console.WriteLine($"Backpack {Backpack.GetPackDetails()}");
            Console.WriteLine();

            DisplayMenu();

            while (true)
            {
                int input = GetInput();
                Console.WriteLine();    
                if (input == 8)
                {
                    Console.WriteLine("Exiting Inventory Packer. Safe travels!");
                    break;
                }
                else if (input == 7)
                {
                    Backpack.ListItems();
                }
                else
                {
                    CreateInventoyItem(input);
                }
                Console.WriteLine();
                DisplayMenu();
                Console.WriteLine();
                Console.WriteLine($"Backpack {Backpack.GetPackDetails()}");
            }

        }

        public void DisplayMenu()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Arrow");
            Console.WriteLine("2. Add Bow");
            Console.WriteLine("3. Add Rope");
            Console.WriteLine("4. Add Water Bottle");
            Console.WriteLine("5. Add Food Rations");
            Console.WriteLine("6. Add Sword");  
            Console.WriteLine("7. List Items in Backpack");
            Console.WriteLine("8. Exit");
        }


        public int GetInput()
        {
            
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public int CreateInventoyItem(int input)
        {
            switch (input)
            {
                case 1:
                    ArrowItem arrow = new ArrowItem();
                    if (Backpack.AddItem(arrow))
                    {
                       DisplayMessage(arrow);
                    }
                    else
                    {
                        DisplayErrorMessage(arrow);
                    }
                    break;
                case 2:
                    BowItem bow = new BowItem();
                    if (Backpack.AddItem(bow))
                    {
                       DisplayMessage(bow);
                    }
                    else
                    {
                       DisplayErrorMessage(bow);
                    }
                    break;
                case 3:
                    RopeItem rope = new RopeItem();
                    if (Backpack.AddItem(rope))
                    {
                       DisplayMessage(rope);
                    }
                    else
                    {
                       DisplayErrorMessage(rope);
                    }
                    break;
                case 4:
                    WaterItem waterBottle = new WaterItem();
                    if (Backpack.AddItem(waterBottle))
                    {
                        DisplayMessage(waterBottle);
                    }
                    else
                    {
                        DisplayErrorMessage(waterBottle);
                    }
                    break;
                case 5:
                    FoodRationsItem foodRation = new FoodRationsItem();
                    if (Backpack.AddItem(foodRation))
                    {
                        DisplayMessage(foodRation);
                    }
                    else
                    {
                        DisplayErrorMessage(foodRation);
                    }
                    break;
                case 6:
                    SwordItem sword = new SwordItem();
                    if (Backpack.AddItem(sword))
                    {
                        DisplayMessage(sword);
                    }
                    else
                    {
                        DisplayErrorMessage(sword);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            return input;
        }

        public void DisplayErrorMessage(InventoryItem inventoryItem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Could not add {inventoryItem.GetName()} to your backpack.\nBackpack is full or Item weight or volume is over the max limit. ");
           
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void DisplayMessage(InventoryItem inventoryItem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added {inventoryItem.GetName()} to backpack.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }

    
}
