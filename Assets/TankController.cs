using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankControls
{
    [RequireComponent(typeof(Rigidbody))]
    public class TankController : MonoBehaviour
    {
        #region variabless
        private Rigidbody rgb;
        private TankInputs input;
        public float speed;
        public float rotationSpeed;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            rgb = GetComponent<Rigidbody>();
            input = GetComponent<TankInputs>();
        }

        void FixedUpdate()
        {
            if(rgb)
            {
                switch(input.State)
                {
                    case TankState.Forward:
                        HandelMovement();
                        break;
                    case TankState.Rotate:
                        RotateMovement();
                            break;
                    default:
                        return;

                }
            }
        }

        //forward movement
        protected void HandelMovement()
        {
            Vector3 forcePos = transform.position + (transform.forward * input.ForwardInput * speed * Time.deltaTime);
            rgb.MovePosition(forcePos);
        }

        protected void RotateMovement()
        {
            Quaternion rot = transform.rotation * Quaternion.Euler(Vector3.up * rotationSpeed * input.RotationInput * Time.deltaTime);
            rgb.MoveRotation(rot);
        } 

    }
}
