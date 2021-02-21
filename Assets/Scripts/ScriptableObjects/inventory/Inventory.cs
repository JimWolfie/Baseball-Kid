using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: ScriptableObject, IItemContainer
{
    public ItemSlot AddItem(ItemSlot item)
    {
        throw new System.NotImplementedException();
    }

    public int GetTotal(Consumable item)
    {
        throw new System.NotImplementedException();
    }

    public bool HasItem(Consumable item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int indexSlot)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveItem(ItemSlot item)
    {
        throw new System.NotImplementedException();
    }

    public void Swap(int index1, int index2)
    {
        throw new System.NotImplementedException();
    }
}
