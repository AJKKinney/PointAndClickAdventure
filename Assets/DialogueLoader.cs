using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueLoader : MonoBehaviour
    {
        public DialogueSequence dialogueSequence;

        // Start is called before the first frame update
        void Start()
        {
            DialogueManager.instance.StartDialogue(dialogueSequence);
        }
    }
}
