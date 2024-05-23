using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStatMachine;

interface Interactable
{
    // Start is called before the first frame update
    void OnInteract();
    void OnExit();
    InteractableType GetInteractType();
}
