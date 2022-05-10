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
        public RectTransform dialogueContent;
        public GameObject dialogueChunkPrefab;
        public Transform choiceWheel;
        public GameObject buttonPrefab;
        public Scrollbar scrollBar;

        private bool setHeight = false;

        private void LateUpdate()
        {
            //set Ui Scroll
            if(setHeight == true)
            {
                scrollBar.value = 0;
                setHeight = false;
            }
        }

        public override void ReadNode(DialogueNodeData nodeData)
        {
            base.ReadNode(nodeData);

            //Set Dialogue
            RectTransform newChunk = Instantiate(dialogueChunkPrefab, dialogueContent).GetComponent<RectTransform>();
            newChunk.GetChild(1).GetComponent<TextMeshProUGUI>().text = nodeData.dialogueText;

            //set scroll position
            setHeight = true;
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
