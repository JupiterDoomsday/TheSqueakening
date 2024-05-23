using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dialougeSystem;
using GameStatMachine;

public class Talking :  Controller
{
    // Start is called before the first frame update
    bool eat = false;
    bool goNext = false;
    public void OnExit()
    {
        eat = false;
        goNext = false;
    }
    public void HandleInput(Player player)
    {

        if (DialougeSystem.Instance.hasChoices())
            return;
        
        if (Input.GetKeyUp(KeyCode.X))
        {
            Debug.Log("Key has been released");
            eat = true;
            return;
        }

        if (Input.GetKeyDown(KeyCode.X) && eat)
        {
            goNext = true;
            eat = false;
        }
    }

    

    public void HandleUpdate(Player player)
    {
        if (goNext)
        {
            DialougeSystem.Instance.HandleNext();
            goNext = false;
        }
        if (DialougeSystem.Instance.IsDone())
        {
            player.state = GameStates.IDLE;
            OnExit();
        }
    }

}
