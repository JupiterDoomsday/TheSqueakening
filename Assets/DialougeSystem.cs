using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace dialougeSystem
{
    public class DialougeSystem : MonoBehaviour
    {
        public GameObject parentDialougeUI;
        public TextMeshProUGUI charName;
        public DialougeNode curNode;
        public TextMeshProUGUI diaBox;
        private bool noChoices = true;

        public static DialougeSystem Instance { get; private set; }
        // Start is called before the first frame update
        void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
            
            HideUI();
        }

        public void StartDialouge(DialougeNode convo)
        {
            charName.text = convo.title;
            diaBox.text = convo.text;
            /*noChoices = curNode.choices.Length == 0;*/
            if(noChoices)
            {

            }
            curNode = convo;

        }

        public void HideUI()
        {
            parentDialougeUI.SetActive(false);
        }

        public void ShowUI()
        {
            parentDialougeUI.SetActive(true);
        }

        // Update is called once per frame

        public void HandleNext() 
        {
            StartDialouge(curNode.next);
        }
    }
}
