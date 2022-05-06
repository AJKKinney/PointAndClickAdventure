using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    public class UIHandler : MonoBehaviour
    {

        public GameObject dialogueOverlay;

        public virtual void ReadNode(DialogueNodeData nodeData)
        {

        }

        public virtual void GenerateChoice(NodeLinkData linkData)
        {

        }

        public virtual void PrepareDialogueSequence()
        {
            dialogueOverlay.SetActive(true);
        }
    }
}
