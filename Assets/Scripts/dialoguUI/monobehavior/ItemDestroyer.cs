using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Ludiq;
using Bolt;
using SOEvents;

public class ItemDestroyer : MonoBehaviour
{
    [SerializeField]private Inventory inventory = null;
    [SerializeField]private TextMeshProUGUI confirmText =null;
    [SerializeField]private GameObject player;
    [SerializeField]private StringEvent attacking;

    private int slotIndex = 0;

    private void OnDisable() => slotIndex =-1;
    public string n;

    public void Activate(ItemSlot itemSlot, int slotIndex)
    {
        this.slotIndex = slotIndex;
         n = itemSlot.item.Name;
        

        confirmText.text = $"n!";
        gameObject.SetActive(true);
        attacking.Raise(n);
    }
   /* public IEnumerator Wait()
    {
        yield return new WaitForEndOfFrame();
        Destroy();
        yield break;
    }*/
    public void DoThis()
    {
        Debug.Log("hello we are trying to attack");
        CustomEvent.Trigger(player, n);
    }

    public void Destroy()
    {
        

        inventory.InventoryController.RemoveAt(slotIndex);
            gameObject.SetActive(false);
        
    }

  
}
