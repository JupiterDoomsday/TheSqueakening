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
        private bool isDone = false;
        private bool noChoices = true;

        public static DialougeSystem Instance { get; private set; }
        // Start is called before the first frame update
        void Awake()
        {
            if (Instance == null)
                Instance = this;

        }
        public void StartDialouge(DialougeNode convo)
        {
            curNode = null;
            isDone = false;
            ShowUI();
            ShowNode(convo);
        }

        public bool hasChoices()
        {
            return !noChoices;
        }

        public void HideUI()
        {
            parentDialougeUI.SetActive(false);
        }

        public void ShowUI()
        {
            parentDialougeUI.SetActive(true);
        }

        public void ShowNode(DialougeNode convo)
        {
            if (convo)
            {
                curNode = convo;
                noChoices = curNode.choices.Length == 0;
                if (noChoices)
                {
                    charName.SetText(convo.title);
                    diaBox.SetText(convo.text);
                }
            }
            else
            {
                charName.SetText(" ");
                isDone = true;
                HideUI();
            }
        }

        // Update is called once per frame

        public void HandleNext() 
        {

            ShowNode(curNode.next);
        }

        public bool IsDone()
        {
            return isDone;
        }

    }
}
