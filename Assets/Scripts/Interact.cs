using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameStatMachine
{
    
    [RequireComponent(typeof(Transform))]
    public class Interact : MonoBehaviour, Controller
    {
        Interactable interaction;
        public GameObject textBoxUI;
        //public Vector3 offset;
        // Start is called before the first frame update

        public void Start()
        {
        }
        public void HandleInput(Player player)
        {
        }

        public void OnExit()
        {
        }

        public void HandleUpdate(Player player)
        {
            if (interaction != null)
            {
                player.state = GameStates.TALK;
                interaction.OnInteract();
                return;
            }
            player.state = GameStates.IDLE;
            OnExit();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("npc"))
            {
                interaction = other.GetComponent<NPC>();
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("npc"))
            {
                interaction = null;
            }
        }
    }
}
