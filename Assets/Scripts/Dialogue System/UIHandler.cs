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

        public virtual void PrepareSequence()
        {
            dialogueOverlay.SetActive(true);
        }
        public virtual void EndSequence()
        {
            dialogueOverlay.SetActive(false);
        }
    }
}
