using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace dialougeSystem
{
    [System.Serializable]
    public class DialougeChoice
    {
        public string text;
        public DialougeNode next;
    }
}
