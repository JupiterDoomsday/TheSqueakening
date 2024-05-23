using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStatMachine
{
    public class IdleController : Controller
    {
        // Start is called before the first frame update
        public void HandleInput(Player player)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                player.state = GameStates.INTERACT;
            }
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Space))
            {
                player.state = GameStates.MENU;
            }
            if (Input.GetAxis("Horizontal") != 0 || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                player.state = GameStates.WALK;
            }
        }

        public void OnExit()
        {
        }

        public void HandleUpdate(Player player)
        {

        }
    }
}
