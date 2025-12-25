using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Fountain_Of_Objects.PackingInventory
{
    public class InventoryItem
    {
        public string Name { get; private set; }
        public float Weight {  get; private set; }
        public float Volume {  get; private set; }

        public InventoryItem(string name, float weight, float volume)
        {
            this.Name = name;
            this.Weight = weight;
            this.Volume = volume;
        }

        public virtual string ReturnItemData()
        {
            return $"{Name} - Weight: {Weight} kg, Volume: {Volume} L";
        }

   
    }

    public class ArrowItem : InventoryItem
    {

        private int quantity;
        public ArrowItem() : base("Arrow", 0.1f, 0.05f)
        {
            quantity = 20;
        }


        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Quantity: {quantity}";
        }
   
        
  
    }

    public class BowItem : InventoryItem
    {
        private int durability;
        private float damage;

        public BowItem() : base("Bow", 1f, 4f)
        {
            durability = 100;
            damage = 5f;
        }

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Damage: {damage}, Durability: {durability} ";
        }
    }

    public class RopeItem : InventoryItem
    {
        public float length;
        public int durability;
        public RopeItem() : base("Rope", 1f, 1.5f)
        {
            length = 10f; 
            durability = 100;
        }


        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Length: {length} m, Durability: {durability}";
        }
    }

    public class WaterItem : InventoryItem
    {
        public float capacity;
        public WaterItem() : base("WaterSkin", 2f, 3f)
        {
            capacity = 15f;
        }

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Capacity: {capacity} L";
        }
    }

    public class FoodRationsItem : InventoryItem
    {
        public float timeBeforeSpoil;
        public float nutritionValue;
        public FoodRationsItem() : base("Food Rations", 1f, 0.5f)
        {
            timeBeforeSpoil = 5f;
            nutritionValue = 200f; 
        }
     

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Time before spoil: {timeBeforeSpoil} days, Nutrition value: {nutritionValue} kcal";
        }
    }

    public class SwordItem : InventoryItem
    {
        private float damage;
        private int durability; 
        public SwordItem() : base("Sword", 3f, 2f)
        {
            damage = 10f; 
            durability = 100; 
        }

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Damage: {damage}, Durability: {durability}";
        }
    }

}


