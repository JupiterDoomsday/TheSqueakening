using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStatMachine;

public class Player : MonoBehaviour
{
    public int range;
    public GameObject notice;
    public GameStates state = GameStates.IDLE;

    Vector3 moving;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("npc"))
            notice.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        notice.SetActive(false);
    }
}
