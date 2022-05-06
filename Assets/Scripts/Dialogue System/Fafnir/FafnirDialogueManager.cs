using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DialogueSystem.Fafnir
{

    //The Dialogue Management System Designed for Lamplight Point and Click Adventures
    public class FafnirDialogueManager : DialogueManager
    {

        public GameObject dialogueOverlay;
        public Transform dialogueContent;
        public GameObject dialogueChunkPrefab;


        public override void StartDialogue(DialogueSequence sequence)
        {
            base.StartDialogue(sequence);

            dialogueOverlay.SetActive(true);

            LoadNode(sequence.dialogueNodeData[0]);
        }


        //Loads The node of dialogue into the dialogue system
        private void LoadNode(DialogueNodeData nodeData)
        {
            Transform newNode = Instantiate(dialogueChunkPrefab, dialogueContent).transform;
            newNode.GetChild(1).GetComponent<TextMeshProUGUI>().text = nodeData.dialogueText;
            var connections = currentSequence.nodeLinks.Where(x => x.BaseNodeGuid == nodeData.guid).ToList();

            if(connections.Count == 0)
            {
                return;
            }

            var targetNodeGuid = connections[0].TargetNodeGuid;
            var targetNode = currentSequence.dialogueNodeData.First(x => x.guid == targetNodeGuid);
            LoadNode(targetNode);
        }

    }
}
