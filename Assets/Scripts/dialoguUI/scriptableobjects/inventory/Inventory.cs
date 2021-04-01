using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOEvents;

[CreateAssetMenu(fileName = "new inventory", menuName ="inventory/base")]
public class Inventory: ScriptableObject
{
    [SerializeField] private VoidEvent onInventoryItemsUpdated = null;
    [SerializeField] public ItemSlot[] testItemSlot;
    
    public InventoryController InventoryController {get;} = new InventoryController(6);

    public void OnEnable()
    {
        InventoryController.OnItemUpdated += onInventoryItemsUpdated.Raise;
    }
    public void OnDisable()
    {
        InventoryController.OnItemUpdated -= onInventoryItemsUpdated.Raise;
    }
    [ContextMenu("Test Add0")]
    [SerializeField]public void testAddAttackone()
    {
        InventoryController.AddItem( testItemSlot[0]);
    }
    [ContextMenu("Test Add1")]
    [SerializeField]
    public void testAddAttacktwo()
    {
        InventoryController.AddItem(testItemSlot[1]);
    }
    [ContextMenu("Test Add3")]
    [SerializeField]
    public void testAddAttackthree()
    {
        InventoryController.AddItem(testItemSlot[2]);
    }


}
