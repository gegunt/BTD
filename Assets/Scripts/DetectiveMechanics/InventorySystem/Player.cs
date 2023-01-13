using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IInteractable
{
    public InventoryObject inventory;
    public bool Interact(Interactor interactor)
    {
        var item = interactor.GetComponent<Item>();
        inventory.AddItem(item.item, 1);
        Destroy(interactor.gameObject);
        Debug.Log("Collecting clue");
        return true;
    }
}

