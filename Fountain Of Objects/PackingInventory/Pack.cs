using System;


namespace IntroductionToC_.Fountain_Of_Objects.PackingInventory
{
   public class Pack
   {
        //store items in the pack
        private InventoryItem[] packInventory = new InventoryItem[3];


        private float _maxWeight;
        private float _currentWeight = 0;

        private float _maxVolume;
        private float _currentVolume = 0;

        private int currentItems = 0;

        public Pack(float maxWeight, int maxVolume)
        {
            _maxWeight = maxWeight;
            _maxVolume = maxVolume;
        }


        public bool AddItem(InventoryItem item)
        {
            if(_currentWeight + item.Weight > _maxWeight || _currentVolume + item.Volume > _maxVolume || IsFull())
            {
                return false;
            }

            packInventory[currentItems] = item;
            currentItems++;
            _currentWeight += item.Weight;
            _currentVolume += item.Volume;
            return true;

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
                    Console.ResetColor();
                }
            }
        }

        public string GetPackDetails()
        {
            return $" Current Pack Size {currentItems}/{packInventory.Length}.  Current Weight: {_currentWeight}/{_maxWeight} kg. Current Volume: {_currentVolume}/{_maxVolume} L";
        }

        public bool IsFull()
        {
            return currentItems >= packInventory.Length;
        }



    }
}
