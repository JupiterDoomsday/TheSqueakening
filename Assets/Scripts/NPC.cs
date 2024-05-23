using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dialougeSystem;
using GameStatMachine;

public class NPC : MonoBehaviour, Interactable
{
    public Dialouge convo;
    // Start is called before the first frame update
    public void OnInteract()
    {
        DialougeSystem.Instance.StartDialouge(convo.root);
    }

    // Update is called once per frame
    public void OnExit()
    {
        
    }
    public InteractableType GetInteractType()
    {
        return InteractableType.NPC;
    }
}
