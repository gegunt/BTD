using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Note Object", menuName = "Notepad/Note")]
public class Note : ItemObject
{
    public void Awake()
    {
        type = ItemType.Note;
    }
}
