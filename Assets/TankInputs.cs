using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankControls
{
    public enum TankState
    {
        Forward,
        Rotate,
        Idle
    }

    public class TankInputs : MonoBehaviour
    {
        #region variables
        TankState state;
        float forwardInput;
        float rotationInput;

        public TankState State
        {
            get { return state; }
        }
        public float ForwardInput
        {
            get { return forwardInput; }
        }

        public float RotationInput
        {
            get { return rotationInput; }
        }
        #endregion

        // Update is called once per frame
        void Update()
        {
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
                state = TankState.Idle;
            }
        }
    }
}
