using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

namespace DialogueSystem
{

    //This Class contains node data for the dialogue system
    public class DialogueNode : Node
    {
        public string GUID;
        public string dialogueText;
        public bool entryPoint = false;
    }
}
