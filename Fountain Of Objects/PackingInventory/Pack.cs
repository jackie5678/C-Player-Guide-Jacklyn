using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Fountain_Of_Objects.PackingInventory
{
   public class Pack
   {
        //store items in the pack
        private InventoryItem[] packInventory = new InventoryItem[3];


        private float maxWeight;
        private float currentWeight = 0;

        private float maxVolume;
        private float currentVolume = 0;

        private int currentItems = 0;

        public Pack(float maxWeight, int maxVolume)
        {
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
        }


        public bool AddItem(InventoryItem item)
        {
            if(currentWeight + item.Weight > maxWeight || currentVolume + item.Volume > maxVolume || IsFull())
            {
                return false;
            }
            
            for(int i = 0; i < packInventory.Length; i++)
            {
                if (packInventory[i] == null)
                {
                    packInventory[i] = item;
                    currentWeight += item.Weight;
                    currentVolume += item.Volume;
                    currentItems++;
                    return true;
                }
            }

            return false;
        }

        public void ListItems()
        {
            Console.WriteLine("Pack Contains:");
            foreach(var item in packInventory)
            {
                if(item != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.WriteLine(item.ReturnItemData());
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public string GetPackDetails()
        {
            return $" Current Pack Size {currentItems}/{packInventory.Length}.  Current Weight: {currentWeight}/{maxWeight} kg. Current Volume: {currentVolume}/{maxVolume} L";
        }

        public bool IsFull()
        {
            for(int i = 0; i < packInventory.Length; i++)
            {
                if (packInventory[i] == null)
                {
                    return false;
                }
            }
            return true;
        }



    }
}
