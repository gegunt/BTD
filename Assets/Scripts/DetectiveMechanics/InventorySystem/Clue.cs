using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Clue Object", menuName = "Notepad/Clue")]
public class Clue : ItemObject
{
    public void Awake()
    {
        type = ItemType.Clue;
    }
}
