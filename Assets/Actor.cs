using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dialougeSystem;

public class Actor : MonoBehaviour
{
    public Dialouge dia;
    // Start is called before the first frame update
    public void StartConvo()
    {
        DialougeSystem.Instance.StartDialouge(dia.root);
    }
}
