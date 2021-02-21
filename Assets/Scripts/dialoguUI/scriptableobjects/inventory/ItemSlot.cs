using UnityEngine;

public struct ItemSlot
{

//wrapper for consumables. 
   public Consumable item;
   [Min(1)] public int quantity;

    public ItemSlot(Consumable item, int quantity)
    {
        this.item = item;
        this.quantity = quantity;

    }
    public static bool operator ==(ItemSlot a, ItemSlot b){return a.Equals(b);}
    public static bool operator !=(ItemSlot a, ItemSlot b) { return !a.Equals(b); }
}
