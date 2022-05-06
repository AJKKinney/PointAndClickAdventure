using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DialogueSystem.Fafnir
{
    public class FafnirUIHandler : UIHandler
    {
        public Transform dialogueContent;
        public GameObject dialogueChunkPrefab;
        public Transform choiceWheel;
        public GameObject buttonPrefab;

        public override void ReadNode(DialogueNodeData nodeData)
        {
            base.ReadNode(nodeData);

            //Set Dialogue
            Transform newChunk = Instantiate(dialogueChunkPrefab, dialogueContent).transform;
            newChunk.GetChild(1).GetComponent<TextMeshProUGUI>().text = nodeData.dialogueText;
        }

        public override void GenerateChoice(NodeLinkData linkData)
        {
            var button = Instantiate(buttonPrefab, choiceWheel);
            button.name = linkData.PortName;

            //Load next chunk
            var targetNodeGuid = linkData.TargetNodeGuid;
            var targetNode = DialogueManager.instance.currentSequence.dialogueNodeData.First(x => x.guid == targetNodeGuid);


            button.GetComponent<Button>().onClick.AddListener(delegate
            {
                foreach (Transform child in choiceWheel)
                {
                    Destroy(child.gameObject);
                }
                DialogueManager.instance.LoadNode(targetNode);
            });

            button.transform.GetComponentInChildren<TextMeshProUGUI>().text = linkData.PortName;
        }
    }
}
