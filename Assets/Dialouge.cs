using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace dialougeSystem
{
    [CreateAssetMenu(fileName = "New Dialouge", menuName = "Dialouge/ Dialouge Asset")]
    public class Dialouge : ScriptableObject
    {
        public DialougeNode root;
    }
}
