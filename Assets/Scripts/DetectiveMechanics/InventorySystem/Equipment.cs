using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Notepad/Equipment")]
public class Equipment : ItemObject
{
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
