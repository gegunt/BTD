using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleClue : MonoBehaviour, IInteractable
{

    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Collecting clue");
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
