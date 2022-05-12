using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DialogueSystem.Fafnir
{

    //The Dialogue Management System Designed for Lamplight Point and Click Adventures
    [RequireComponent(typeof(FafnirUIHandler))]
    public class FafnirDialogueManager : DialogueManager
    {
        private FafnirUIHandler UIHandler;

        public void Awake()
        {
            base.Awake();
            UIHandler = GetComponent<FafnirUIHandler>();
        }


        public override void StartDialogue(DialogueSequence sequence)
        {
            UIHandler.ClearChoices();

            base.StartDialogue(sequence);

            UIHandler.PrepareSequence();

            LoadNode(sequence.dialogueNodeData[0]);
        }


        //Loads The node of dialogue into the dialogue system
        public override void LoadNode(DialogueNodeData nodeData)
        {
            if (nodeData.nodeType == DialogueNode.NodeType.Exit)
            {
                UIHandler.EndSequence();
                return;
            }

            UIHandler.ReadNode(nodeData);

            //Get Connections
            var connections = currentSequence.nodeLinks.Where(x => x.BaseNodeGuid == nodeData.guid).ToList();

            if(connections.Count == 0)
            {
                return;
            }

            //Handle Standard Dialogue
            if(nodeData.nodeType == DialogueNode.NodeType.Dialogue)
            {
                HandleDialogueNode(connections);
            }
            //Enable Choice
            else if (nodeData.nodeType == DialogueNode.NodeType.Choice)
            {
                HandleChoiceNode(connections);
            }
        }


        private void HandleDialogueNode(List<NodeLinkData> connections)
        {
            //Load next chunk
            var targetNodeGuid = connections[0].TargetNodeGuid;
            var targetNode = currentSequence.dialogueNodeData.First(x => x.guid == targetNodeGuid);

            LoadNode(targetNode);
        }


        private void HandleChoiceNode(List<NodeLinkData> connections)
        {
            for(int i = 0; i < connections.Count; i++)
            {
                UIHandler.GenerateChoice(connections[i]);
            }
        }
    }
}
