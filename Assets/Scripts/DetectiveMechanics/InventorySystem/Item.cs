using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{ 
    public ItemObject item;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Collecting item");
        return true;
    }

}
