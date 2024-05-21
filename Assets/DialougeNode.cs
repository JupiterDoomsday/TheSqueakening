using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace dialougeSystem
{
    [CreateAssetMenu(fileName = "New DialougeNode", menuName = "Dialouge/ Dialouge Node")]
    public class DialougeNode: ScriptableObject
    {
        public string text;
        public string title;
        public DialougeNode next;
        public DialougeChoice[] choices;
    }
}
