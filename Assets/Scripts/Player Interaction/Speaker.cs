using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueSystem;

public class Speaker : Interactable
{
    DialogueManager manager;

    public DialogueSequence loadedSequence;

    public void Start()
    {
        //initialize
        manager = DialogueManager.instance;
    }

    public override void Interact()
    {
        base.Interact();

        manager.StartDialogue(loadedSequence);
    }
}
