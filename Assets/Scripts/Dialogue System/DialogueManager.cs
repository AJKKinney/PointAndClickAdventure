using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{

    //This class initiates dialogue sequences during runtime
    public class DialogueManager : MonoBehaviour
    {

        public static DialogueManager instance;

        internal DialogueSequence currentSequence;


        public void Awake()
        {
            //initialize
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        public virtual void StartDialogue(DialogueSequence sequence)
        {
            if (sequence == null)
            {
                return;
            }

            Debug.Log("Started Dialogue Sequence: " + sequence.name);
            currentSequence = sequence;
        }

        //Loads The node of dialogue into the dialogue system
        public virtual void LoadNode(DialogueNodeData nodeData)
        {

        }
    }
}
