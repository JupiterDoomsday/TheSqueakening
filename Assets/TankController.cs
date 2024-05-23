using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStatMachine;

namespace TankControls
{
    public enum TankState
    {
        Forward,
        Rotate,
        Idle
    }

    public class TankController : MonoBehaviour, Controller
    {
        #region variabless
        private Rigidbody rgb;
        float forwardInput;
        float rotationInput;
        TankState state;
        public float speed;
        public float rotationSpeed;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            rgb = GetComponent<Rigidbody>();
        }

        public void OnExit()
        {

        }
        public void HandleInput(Player player)
        {

            if (Input.GetKeyDown(KeyCode.X))
            {
                player.state = GameStates.INTERACT;
                state = TankState.Idle;
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                state = TankState.Forward;
                forwardInput = Input.GetAxis("Vertical");
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            {
                state = TankState.Rotate;
                rotationInput = Input.GetAxis("Horizontal");
            }
            else
            {
                player.state = GameStates.IDLE;
                state = TankState.Idle;
            }
        }

        public void HandleUpdate(Player player)
        {
            if(rgb)
            {
                switch(state)
                {
                    case TankState.Forward:
                        HandelMovement(player);
                        break;
                    case TankState.Rotate:
                        RotateMovement(player);
                            break;
                    default:
                        return;

                }
            }
        }

        //forward movement
        protected void HandelMovement(Player player)
        {
            Vector3 forcePos = transform.position + (player.transform.forward * forwardInput * speed * Time.deltaTime);
            rgb.MovePosition(forcePos);
        }

        protected void RotateMovement(Player player)
        {
            Quaternion rot = player.transform.rotation * Quaternion.Euler(Vector3.up * rotationSpeed * rotationInput * Time.deltaTime);
            rgb.MoveRotation(rot);
        }

    }
}
