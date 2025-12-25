using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Fountain_Of_Objects.PackingInventory
{
    public class InventoryPacker
    {
     
        Pack backpack = new Pack(5.0f, 8);
        //Pack BeltPouch = new Pack(2.0f, 3);
        //Pack MountSatchel = new Pack(10.0f, 15);

        public void Run()
        {
            Console.WriteLine("Welcome To The Inventory Packer!");
            Console.WriteLine("Pack Items in to your Backpack for your journey");
            DisplayBackpackDetails();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            DisplayMenu();

            while (true)
            {
                int input = GetInput();
                Console.WriteLine(); 
                
                if(input >= 9)
                {
                    Console.WriteLine("Invalid Input");
                }
                else if (input == 8)
                {
                    Console.WriteLine("Exiting Inventory Packer. Safe travels!");
                    break;
                }
                else if (input == 7)
                {
                    backpack.ListItems();
                }
                else
                {
                    InventoryItem item = CreateInventoyItem(input);
                
                   if (backpack.AddItem(item))
                   {
                     DisplayMessage(item);
                   }
                   else
                   {
                      DisplayErrorMessage(item);
                   }
                      
                }
               
                Console.WriteLine();
 
                backpack.ListItems();

                Console.WriteLine();
                DisplayBackpackDetails();

                DisplayMenu();
            }

        }

        public void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Arrow");
            Console.WriteLine("2. Add Bow");
            Console.WriteLine("3. Add Rope");
            Console.WriteLine("4. Add Water Bottle");
            Console.WriteLine("5. Add Food Rations");
            Console.WriteLine("6. Add Sword");  
            Console.WriteLine("7. List Items in Backpack");
            Console.WriteLine("8. Exit");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public int GetInput()
        {
            
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public void DisplayBackpackDetails()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine($"Backpack {backpack.GetPackDetails()}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
        }

        public InventoryItem CreateInventoyItem(int input)
        {
             return input switch
             {
                1 => new ArrowItem(),
                2 =>  new BowItem(),
                3 => new  RopeItem(),
                4 => new WaterItem(),
                5 => new FoodRationsItem(),
                6 => new SwordItem(),
                //_ => throw new NotImplementedException()
            };

         
        }


        public void DisplayMessage(InventoryItem inventoryItem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added {inventoryItem.Name} to backpack.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void DisplayErrorMessage(InventoryItem inventoryItem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Could not add {inventoryItem.Name} to your backpack.\nBackpack is full or Item weight or volume is over the max limit. ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

    }


}
