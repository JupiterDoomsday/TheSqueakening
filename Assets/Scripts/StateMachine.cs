using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankControls;
namespace GameStatMachine {
    public enum GameStates
    {
        WALK,
        TALK,
        MENU,
        INTERACT,
        IDLE
    }
    public enum InteractableType
    {
        ITEM,
        NPC
    }
    public class StateMachine : MonoBehaviour
    {
        GameStates curState;
        IdleController idleController;
        public Interact interactController;
        public TankController tankController;
        public Talking talkController;
        Controller curController;
        public Player player;
    // Start is called before the first frame update
    void Start()
        {
            //generate the "Default inputs"
            idleController = new IdleController();
            curController = idleController;
            talkController = new Talking();
        }

    void Update()
    {
            if (curState != player.state)
            {
                curState = player.state;
                switch (player.state)
                {
                    case GameStates.MENU:
                        break;
                    case GameStates.INTERACT:
                        curController = interactController;
                        break;
                    case GameStates.TALK:
                        curController = talkController;
                        break;
                    case GameStates.WALK:
                        curController = tankController;
                        break;
                    default:
                        curController = idleController;
                        break;
                }
            }
            curController.HandleInput(player);
    }

        // Update is called once per frame
        void FixedUpdate()
        {
            curController.HandleUpdate(player);
        }
    }
}
