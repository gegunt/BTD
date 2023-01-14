using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Suspect Object", menuName = "Notepad/Suspect")]
public class Suspect : ItemObject
{
    public void Awake()
    {
        type = ItemType.Suspect;
    }
}
