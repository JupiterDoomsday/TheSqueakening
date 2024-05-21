using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int range;
    Vector3 moving;
    // Start is called before the first frame update
    void Start()
    {

    }

    bool Interact()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range, 3))
        {
            Debug.Log("Ray cast Hit at distance: " + hit.distance);
            return true;
        }
        return false;
    }
}
