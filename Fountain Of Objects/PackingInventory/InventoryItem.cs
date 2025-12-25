using System;


namespace IntroductionToC_.Fountain_Of_Objects.PackingInventory
{
    public class InventoryItem
    {
        public string Name { get; private set; }
        public float Weight {  get; private set; }
        public float Volume {  get; private set; }

        public InventoryItem(string name, float weight, float volume)
        {
            Name = name;
            Weight = weight;
            Volume = volume;
        }

        public virtual string ReturnItemData()
        {
            return $"{Name.ToString()} - Weight: {Weight} kg, Volume: {Volume} L";
        }

   
    }

    public class ArrowItem : InventoryItem
    {
        public ArrowItem() : base("Arrow", 0.1f, 0.05f)
        {
          
        }
        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}";
        }
    }

    public class BowItem : InventoryItem
    {
        public int Durability {  get; private set; }
        public float Damage {  get;  set; }

        public BowItem() : base("Bow", 1f, 4f)
        {
            Durability = 100;
            Damage = 5f;
        }

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Damage: {Damage}, Durability: {Durability} ";
        }
    }

    public class RopeItem : InventoryItem
    {
        public float Length { get; set; }
        public int Durability { get; private set; }
        public RopeItem() : base("Rope", 1f, 1.5f)
        {
            Length = 10f; 
            Durability = 100;
        }


        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Length: {Length} m, Durability: {Durability}";
        }
    }

    public class WaterItem : InventoryItem
    {
        public float Capacity {  get; private set; }
        public WaterItem() : base("WaterSkin", 2f, 3f)
        {
            Capacity = 15f;
        }

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Capacity: {Capacity} L";
        }
    }

    public class FoodRationsItem : InventoryItem
    {
        public float TimeBeforeSpoil { get; set; }
        public float NutritionValue { get; private set; }
        public FoodRationsItem() : base("Food Rations", 1f, 0.5f)
        {
            TimeBeforeSpoil = 5f;
            NutritionValue = 200f; 
        }
     

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Time before spoil: {TimeBeforeSpoil} days, Nutrition value: {NutritionValue} kcal";
        }
    }

    public class SwordItem : InventoryItem
    {
        public float Damage { get; set; }
        public int Durability { get; private set; }
        public SwordItem() : base("Sword", 3f, 2f)
        {
            Damage = 10f; 
            Durability = 100; 
        }

        public override string ReturnItemData()
        {
            return $"{base.ReturnItemData()}, Damage: {Damage}, Durability: {Durability}";
        }
    }

}


